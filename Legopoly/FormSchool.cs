using FoundationLibraries.Xml;
using Legopoly.Data;
using Legopoly.Data.Schools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legopoly
{
	public partial class FormSchool : Form
	{
		/*
		Cours de sport (45€) + 1 point d'expérience  (condition physique)
Cours de sciences (60€) +1 point d'expérience  (sciences)
Cours de management (55€) + 1 point d'expérience (management)
Cours de yoga (45€) + 1 point d'expérience (empathie)
Cours d'arts (50€) + 1 point d'expérience (créativité)
*/
		#region Data Members
		private const string dataFileName = "school_data.xml";

		List<Course> courses = null;
        private Player player;
		private Course selectedCourse;
		#endregion

		public FormSchool(Player player)
		{
			this.player = player;

			InitializeComponent();
			InitializeContent();
		}

		private void InitializeContent()
		{
			string dataFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dataFileName);
			if (File.Exists(dataFilePath) == false)
				throw new FileNotFoundException(string.Format("Le fichier de données de l'école est introuvable.\r\n{0}", dataFilePath));

			try
			{
				this.courses = XmlSerializationHelper.HelperUTF8.FromFile<List<Course>>(dataFilePath);
			}
			catch (Exception exp)
			{
				throw new Exception("Impossible de lire le fichier de données de l'école.", exp);
			}

			foreach (Course course in this.courses)
			{
				this.comboBoxCourses.Items.Add(course);
			}

			this.comboBoxCourses.SelectedIndex = 0;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			this.player.Capital -= this.selectedCourse.Cost;
			this.player.Experiences.Creativity += this.selectedCourse.Experiences.Creativity;
			this.player.Experiences.Empathy += this.selectedCourse.Experiences.Empathy;
			this.player.Experiences.ManagerialSkills += this.selectedCourse.Experiences.ManagerialSkills;
			this.player.Experiences.PhysicalFitness += this.selectedCourse.Experiences.PhysicalFitness;
			this.player.Experiences.Scientific += this.selectedCourse.Experiences.Scientific;
		}

		private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.selectedCourse = this.comboBoxCourses.SelectedItem as Course;
			if (this.selectedCourse == null)
				return;

			this.textBoxPrice.Text = string.Format("{0,4:N0}", this.selectedCourse.Cost);
			this.textBoxCreativity.Text = this.selectedCourse.Experiences.Creativity.ToString();
			this.textBoxEmpathy.Text = this.selectedCourse.Experiences.Empathy.ToString();
			this.textBoxFitness.Text = this.selectedCourse.Experiences.PhysicalFitness.ToString();
			this.textBoxManagement.Text = this.selectedCourse.Experiences.ManagerialSkills.ToString();
			this.textBoxScientific.Text = this.selectedCourse.Experiences.Scientific.ToString();


		}
	}
}
