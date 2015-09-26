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

        private void InitializeFormContent()
        {
            if (this.player.Job == null)
            {
				using (FormChooseJob dlg = new FormChooseJob(this.game))
				{
					if (dlg.ShowDialog(this) != DialogResult.OK)
					{
						this.DialogResult = DialogResult.Cancel;
						return;
					}

					this.player.Job = dlg.SelectedJob;
				}
            }

            UpdateName();
            UpdateCapitalDisplay();
            InitializeHeritageList();
            UpdateExperiencePoints();
            UpdateGradeName();

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

        private void UpdateName()
        {
            this.labelName.Text = string.Format("{0}, {1}", this.player.Name, 
                this.player.Job == null ? "Inactif" : this.player.Job.Name);
        }

        private void UpdateGradeName()
        {
            this.labelGrade.Text = this.player.Job == null ? string.Empty : this.player.Job.GradeName;
        }
    }
}
