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

				UpdateCapitalDisplay();
				this.userControlItems1.Items = this.player.Items.ToArray<ItemBase>();
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

		private void UpdatePlayerState()
		{
			this.progressBarTiredness.Minimum = 0;
			this.progressBarTiredness.Maximum = this.game.JobData.MaxWorkingRound;
			this.progressBarTiredness.Value = this.player.WorkingRoundLeft;
		}

        private void UpdateCapitalDisplay()
        {
            this.labelCapital.Text = string.Format("{0:C2}", this.player.Capital);
        }

        private void UpdateExperiencePoints()
        {
            this.textBoxCreativity.Text = string.Format("{0,10:N0}", this.player.Experiences.Creativity);
            this.textBoxEmpathy.Text = string.Format("{0,10:N0}", this.player.Experiences.Empathy);
            this.textBoxFitness.Text = string.Format("{0,10:N0}", this.player.Experiences.PhysicalFitness);
            this.textBoxManagement.Text = string.Format("{0,10:N0}", this.player.Experiences.ManagerialSkills);
            this.textBoxScientific.Text = string.Format("{0,10:N0}", this.player.Experiences.Scientific);
        }

        private void UpdateJobInfo()
        {
			this.labelName.Text = string.Format("{0}, {1}", this.player.Name,
				this.player.Job == null ? "Inactif" : this.player.Job.Name);
			this.labelGrade.Text = this.player.Job == null ? string.Empty : this.player.Job.GradeName;
			this.pictureBoxJob.Image = this.player.Job == null ? null : this.player.Job.Image;
			this.textBoxSalary.Text = string.Format("{0:C2}", this.player.Job.SalaryPerRound * this.game.JobData.SalaryFactor);
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
					UpdateCapitalDisplay();
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

			int missionIndex = this.game.GetRandomNumber(0, this.player.Job.Missions.Length - 1);
			using (FormMission dlg = new FormMission(this.player.Job.Missions[missionIndex], this.player, this.game))
			{
				if (dlg.ShowDialog(this) == DialogResult.OK)
				{
					// If a mission has been performed, a move is not allowed
					this.missionPerformed = true;
					this.player.Capital += dlg.Gain;
					UpdateCapitalDisplay();
				}
			}

			UpdateButtonsEnable();
        }

		private void UpdateButtonsEnable()
		{
			if (this.missionPerformed || this.movedPerformed || this.schoolPerformed || this.gamePerformed)
			{
				this.buttonMove.Enabled = false;
				this.buttonMission.Enabled = false;
				this.buttonSchool.Enabled = false;
				this.buttonGame.Enabled = false;
                return;
			}

			this.buttonMission.Enabled = this.radioButtonWorking.Checked;
			this.buttonSchool.Enabled = !this.radioButtonWorking.Checked;
			this.buttonGame.Enabled = !this.radioButtonWorking.Checked;
			this.buttonSleep.Enabled = !this.radioButtonWorking.Checked;
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
					UpdateCapitalDisplay();
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

					UpdateCapitalDisplay();
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

			UpdateCapitalDisplay();
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

			UpdateCapitalDisplay();
			// Update target player capital and items list
			targetPlayer.Items.Add(item);
			targetPlayer.Capital -= item.CurrentCost;
		}
	}
}
