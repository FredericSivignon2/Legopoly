using FoundationLibraries.Xml;
using Legopoly.Data.Jobs;
using Legopoly.Data.Missions;
using Legopoly.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legopoly.Data
{
    [DataContract]
    public class Game
    {
		#region Data Members
		private const string dataFilePath = "game_data.ini";
		private const string gameBackup = "game_backup.xml";

		[DataMember]
        private int round = 1;
        [DataMember]
        private List<Player> players;
		[DataMember]
		private GameVehicleData vehicleData;
		[DataMember]
		private GameJobData jobData;
		[DataMember]
		private PlayerData playerData;

		// No need to serialize and better to be able to update it each time we continue a previously saved game
		private List<JobBase> allJobs;
		private Random rnd;		
		#endregion

		#region Constructor
		public Game()
        {
            this.players = new List<Player>();
			this.vehicleData = new GameVehicleData();
			this.jobData = new GameJobData();
			this.playerData = new PlayerData();

			LoadData();
        }
        #endregion

        #region Public Properties
        public List<Player> Players
        {
            get
            {
                return this.players;
            }
        }

		public JobBase[] AllJobs
		{
			get
			{
				return this.allJobs.ToArray<JobBase>();
			}
		}

        public int Round
        {
            get
            {
                return this.round;
            }
        }

		public GameVehicleData VehicleData
		{
			get
			{
				return this.vehicleData;
            }
		}

		public GameJobData JobData
		{
			get
			{
				return this.jobData;
			}
		}

		public PlayerData PlayerData
		{
			get
			{
				return this.playerData;
			}
		}
		#endregion

		#region Public Methods
		public int GetRandomNumber(int min, int max)
		{
			if (this.rnd == null)
				this.rnd = new Random(DateTime.UtcNow.Millisecond);
			return this.rnd.Next(min, max);
		}

        public void Start(Form parentForm)
        {
			InitializeAllJobs();
			foreach (Player player in this.players)
			{
				player.Sleep(this);
			}

			for (;;)
            {
                
                foreach (Player player in this.players)
                {
					try
					{
						if (!player.Play(parentForm, this))
						{
							// Stop the game
							return;
						}
					}
					catch (Exception exp)
					{
						LPMessageBox.ShowError(string.Format("Erreur pendant le tour du joueur '{0}'.", player.Name), exp);
                    }
                }
                this.round++;
            }
        }

		public void Save()
		{
			if (LPMessageBox.ShowQuestion("Veux-tu sauver le jeu ?") != DialogResult.Yes)
				return;

			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, gameBackup);
			if (File.Exists(filePath) && LPMessageBox.ShowQuestion("Ecraser la sauvegarde existante ?") == DialogResult.Yes)
			{
				try
				{
					File.Delete(filePath);
				}
				catch (Exception exp)
				{
					LPMessageBox.ShowError("Impossible d'effacer la sauvegarde existante.", exp);
				}
			}

			try
			{
				XmlSerializationHelper.HelperUTF8.ToFile<Game>(filePath, this);
				LPMessageBox.ShowMessage(string.Format("Jeu sauvegardé dans\r\n{0}.", filePath));
			}
			catch (Exception exp)
			{
				LPMessageBox.ShowError("Impossible de sauvegarder le jeu courant.", exp);
			}
		}

		public static Game Load()
		{
			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, gameBackup);
			if (File.Exists(filePath) == false)
				return null;

			Game game = null;
            try
			{
				game = XmlSerializationHelper.HelperUTF8.FromFile<Game>(filePath);
			}
			catch (Exception exp)
			{
				LPMessageBox.ShowError("Impossible de sauvegarder le jeu courant.", exp);
			}
            return game;
		}
		#endregion

		private void InitializeAllJobs()
		{
			this.allJobs = new List<JobBase>();
			this.allJobs.Add(new Fireman());
			this.allJobs.Add(new Policeman());
			this.allJobs.Add(new Industrial());
        }

		private string DataFilePath
		{
			get
			{
				return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dataFilePath);
			}
		}

		private void LoadData()
		{
			string filePath = DataFilePath;
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

			if (iniFile.Sections.ContainsKey("Vehicles") == false)
				throw new Exception(string.Format("Il manque la section 'Vehicles' dans le fichier de configuration\r\n{0}", filePath));

			IniSection sectionVehicles = iniFile.Sections["Vehicles"];
			this.vehicleData.FuelCost = Double.Parse(sectionVehicles.KeyValues["FuelCost"], CultureInfo.InvariantCulture);

			IniSection sectionJobs = iniFile.Sections["Jobs"];
			this.jobData.MaxWorkingRound = Int32.Parse(sectionJobs.KeyValues["MaxWorkingRound"], CultureInfo.InvariantCulture);
			this.jobData.SalaryFactor = Int32.Parse(sectionJobs.KeyValues["SalaryFactor"], CultureInfo.InvariantCulture);

			IniSection sectionPlayers = iniFile.Sections["Players"];
			this.playerData.DefaultCapital = Int32.Parse(sectionPlayers.KeyValues["DefaultCapital"], CultureInfo.InvariantCulture);
		}
    }
}
