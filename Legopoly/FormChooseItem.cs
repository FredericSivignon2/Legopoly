using Legopoly.Data;
using Legopoly.Data.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legopoly
{
	public partial class FormChooseItem : Form
	{
		#region Data Members
		private Player player;
		#endregion

		public FormChooseItem(Player player)
		{
			this.player = player;

			InitializeComponent();
			InitializeFormContent();
		}

		public ItemBase SelectedItem
		{
			get
			{
				return this.userControlItems1.SelectedItem;
			}
		}

		private void InitializeFormContent()
		{
			List<ItemBase> allItems = Parameters.ParametersMain.Instance.Shop.Items;

			foreach (ItemBase item in allItems)
			{
				if (item.InitialCost <= this.player.Capital)
				{
					// Make a clone, so we won't modify shop property
					ItemBase newItem = item.Clone();
					newItem.CurrentCost = newItem.InitialCost;
					this.userControlItems1.AddItem(newItem);
				}
			}

			this.userControlItems1.Refresh();
		}
	}
}
