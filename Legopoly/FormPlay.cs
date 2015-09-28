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
        private Player player;
        private Game game;

        public FormPlay(Player player, Game game)
        {
            this.player = player;
            this.game = game;

            InitializeComponent();
            InitializeFormContent();
        }

		private void ChooseJob()
		{
			using (FormChooseJob dlg = new FormChooseJob(this.game, this.player))
			{
				if (dlg.ShowDialog(this) != DialogResult.OK)
				{
					this.DialogResult = DialogResult.Cancel;
					return;
				}

				this.player.Job = dlg.SelectedJob;
			}
		}

        private void InitializeFormContent()
        {
            if (this.player.Job == null)
            {
				ChooseJob();
            }

            UpdateCapitalDisplay();
            InitializeHeritageList();
            UpdateExperiencePoints();
            UpdateJobInfo();

			this.radioButtonOffWork.Checked = this.player.Working == false;
			this.radioButtonWorking.Checked = this.player.Working;
            this.Text = string.Format("Tour n°{0}", this.game.Round);
        }

        private void InitializeHeritageList()
        {
            this.listViewHeritage.Columns.Add("Nom", 220);
            this.listViewHeritage.Columns.Add("Type", 150);
            this.listViewHeritage.Columns.Add("Prix par tour", 100);
        }

        private void buttonBuyItem_Click(object sender, EventArgs e)
        {
            using (FormChooseItem dlg = new FormChooseItem(this.player))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    ItemBase itemBase = dlg.SelectedItem;
                    AddListViewItem(itemBase);

                    player.Capital -= itemBase.InitialCost;
                    UpdateCapitalDisplay();
                }
            }
        }

        private void AddListViewItem(ItemBase itemBase)
        {
            ListViewItem item = new ListViewItem(itemBase.Name);

            item.SubItems.Add(itemBase.GetDisplayType());
            item.SubItems.Add(itemBase.CostPerRound.ToString());
            this.listViewHeritage.Items.Add(item);

            this.player.Items.Add(itemBase);
        }

        private void UpdateCapitalDisplay()
        {
            this.labelCapital.Text = string.Format("{0,20:N0}€", this.player.Capital);
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
			this.textBoxSalary.Text = string.Format("{0,10:N0}€", this.player.Job.SalaryPerRound);
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
			if (this.player.Working && this.player.Job != null)
			{
				this.player.Capital += this.player.Job.SalaryPerRound;
				this.player.Experiences.Creativity += this.game.GetRandomNumber(0, this.player.Job.MaxExperiencesGainPerRound.Creativity);
				this.player.Experiences.Empathy += this.game.GetRandomNumber(0, this.player.Job.MaxExperiencesGainPerRound.Empathy);
				this.player.Experiences.ManagerialSkills += this.game.GetRandomNumber(0, this.player.Job.MaxExperiencesGainPerRound.ManagerialSkills);
				this.player.Experiences.PhysicalFitness += this.game.GetRandomNumber(0, this.player.Job.MaxExperiencesGainPerRound.PhysicalFitness);
				this.player.Experiences.Scientific += this.game.GetRandomNumber(0, this.player.Job.MaxExperiencesGainPerRound.Scientific);
			}

			foreach (ItemBase item in this.player.Items)
			{
				this.player.Capital -= item.CostPerRound;
				
			}
		}

		private void radioButtonWorking_CheckedChanged(object sender, EventArgs e)
		{
			this.player.Working = true;
		}

		private void radioButtonOffWork_CheckedChanged(object sender, EventArgs e)
		{
			this.player.Working = false;
		}
	}
}
