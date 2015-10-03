using Legopoly.Data.Jobs;
using Legopoly.Data.Missions;
using System;
using System.Collections.Generic;
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
        [DataMember]
        private int round = 1;
        [DataMember]
        private List<Player> players;
		private List<JobBase> allJobs;
		private List<Mission> allMissions;
		private Random rnd;
        #endregion

        #region Constructor
        public Game()
        {
            this.players = new List<Player>();
			this.allJobs = new List<JobBase>();
			this.allMissions = new List<Mission>();
            this.rnd = new Random(DateTime.UtcNow.Millisecond);
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
        #endregion

        #region Public Methods
		public int GetRandomNumber(int min, int max)
		{
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
        #endregion

		private void InitializeAllJobs()
		{
			this.allJobs.Add(new Fireman());
			this.allJobs.Add(new Policeman());
        }
    }
}
