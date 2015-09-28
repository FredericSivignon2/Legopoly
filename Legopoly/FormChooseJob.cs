using Legopoly.Data;
using Legopoly.Data.Jobs;
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
    public partial class FormChooseJob : Form
    {
		private Game game;
		private Player player;
		private ListViewJobColumnSorter columnSorter;
		private JobBase selectedJob;

        public FormChooseJob(Game game, Player player)
        {
			this.game = game;
			this.player = player;

			InitializeComponent();
			InitializeContent();
        }

		public JobBase SelectedJob
		{
			get
			{
				return this.selectedJob;
			}
		}

		private void InitializeContent()
		{
			this.Text = string.Format("Sélection d'un métier pour {0}", this.player.Name);

			this.listViewJobs.Columns.Add("Nom", 220);
			this.listViewJobs.Columns.Add("Grade", 180);
			this.listViewJobs.Columns.Add("Salaire/Tour", 100);

			foreach (JobBase job in this.game.AllJobs)
			{
				JobBase jobGrade = job;
				do
				{
					if (jobGrade.CanChoose(this.player) == false)
						continue;

					ListViewItem item = new ListViewItem(jobGrade.Name);
					item.Tag = jobGrade;

					item.SubItems.Add(jobGrade.GradeName);
					item.SubItems.Add(jobGrade.SalaryPerRound.ToString());

					this.listViewJobs.Items.Add(item);
				}
				while ((jobGrade = jobGrade.NextGrade()) != null);
			}

			if (this.listViewJobs.Items.Count > 0)
				this.listViewJobs.SelectedIndices.Add(0);

			this.columnSorter = new ListViewJobColumnSorter();
			this.listViewJobs.ListViewItemSorter = this.columnSorter;
		}

		private void listViewJobs_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListView.SelectedListViewItemCollection selectedItems = this.listViewJobs.SelectedItems;
			if (selectedItems.Count == 0)
				return;

			ListViewItem selectedItem = selectedItems[0];
			this.selectedJob = selectedItem.Tag as JobBase;
			if (this.selectedJob != null)
				this.pictureBoxJob.Image = this.selectedJob.Image;		
        }

		private void listViewJobs_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			// Déterminer si la colonne sélectionnée est déjà la colonne triée.
			if (e.Column == this.columnSorter.ColumnToSort)
			{
				// Inverser le sens de tri en cours pour cette colonne.
				if (this.columnSorter.Order == SortOrder.Ascending)
				{
					this.columnSorter.Order = SortOrder.Descending;
				}
				else
				{
					this.columnSorter.Order = SortOrder.Ascending;
				}
			}
			else
			{
				// Définir le numéro de colonne à trier ; par défaut sur croissant.
				this.columnSorter.ColumnToSort = e.Column;
				this.columnSorter.Order = SortOrder.Ascending;
			}

			// Procéder au tri avec les nouvelles options.
			this.listViewJobs.Sort();
		}
	}
}
