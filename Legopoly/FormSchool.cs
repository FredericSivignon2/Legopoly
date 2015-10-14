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
		#endregion

		public FormSchool(Player player)
		{
			this.player = player;

			InitializeComponent();
			InitializeContent();

			List<Course> courses = new List<Course>();
			Course course = new Course()
			{
				Name = "Cours de sport.",
				Cost = 45.0,
				Experiences = new LPExperiences()
				{
					Creativity = 0,
					Empathy = 0,
					ManagerialSkills = 0,
					PhysicalFitness = 1,
					Scientific = 0
				}
			};
			courses.Add(course);
           
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
				this.comboBox1.Items.Add(course);
			}

			this.comboBox1.SelectedIndex = 0;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			switch (this.comboBox1.SelectedIndex)
			{
				case 0:
					//this.player.Experiences.
					break;
				case 1:
					break;
				case 2:
					break;
				case 3:
					break;
				case 4:
					break;
				default:
					break;
			}
		}
	}
}
