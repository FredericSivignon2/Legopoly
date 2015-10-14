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
			this.radioButtonFoot.Checked = this.player.StateData.LastMoveUseVehicle == false;
			this.radioButtonVehicle.Checked = this.player.StateData.LastMoveUseVehicle;

			int indexToSelect = 0;
			if (this.player.Items.Count > 0)
			{
				foreach (ItemBase item in this.player.Items)
				{
					if (item is Vehicle)
					{
						int index = this.comboBoxVehicles.Items.Add(item);
						if (item.Name == this.player.StateData.LastMoveVehicleName)
							indexToSelect = index;
					}
				}
				this.comboBoxVehicles.SelectedIndex = indexToSelect;
			}
			if (this.comboBoxVehicles.Items.Count == 0)
			{
				this.radioButtonVehicle.Enabled = false;
			}

			UpdateTankLevel();
			UpdateRefuelValueDisplay();
			UpdateControlEnabled();
		}

		private void UpdateTankLevel()
		{
			MotorVehicle motorVehicle = GetSelectedMotorVehicle();
            if (motorVehicle == null)
			{
				this.labelTankLevelComment.Text = "Ce véhicule ne fonctionne pas à l'essence.";
            }
			else
			{
				this.labelTankLevelComment.Text = string.Format("Vous pouvez encore parcourir {0,4:N0} case(s) avec l'essence restante.",
                    motorVehicle.FuelLevel / motorVehicle.ConsumptionPerMove);
            }
			this.panelTankLevel.Invalidate();
        }

		private void UpdateRefuelValueDisplay()
		{
			MotorVehicle motorVehicle = GetSelectedMotorVehicle();
			if (motorVehicle == null)
			{
				this.labelRefuel.Text = string.Empty;
            }
			else
			{ 
				this.labelRefuel.Text = string.Format("Faire le plein d'essence vous coûtera {0,5:F}€", motorVehicle.GetRefuelValue());
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
			this.buttonRefuel.Enabled = this.radioButtonVehicle.Checked;
			this.labelRefuel.Enabled = this.radioButtonVehicle.Checked;

			if (this.radioButtonVehicle.Checked)
			{
				MotorVehicle motorVehicle = GetSelectedMotorVehicle();
				this.labelTank.Enabled = motorVehicle != null;
				this.panelTankLevel.Enabled = motorVehicle != null;
				this.labelTankLevelComment.Enabled = motorVehicle != null;
			}
			else
			{
				this.labelTank.Enabled = false;
				this.panelTankLevel.Enabled = false;
				this.labelTankLevelComment.Enabled = false;
            }
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			try
			{
				ShowMove();
			}
			catch (Exception exp)
			{
				LPMessageBox.ShowError("Impossible de se déplacer.", exp);
			}
		}

		private MotorVehicle GetSelectedMotorVehicle()
		{
			return this.comboBoxVehicles.SelectedItem as MotorVehicle;
		}


		private void ShowMove()
		{
			int number = 1;

			if (this.radioButtonVehicle.Checked)
			{
				// Compute move cost
				Vehicle vehicle = this.comboBoxVehicles.SelectedItem as Vehicle;
				if (vehicle == null)
				{
					this.DialogResult = DialogResult.None;
					return;
				}
				this.player.StateData.LastMoveUseVehicle = true;
				this.player.StateData.LastMoveVehicleName = vehicle.Name;

				number = this.game.GetRandomNumber(vehicle.MinMovePerRound, vehicle.MaxMovePerRound);
				MotorVehicle motorVehicle = vehicle as MotorVehicle;
				if (motorVehicle != null && motorVehicle.NumberOfMoveLeft < 40)
                {
					LPMessageBox.ShowWarning("Attention ! Vous n'avez plus beaucoup d'essence dans votre véhicule.\r\nIl ne vous reste moins de 40 cases d'autonomie.\r\nAllez prochainement à la station service !");
				}

				for (int i = 0; i < number; i++)
				{
					// Check cost per move and update Player capital
					if (player.Capital - vehicle.CostPerMove < 0)
					{
						if (i == 0)
							LPMessageBox.ShowExclamation("Impossible de vous déplacer !\r\n Vous n'avez plus d'argent pour payer les frais de déplacement.");
						else
							LPMessageBox.ShowExclamation("Votre déplacement a été limité !\r\nVous n'avez plus assez d'argent pour vous déplacer plus.");
						number = i;
						break;
					}

					player.Capital -= vehicle.CostPerMove;

					// If the player use a Motor vehicle, checks vehicle tank and update it
					if (motorVehicle != null)
					{
						if (motorVehicle.FuelLevel == -1)
							motorVehicle.FuelLevel = motorVehicle.TankCapacity;

						if (motorVehicle.FuelLevel - motorVehicle.ConsumptionPerMove < 0)
						{
							if (i == 0)
								LPMessageBox.ShowExclamation("Impossible de vous déplacer !\r\n Vous n'avez plus d'essence dans votre véhicule.");
							else
								LPMessageBox.ShowExclamation("Votre déplacement a été limité !\r\nVous n'avez plus assez d'essence dans votre véhicule.");
							number = i;
							break;
						}

						motorVehicle.FuelLevel -= motorVehicle.ConsumptionPerMove;
					}
				}

			}
			else
				this.player.StateData.LastMoveUseVehicle = false;

			if (number > 0)
			{
				using (FormMoving dlg = new FormMoving(number))
				{
					dlg.ShowDialog(this);
				}
			}
		}
		
		private void comboBoxVehicles_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateTankLevel();
			UpdateRefuelValueDisplay();
			UpdateControlEnabled();
		}

		private void buttonRefuel_Click(object sender, EventArgs e)
		{
			if (LPMessageBox.ShowQuestion("Voulez refaire le plein du véhicule ?") != DialogResult.Yes)
				return;

			Vehicle vehicle = this.comboBoxVehicles.SelectedItem as Vehicle;
			MotorVehicle motorVehicle = vehicle as MotorVehicle;
			if (motorVehicle != null)
			{
				double cost = motorVehicle.GetRefuelValue();
				if (this.player.Capital - cost < 0)
				{
					LPMessageBox.ShowExclamation("Vous n'avez plus assez d'argent pour refaire le plein de se véhicule !");
					return;
				}

				motorVehicle.FuelLevel = motorVehicle.TankCapacity;
				this.player.Capital -= cost;

				LPMessageBox.ShowMessage("Le véhicle a maintenant le réservoir plein.");
				UpdateTankLevel();
				UpdateRefuelValueDisplay();
                UpdateControlEnabled();
			}
		}

		private void panelTankLevel_Paint(object sender, PaintEventArgs e)
		{
			if (this.panelTankLevel.Enabled == false)
			{
				using (Brush brush = new SolidBrush(Color.LightGray))
				{
					e.Graphics.FillRectangle(brush, e.ClipRectangle);
				}
				return;
			}

			MotorVehicle motorVehicle = GetSelectedMotorVehicle();
			if (motorVehicle == null)
				return;

			double currentLevel = motorVehicle.FuelLevel;
			double maxLevel = motorVehicle.TankCapacity;

			int drawLevel = (int)(currentLevel * e.ClipRectangle.Width / maxLevel);

            int red = (int)(255 - currentLevel * 255 / maxLevel);
			int green = (int)(currentLevel * 255 / maxLevel);
			int blue = 0;
			Color color = Color.FromArgb(red, green, blue);

			using (Brush brush = new SolidBrush(color))
			{
				e.Graphics.FillRectangle(brush, new Rectangle(0, 0, drawLevel, e.ClipRectangle.Height));
            }
        }
	}
}
