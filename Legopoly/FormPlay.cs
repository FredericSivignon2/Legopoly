﻿using Legopoly.Data;
using Legopoly.Data.Items;
using Legopoly.Data.Missions;
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
	/// <summary>
	/// 
	/// </summary>
    public partial class FormPlay : Form
    {
		#region Data Members
		private Player player;
        private Game game;
		private bool initializing = false;
		private bool missionPerformed = false;
		private bool movedPerformed = false;
		private bool schoolPerformed = false;
		private bool gamePerformed = false;
		private bool thiefPerformed = false;
		private bool bankPerformed = false;
		#endregion

		#region Constructors
		public FormPlay(Player player, Game game)
        {
            this.player = player;
            this.game = game;

            InitializeComponent();
            InitializeFormContent();
        }
		#endregion

		private void ChooseJob()
		{
			using (FormChooseJob dlg = new FormChooseJob(this.game, this.player))
			{
				if (dlg.ShowDialog(this) != DialogResult.OK)
				{
					return;
				}

				this.player.Job = dlg.SelectedJob;
			}
		}

        private void InitializeFormContent()
        {
			this.initializing = true;
			try
			{
				if (this.player.Job == null)
				{
					ChooseJob();
				}

				UpdatePlayerItemList();
				UpdateExperiencePoints();
				UpdateJobInfo();
				UpdatePlayerState();

				if (this.player.WorkingRoundLeft == 0 && this.player.Working)
				{
					LPMessageBox.ShowMessage("Tu as passé trop de temps au travail.\r\n\r\nRetournes à ton domicile avant toute autre activité.");
					this.player.Working = false;
				}
				this.radioButtonOffWork.Checked = this.player.Working == false;
				this.radioButtonWorking.Checked = this.player.Working;
				this.Text = string.Format("Tour n°{0}", this.game.Round);
				
				UpdateButtonsEnable();
			}
			finally
			{
				this.initializing = false;
			}
        }

		/// <summary>
		/// If a user has performed holdup, it can be catched by the police at anytime. More chances to be catched
		///  if he has performed a lot of holdups.
		/// </summary>
		private void CheckThief()
		{
			if (this.player.Experiences.Thief == 0)
				return;

			int catched = this.game.GetRandomNumber(0, 1000);
			if (catched <= this.player.Experiences.Thief)
			{
				int jailDays = 0;
				double fine = 0.0;
				this.player.ComputeThiefCatchedValues(out jailDays, out fine);

				LPMessageBox.ShowWarning(string.Format(
					"Tu viens d'être identifié(e) par la Police et arrêté(e) pour tes précédents vols.\r\n\r\n" +
					"Va en prison pour {0} tour(s) et payes {1:C2} d'amende.", jailDays, fine));

				try
				{
					this.player.Capital -= fine;
				}
				catch (NoMoneyException)
				{
					this.player.Capital = 0.0;
				}
				this.player.JailDays = jailDays;

				UpdatePlayerState();
				UpdateButtonsEnable();
				UpdatePlayerItemList();
			}
		}

		private void UpdatePlayerItemList()
		{
			this.userControlItems1.Items = this.player.Items.ToArray<ItemBase>();
		}

		private void UpdatePlayerState()
		{
			this.progressBarTiredness.Minimum = 0;
			this.progressBarTiredness.Maximum = this.game.JobData.MaxWorkingRound;
			this.progressBarTiredness.Value = this.player.WorkingRoundLeft;

			this.labelCapital.Text = string.Format("{0:C2}", this.player.Capital);
			this.labelCapitalBanks.Text = string.Format("{0:C2}", this.player.CapitalInBanks);
			this.labelCapitalTotalVal.Text = string.Format("{0:C2}", this.player.Capital + this.player.CapitalInBanks);
			this.labelCurrentLoanCount.Text = string.Format("{0}", this.player.CurrentLoanCount);
        }
		
        private void UpdateExperiencePoints()
        {
            this.textBoxCreativity.Text = string.Format("{0,10:N0}", this.player.Experiences.Creativity);
            this.textBoxEmpathy.Text = string.Format("{0,10:N0}", this.player.Experiences.Empathy);
            this.textBoxFitness.Text = string.Format("{0,10:N0}", this.player.Experiences.PhysicalFitness);
            this.textBoxManagement.Text = string.Format("{0,10:N0}", this.player.Experiences.ManagerialSkills);
            this.textBoxScientific.Text = string.Format("{0,10:N0}", this.player.Experiences.Scientific);
			this.textBoxThief.Text = string.Format("{0,10:N0}", this.player.Experiences.Thief);
        }

        private void UpdateJobInfo()
        {
			if (this.player.JailDays > 0)
			{
				this.labelName.Text = string.Format("{0}, EN PRISON !", this.player.Name);
				this.labelGrade.Text = string.Empty;
				this.pictureBoxJob.Image = global::Legopoly.Properties.Resources.robber_128;
				this.textBoxSalary.Text = "0.00 €";
            }
			else
			{
				this.labelName.Text = string.Format("{0}, {1}", this.player.Name,
					this.player.Job == null ? "Inactif" : this.player.Job.Name);
				this.labelGrade.Text = this.player.Job == null ? string.Empty : this.player.Job.GradeName;
				this.pictureBoxJob.Image = this.player.Job == null ? null : this.player.Job.Image;
				this.textBoxSalary.Text = this.player.Job == null ? string.Empty : string.Format("{0:C2}", this.player.Job.SalaryPerRound * this.game.JobData.SalaryFactor);
			}
		}

		private void buttonChangeJob_Click(object sender, EventArgs e)
		{
			ChooseJob();
			UpdateJobInfo();
        }

		private void buttonNextPlayer_Click(object sender, EventArgs e)
		{
			ProcessEndOfRound();
		}

		private void ProcessEndOfRound()
		{
			this.player.ProcessEndOfRound();
		}

		private void radioButtonWorking_CheckedChanged(object sender, EventArgs e)
		{
			if (this.initializing == false)
			{
				this.player.Working = true;
			}
			this.pictureBoxJob.Enabled = true;
			UpdateButtonsEnable();
        }

		private void radioButtonOffWork_CheckedChanged(object sender, EventArgs e)
		{
			if (this.initializing == false)
			{
				this.player.Working = false;
			}
			this.pictureBoxJob.Enabled = false;
			UpdateButtonsEnable();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			using (FormPlayerMove dlg = new FormPlayerMove(this.player, this.game))
			{
				if (dlg.ShowDialog(this) == DialogResult.OK)
				{
					UpdatePlayerState();
					this.movedPerformed = true;
					UpdateButtonsEnable();
				}
			}
		}

		private void buttonMission_Click(object sender, EventArgs e)
		{
			if (this.player.Job == null ||
				this.player.Job.Missions.Length == 0)
				return;

			int missionToDo = this.game.GetRandomNumber(0, 2);
			if (missionToDo == 0)
			{
				LPMessageBox.ShowMessage("Pas de mission disponible pour ce tour !");
				this.buttonMission.Enabled = false;
				return;
			}

			// Gets missions allowed for current user level (level defined at Grade level)
			Mission[] allowedMissions = this.player.Job.Missions;

			int missionIndex = this.game.GetRandomNumber(0, allowedMissions.Length - 1);
			using (FormMission dlg = new FormMission(allowedMissions[missionIndex], this.player, this.game))
			{
				if (dlg.ShowDialog(this) == DialogResult.OK)
				{
					// If a mission has been performed, a move is not allowed
					this.missionPerformed = true;
					this.player.Capital += dlg.Gain;
					UpdatePlayerState();
				}
			}

			UpdateButtonsEnable();
        }

		private void UpdateButtonsEnable()
		{
			if (this.player.JailDays > 0)
			{
				this.groupBoxHeritage.Enabled = false;
				this.groupBoxIdentification.Enabled = false;
				this.radioButtonOffWork.Enabled = false;
				this.groupBoxState.Enabled = false;
				this.buttonSleep.Enabled = false;
				this.buttonMove.Enabled = false;
				this.buttonMission.Enabled = false;
				this.buttonSchool.Enabled = false;
				this.buttonGame.Enabled = false;
				this.buttonThief.Enabled = false;
				this.buttonBank.Enabled = false;
				return;
			}

			if (this.missionPerformed || this.movedPerformed || this.schoolPerformed || this.gamePerformed || this.thiefPerformed || this.bankPerformed)
			{
				this.buttonMove.Enabled = false;
				this.buttonMission.Enabled = false;
				this.buttonSchool.Enabled = false;
				this.buttonGame.Enabled = false;
				this.buttonThief.Enabled = false;
				this.buttonBank.Enabled = false;
                return;
			}

			this.buttonMission.Enabled = this.radioButtonWorking.Checked;
			this.buttonSchool.Enabled = !this.radioButtonWorking.Checked;
			this.buttonGame.Enabled = !this.radioButtonWorking.Checked;
			this.buttonSleep.Enabled = !this.radioButtonWorking.Checked;
			this.buttonThief.Enabled = !this.radioButtonWorking.Checked;
			this.buttonBank.Enabled = !this.radioButtonWorking.Checked;
		}

		private void buttonStopGame_Click(object sender, EventArgs e)
		{
			DialogResult result = LPMessageBox.ShowQuestion("Veux-tu vraiment quitter le jeu ?");
			if (result != DialogResult.Yes)
				this.DialogResult = DialogResult.None;
		}

		private void buttonSchool_Click(object sender, EventArgs e)
		{
			try
			{
				using (FormSchool dlg = new FormSchool(this.player))
				{
					if (dlg.ShowDialog(this) == DialogResult.OK)
					{
						this.schoolPerformed = true;
					}
				}
			}
			catch (NoMoneyException exp)
			{
				LPMessageBox.ShowError(exp.Message);
			}
			UpdateButtonsEnable();
			UpdateExperiencePoints();
		}

		private void buttonGame_Click(object sender, EventArgs e)
		{
			using (FormGame dlg = new FormGame(this.game, this.player))
			{
				if (dlg.ShowDialog(this) == DialogResult.OK)
				{
					this.gamePerformed = true;
					UpdatePlayerState();
				}
			}
			UpdateButtonsEnable();
		}

		private void buttonSleep_Click(object sender, EventArgs e)
		{
			if (LPMessageBox.ShowQuestion("Tu dois être rentré chez toi pour dormir.\r\n\r\nOk ?") == DialogResult.Yes)
			{
				this.player.Sleep(this.game);
				UpdatePlayerState();
			}
		}

		private void buttonBuyItem_Click(object sender, EventArgs e)
		{
			using (FormChooseItem dlg = new FormChooseItem(this.player))
			{
				if (dlg.ShowDialog(this) == DialogResult.OK)
				{
					ItemBase itemBase = dlg.SelectedItem;
					if (itemBase is MotorVehicle)
					{
						MotorVehicle motorVehicle = itemBase as MotorVehicle;
						// Make a full tank just after buying the vehicle!
						motorVehicle.FuelLevel = motorVehicle.TankCapacity;
					}
					this.userControlItems1.AddItem(itemBase);
					this.userControlItems1.Refresh();

					player.Capital -= itemBase.InitialCost;
					this.player.Items.Add(itemBase);

					UpdatePlayerState();
				}
			}
		}

		private void buttonSoldItem_Click(object sender, EventArgs e)
		{
			ItemBase item = this.userControlItems1.SelectedItem;
			if (item == null)
				return;

			if (LPMessageBox.ShowQuestion(string.Format("Es-tu sur de vouloir vendre '{0}' ?", item.Name)) != DialogResult.Yes)
				return;

					
			this.userControlItems1.RemoveItem(item);
			this.userControlItems1.Refresh();

			player.Capital += item.CurrentCost;
			this.player.Items.Remove(item);

			UpdatePlayerState();
		}

		private void buttonSaleTo_Click(object sender, EventArgs e)
		{
			ItemBase item = this.userControlItems1.SelectedItem;
			if (item == null)
				return;

			Player targetPlayer = null;
			using (FormChoosePlayer dlg = new FormChoosePlayer(this.game, this.player))
			{
				if (dlg.ShowDialog(this) != DialogResult.OK)
					return;

				targetPlayer = dlg.SelectedPlayer;
            }

			if (targetPlayer == null)
				return;

			if (LPMessageBox.ShowQuestion(string.Format("Es-tu sur de vouloir vendre '{0}' à {1} ?", item.Name, targetPlayer.Name)) != DialogResult.Yes)
				return;

			if (targetPlayer.Capital < item.CurrentCost)
			{
				LPMessageBox.ShowWarning(string.Format("{0} n'a pas assez d'argent pour vous acheter '{1}' !", targetPlayer.Name, item.Name));
				return;
			}

			this.userControlItems1.RemoveItem(item);
			this.userControlItems1.Refresh();

			player.Capital += item.CurrentCost;
			this.player.Items.Remove(item);

			UpdatePlayerState();
			// Update target player capital and items list
			targetPlayer.Items.Add(item);
			targetPlayer.Capital -= item.CurrentCost;
		}

		private void buttonThief_Click(object sender, EventArgs e)
		{
			using (FormThief form = new FormThief(this.game, this.player))
			{
				if (form.ShowDialog(this) == DialogResult.OK)
				{
					this.thiefPerformed = true;
                    UpdateExperiencePoints();
					UpdatePlayerState();
					UpdateButtonsEnable();
					UpdatePlayerItemList();
                }
			}
		}

		private void FormPlay_Shown(object sender, EventArgs e)
		{
			if (this.player.JailDays > 0)
			{
				if (this.player.JailDays == 1)
					LPMessageBox.ShowExclamation("Tu es en prison, passes ton tour.\r\n\r\nIl te reste 1 tour à passer en prison.");
				else
					LPMessageBox.ShowExclamation(string.Format(
						"Tu es en prison, passes ton tour.\r\n\r\nIl te reste {0} tours à passer en prison.", this.player.JailDays));
			}

			CheckThief();
        }

		private void buttonBank_Click(object sender, EventArgs e)
		{
			using (FormBank dlg = new FormBank(this.game, this.player))
			{
				if (dlg.ShowDialog(this) == DialogResult.OK)
				{
					this.bankPerformed = true;
					UpdatePlayerState();
					UpdateButtonsEnable();
				}
			}
		}
	}
}
