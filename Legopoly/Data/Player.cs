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
		#region Data Members
		private Game game;
		private PlayerStateData stateData;
		private bool working = false;
		private int workingRoundLeft = 0;
		#endregion

		#region Constructors
		public Player()
		{
			this.stateData = new PlayerStateData();
        }
		#endregion

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
		public bool Working
		{
			get
			{
				return this.working;
			}
			set
			{
				this.working = value;
				if (this.working)
					// The user cannot stay working for more than 'MaxWorkingRound' rounds
					this.workingRoundLeft = this.game.JobData.MaxWorkingRound;
            }
		}

		[DataMember]
		public int WorkingRoundLeft
		{
			get
			{
				return this.workingRoundLeft;
            }
			set
			{
				this.workingRoundLeft = value;
            }
		}
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
				int gainCreativity = this.game.GetRandomNumber(0, this.Job.MaxExperiencesGainPerRound.Creativity + 1);
				int gainEmpathy = this.game.GetRandomNumber(0, this.Job.MaxExperiencesGainPerRound.Empathy + 1);
				int gainManager = this.game.GetRandomNumber(0, this.Job.MaxExperiencesGainPerRound.ManagerialSkills + 1);
				int gainPhysical = this.game.GetRandomNumber(0, this.Job.MaxExperiencesGainPerRound.PhysicalFitness + 1);
				int gainScientific = this.game.GetRandomNumber(0, this.Job.MaxExperiencesGainPerRound.Scientific + 1);

				this.Experiences.Creativity += gainCreativity;
				this.Experiences.Empathy += gainEmpathy;
				this.Experiences.ManagerialSkills += gainManager;
				this.Experiences.PhysicalFitness += gainPhysical;
				this.Experiences.Scientific += gainScientific;

				this.workingRoundLeft--;
            }

			foreach (ItemBase item in this.Items)
			{
				this.Capital -= item.CostPerRound;

			}
		}
    }
}
