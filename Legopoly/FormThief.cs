using FoundationLibraries.Xml;
using Legopoly.Data;
using Legopoly.Data.Items;
using Legopoly.Data.Thiefs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legopoly
{
	public partial class FormThief : Form
	{
		#region Data Members
		private const string thiefFileName = "thiefs.xml";

		private Game _game;
		private Player _player;
		private Thief[] _thiefs;
		private ItemBase[] _items;
		private int _jailDelay = 0;
		private double _fine = 0.0;
		#endregion

		#region Constructor
		public FormThief(Game game, Player player)
		{
			this._game = game;
			this._player = player;

			InitializeComponent();
			InitializeFormContent();
		}
		#endregion

		#region Public Properties
		public int JailDelay
		{
			get
			{
				return this._jailDelay;
			}
		}

		public double Fine
		{
			get
			{
				return this._fine;
			}
		}
		#endregion

		#region Private Methods
		private void InitializeFormContent()
		{
			this._items = ItemBase.GetAllItems();

			// Load Thief file
			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, thiefFileName);
			if (File.Exists(filePath) == false)
				throw new FileNotFoundException(string.Format("Impossible de trouver le fichier '{0}' !", thiefFileName));

			this._thiefs = XmlSerializationHelper.HelperUTF8.FromFile<Thief[]>(filePath);

			foreach (Thief thief in this._thiefs)
			{
				this.comboBoxThiefType.Items.Add(thief);
			}
			this.comboBoxThiefType.SelectedIndex = 0;

		}

		private void UpdateThiefDescription()
		{
			Thief thief = this.comboBoxThiefType.SelectedItem as Thief;
			if (thief == null)
			{
				this.labelDescription.Text = string.Empty;
				return;
			}
			this.labelDescription.Text = thief.Description;
		}

		private void UpdateItemDisplay()
		{
			List<ItemBase> items = new List<ItemBase>(this._items.Length);
			Thief thief = this.comboBoxThiefType.SelectedItem as Thief;

			foreach (ItemBase item in this._items)
			{
				Type itemType = item.GetType();

				if (thief.StoleItem)
				{
					if (itemType.IsSubclassOf(typeof(Vehicle)))
						items.Add(item);
				}
				else
					if (thief.BankHoldUp)
					{
					if (item is Bank)
						items.Add(item);
				}
					else
					{
						items.Add(item);
					}
			}
			this.userControlItems1.Items = items.ToArray<ItemBase>();
		}
		#endregion

		#region Event Handlers
		private void comboBoxThiefType_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateThiefDescription();
			UpdateItemDisplay();
		}

		private void buttonThief_Click(object sender, EventArgs e)
		{
			Thief thief = this.comboBoxThiefType.SelectedItem as Thief;
			if (thief == null)
				return;

			ItemBase item = this.userControlItems1.SelectedItem;
			if (item == null)
				return;

			double percentRisk = thief.PercentRisk - (double)this._player.Experiences.Thief;
			if (percentRisk < 2.0)
				percentRisk = 2.0;

			int random = this._game.GetRandomNumber(0, 100);
			if (random <= Math.Round(percentRisk))
			{
				this._player.ComputeThiefCatchedValues(out this._jailDelay, out this._fine);

				LPMessageBox.ShowExclamation(string.Format(
					"Tu t'es fait attraper ! Va en prison pour '{0}' tours.\r\n\r\nTu dois également payer {1:C2}.",
					this._jailDelay, this._fine));

				this._player.Capital -= this._fine;
				this._player.JailDays = this._jailDelay;
			}
			else
			{
				double stolenMoney = GetStolenMoney(item, thief);
				bool playerProcessed = false;

				// Go through all players to see if they have to be stolen or not
				foreach (Player player in this._game.Players)
				{
					if (player.Name == this._player.Name)
						continue;

					if (player.IsOwning(item))
					{
						if (thief.StoleItem)
						{
							player.Items.Remove(item);
							this._player.Items.Add(item);
							playerProcessed = true;
							LPMessageBox.ShowMessage(string.Format("Tu as dérobé '{0}' à {1} !", item.Name, player.Name));
							break;
						}
						else
						{
							LPMessageBox.ShowMessage(string.Format("Tu as dérobé {0:C2} à {1} !", stolenMoney, player.Name));
							player.Capital -= stolenMoney;
							this._player.Capital += stolenMoney;
							playerProcessed = true;
							break;
						}
					}
				}

				if (playerProcessed == false)
				{
					if (thief.StoleItem)
					{
						this._player.Items.Add(item);
						LPMessageBox.ShowMessage(string.Format("Tu as volé '{0}' !", item.Name));
					}
					else
					{
						LPMessageBox.ShowMessage(string.Format("Tu as dérobé {0:C2} !", stolenMoney));
						this._player.Capital += stolenMoney;
					}
				}

			}

			this._player.Experiences.Thief++;
			this.DialogResult = DialogResult.OK;
		}

		private double GetStolenMoney(ItemBase item, Thief thief)
		{
			int maxRatio = Convert.ToInt32(10.0 * thief.PercentRisk);

			int ratio = this._game.GetRandomNumber(1, maxRatio);
			double money = item.InitialCost * ratio / 5000;

			return money;
		}
		
		#endregion
	}
}
