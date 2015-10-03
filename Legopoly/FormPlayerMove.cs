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
	public partial class FormPlayerMove : Form
	{
		private Player player;
		private Game game;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="player"></param>
		/// <param name="game"></param>
		/// <param name="jobVehicle">true if the Player is using a Job vehicle (fireman truck etc...)</param>
		public FormPlayerMove(Player player, Game game)
		{
			this.player = player;
			this.game = game;

			InitializeComponent();
			InitializeContent();
		}

		private void InitializeContent()
		{
			this.radioButtonFoot.Checked = true;
			foreach (ItemBase item in this.player.Items)
			{
				if (item is Vehicle)
				{
					this.comboBoxVehicles.Items.Add(item);
				}
			}
			if (this.comboBoxVehicles.Items.Count == 0)
			{
				this.radioButtonVehicle.Enabled = false;
			}
		}

		private void radioButtonFoot_CheckedChanged(object sender, EventArgs e)
		{
			UpdateControlEnabled();
		}

		private void radioButtonVehicle_CheckedChanged(object sender, EventArgs e)
		{
			UpdateControlEnabled();
		}

		private void UpdateControlEnabled()
		{
			this.comboBoxVehicles.Enabled = this.radioButtonVehicle.Checked;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			ShowMove();
		}

		private void ShowMove()
		{
			int number = 1;

			if (this.radioButtonVehicle.Checked)
			{
				Vehicle vehicle = this.comboBoxVehicles.SelectedItem as Vehicle;
				if (vehicle == null)
				{
					this.DialogResult = DialogResult.None;
					return;
				}

				number = this.game.GetRandomNumber(vehicle.MinMovePerRound, vehicle.MaxMovePerRound);

				player.Capital -= number * vehicle.CostPerMove;
			}

			using (FormMoving dlg = new FormMoving(number))
			{
				dlg.ShowDialog(this);
			}

		}
	}
}
