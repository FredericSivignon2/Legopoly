using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Legopoly.Data.Items;
using System.Windows.Forms;
using Legopoly.Data.Jobs;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Legopoly.Data
{
	[DebuggerDisplay("{Name}, {Capital}€")]
	[DataContract]
	public class Player
    {
		private Game game;
		private PlayerStateData stateData;

		public Player()
		{
			this.stateData = new PlayerStateData();
        }

		#region Public Properties
		/// <summary>
		/// Gets or sets the player Name
		/// </summary>
		[DataMember]
		public string Name { get; set; } = string.Empty;
		/// <summary>
		/// Gets or sets the player capital (in € for example)
		/// </summary>
		[DataMember]
		public double Capital { get; set; } = 10000.0;
		/// <summary>
		/// Gets or sets the player experiences information.
		/// </summary>
		[DataMember]
		public LPExperiences Experiences { get; set; } = new LPExperiences();

		[DataMember]
		public List<ItemBase> Items { get; private set; } = new List<ItemBase>();
		/// <summary>
		/// Gets or sets the player Job
		/// </summary>
		[DataMember]
		public JobBase Job { get; set; } = null;

		[DataMember]
		public PlayerStateData StateData
		{
			get
			{
				return this.stateData;
			}
			private set
			{
				this.stateData = value;
			}
		}

		/// <summary>
		/// Gets or sets a boolean value that indicates whether this player is currently working.
		/// </summary>
		[DataMember]
		public bool Working { get; set; } = false;
        #endregion

        public bool Play(Form parentForm, Game game)
        {
			this.game = game;
            using (FormPlay play = new FormPlay(this, game))
            {
                if (play.ShowDialog(parentForm) != DialogResult.OK)
                    return false;
            }
            return true;
        }

		public void ProcessEndOfRound()
		{
			if (this.Working && this.Job != null)
			{
				this.Capital += this.Job.SalaryPerRound;
				this.Experiences.Creativity += this.game.GetRandomNumber(0, this.Job.MaxExperiencesGainPerRound.Creativity);
				this.Experiences.Empathy += this.game.GetRandomNumber(0, this.Job.MaxExperiencesGainPerRound.Empathy);
				this.Experiences.ManagerialSkills += this.game.GetRandomNumber(0, this.Job.MaxExperiencesGainPerRound.ManagerialSkills);
				this.Experiences.PhysicalFitness += this.game.GetRandomNumber(0, this.Job.MaxExperiencesGainPerRound.PhysicalFitness);
				this.Experiences.Scientific += this.game.GetRandomNumber(0, this.Job.MaxExperiencesGainPerRound.Scientific);
			}

			foreach (ItemBase item in this.Items)
			{
				this.Capital -= item.CostPerRound;

			}
		}
    }
}
