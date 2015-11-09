using Legopoly.Data.Missions;
using Legopoly.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using System.Xml.Linq;
using System.Runtime.Serialization;

namespace Legopoly.Data.Jobs
{
	[DebuggerDisplay("{Name}, {GradeName}")]
	[DataContract]
    public abstract class JobBase
    {
        #region Data Members
        private const string defaultValuesFilePath = "job_default.ini";
		private const string missionValuesFilePath = "missions_data.xml";

		private Grade[] grades;
		private List<Mission> missions = new List<Mission>();
		private int gradeNumber = 0;
        private string name;
		private Image image;
        #endregion

        protected JobBase()
        {
        }

		protected JobBase(JobBase job)
		{
			if (job.grades != null)
			{
				this.grades = new Grade[job.grades.Length];

				for (int i = 0; i < job.grades.Length; i++)
				{
					this.grades[i] = new Grade(job.grades[i]);
				}
				this.gradeNumber = job.gradeNumber;
				this.name = job.name;
				this.image = job.image;
			}
		}

		#region Public Properties
		public int GradeNumber
		{
			get
			{
				return this.gradeNumber;
			}
		}

        public string Name
        {
            get
            {
                return this.name;
            }

            protected set
            {
                this.name = value;
                InitializeData();
            }
        }

		public Image Image
		{
			get
			{
				return this.image;
			}
			protected set
			{
				this.image = value;
			}
		}

        public string GradeName
        {
            get
            {
                if (grades == null)
                    return string.Empty;

                return this.grades[this.gradeNumber].Name;
            }
        }

		public LPExperiences MinimalExperiences
		{
			get
			{
				if (grades == null)
					return null;

				return this.grades[this.gradeNumber].MinimalExperiences;
			}
		}

		public LPExperiences MaxExperiencesGainPerRound
		{
			get
			{
				if (grades == null)
					return null;

				return this.grades[this.gradeNumber].MaxExperiencesGainPerRound;
			}
		}

		public int SalaryPerRound
		{
			get
			{
				if (grades == null)
					return -1;

				return this.grades[this.gradeNumber].SalaryPerRound;
			}
		}

		public Mission[] Missions
		{
			get
			{
				return this.missions.ToArray<Mission>();
			}
		}
		#endregion

		/// <summary>
		/// Gets a boolean value that indicates whether the given player can choose the current Job.
		/// </summary>
		/// <param name="player">The player to test.</param>
		/// <returns>true if the Job can be choosen. Otherwise, returns false.</returns>
		public bool CanChoose(Player player)
		{
			return (player.Experiences.Creativity >= MinimalExperiences.Creativity &&
					player.Experiences.Empathy >= MinimalExperiences.Empathy &&
					player.Experiences.ManagerialSkills >= MinimalExperiences.ManagerialSkills &&
					player.Experiences.PhysicalFitness >= MinimalExperiences.PhysicalFitness &&
					player.Experiences.Scientific >= MinimalExperiences.Scientific);
		}

		public abstract JobBase Clone();

		public JobBase NextGrade()
		{
			if (this.gradeNumber < this.grades.Length - 1)
			{
				JobBase newJob = this.Clone();
				newJob.gradeNumber++;
				return newJob;
			}
			return null;
		}

        private static string DefaultValuesFilePath
        {
            get
            {
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, defaultValuesFilePath);
            }
        }

		private static string MissionValuesFilePath
		{
			get
			{
				return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, missionValuesFilePath);
			}
		}

		private void InitializeData()
		{
			LoadGrads();
            LoadMissions();
		}

		private void LoadGrads()
		{ 
            string filePath = DefaultValuesFilePath;
            if (File.Exists(filePath) == false)
                throw new FileNotFoundException(string.Format("Le fichier de données\r\n{0}'\r\nest introuvable!", filePath));

			IniFileReader iniFile = new IniFileReader(); 

			try
			{
				iniFile.Load(filePath);
			}
			catch (Exception exp)
			{
				throw new Exception(string.Format("Erreur lors du chargement du fichier de configuration\r\n{0}", filePath), exp);
			}

			if (iniFile.Sections.ContainsKey(this.name) == false)
				throw new Exception(string.Format("Il manque la section '{0}' dans le fichier de configuration\r\n{0}", this.name, filePath));

			IniSection section = iniFile.Sections[this.name];
            List<Grade> tmpGrades = new List<Grade>();

            foreach (string keyName in section.KeyValues.Keys)
            {
				string value = section.KeyValues[keyName];
                if (string.IsNullOrWhiteSpace(value))
					throw new Exception(string.Format("Valeur incorrecte dans le fichier de configuration\r\n{0}\r\npour la clef '{1}' dans la section '{2}'.", filePath, keyName, this.name));

				string[] values = value.Split(new char[] { ',' });
				if (values.Length != 11)
					throw new Exception(string.Format("Nombre de valeurs incorrect dans le fichier de configuration\r\n{0}\r\npour la clef '{1}' dans la section '{2}'.", filePath, keyName, this.name));

                Grade grade = new Grade()
                {
                    Name = keyName,
                    MinimalExperiences = new LPExperiences()
                    {
                        Scientific = Convert.ToInt32(values[0]),
                        PhysicalFitness = Convert.ToInt32(values[1]),
                        ManagerialSkills = Convert.ToInt32(values[2]),
                        Creativity = Convert.ToInt32(values[3]),
                        Empathy = Convert.ToInt32(values[4])
                    },
                    MaxExperiencesGainPerRound = new LPExperiences()
                    {
                        Scientific = Convert.ToInt32(values[5]),
                        PhysicalFitness = Convert.ToInt32(values[6]),
                        ManagerialSkills = Convert.ToInt32(values[7]),
                        Creativity = Convert.ToInt32(values[8]),
                        Empathy = Convert.ToInt32(values[9])
                    },
                    SalaryPerRound = Convert.ToInt32(values[10])

                };
                tmpGrades.Add(grade);
            }

            this.grades = tmpGrades.ToArray<Grade>();
        }

		private void LoadMissions()
		{
			string filePath = MissionValuesFilePath;
			if (File.Exists(filePath) == false)
				throw new FileNotFoundException(string.Format("Le fichier de données\r\n{0}'\r\nest introuvable!", filePath));

			XDocument document = null; 

			try
			{
				document = XDocument.Load(filePath);
			}
			catch (Exception exp)
			{
				throw new Exception(string.Format("Erreur lors du chargement du fichier de configuration\r\n{0}", filePath), exp);
			}

			XElement xroot = document.Root;
			XElement xjobRootElement = xroot.XPathSelectElement(this.Name);
			if (xjobRootElement == null)
				return; // No corresponding job entry

			XElement xmissionRoot = xjobRootElement.XPathSelectElement("Missions");
			if (xmissionRoot == null)
				return;

			IEnumerable<XElement> xmissions = xmissionRoot.Elements(); // XPathSelectElements("Mission");
			if (xmissions == null || xmissions.Count<XElement>() == 0)
				return;
			
			foreach (XElement xmission in xmissions)
			{
				Mission mission = new Mission();

				XElement xdescription = xmission.XPathSelectElement("Description");
				mission.Description = xdescription.Value;

				XElement xminRounds = xmission.XPathSelectElement("MinRounds");
				mission.MinRounds = Int32.Parse(xminRounds.Value);
				XElement xmaxRounds = xmission.XPathSelectElement("MaxRounds");
				mission.MaxRounds = Int32.Parse(xmaxRounds.Value);
				XElement xgain = xmission.XPathSelectElement("Gain");
				mission.Gain = Int32.Parse(xgain.Value);

				this.missions.Add(mission);
			}
		}




	}
}
