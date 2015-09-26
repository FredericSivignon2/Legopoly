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

        public FormChooseJob(Game game)
        {
			this.game = game;

            InitializeComponent();
			InitializeContent();
        }

		public JobBase SelectedJob
		{
			get
			{
				return null;
			}
		}

		private void InitializeContent()
		{
			this.listViewJobs.Columns.Add("Nom", 220);
			this.listViewJobs.Columns.Add("Grade", 180);
			this.listViewJobs.Columns.Add("Salaire/Tour", 100);

			foreach (JobBase job in this.game.AllJobs)
			{
				do
				{
					ListViewItem item = new ListViewItem(job.Name);
					item.Tag = job;

					item.SubItems.Add(job.GradeName);
					item.SubItems.Add(job.SalaryPerRound.ToString());

					this.listViewJobs.Items.Add(item);
				}
				while (job.NextGrade());
			}
		}
    }
}
