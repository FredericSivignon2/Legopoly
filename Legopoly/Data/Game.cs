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

		private List<JobBase> allJobs;
		private List<Mission> allMissions;
		private Random rnd;
		private GameVehicleData vehicleData;
		#endregion

		#region Constructor
		public Game()
        {
            this.players = new List<Player>();
			this.allMissions = new List<Mission>();
			this.vehicleData = new GameVehicleData();

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
			if (LPMessageBox.ShowQuestion("Voulez vous sauver le jeu ?") != DialogResult.Yes)
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
				LPMessageBox.ShowMessage("Jeu sauvegardé.");
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

			game.vehicleData = new GameVehicleData();
			game.LoadData();
            return game;
		}
		#endregion

		private void InitializeAllJobs()
		{
			this.allJobs = new List<JobBase>();
			this.allJobs.Add(new Fireman());
			this.allJobs.Add(new Policeman());
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

			IniSection section = iniFile.Sections["Vehicles"];
			this.vehicleData.FuelCost = Double.Parse(section.KeyValues["FuelCost"], CultureInfo.InvariantCulture);
			
		}
    }
}
