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
		private double capital = 10000.0;
		private JobBase job;
		private int jailDays = 0;
		private BankAccountCollection bankAccounts;
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
		public double Capital
		{
			get
			{
				return this.capital;
			}

			set
			{
				if (value < 0.0)
					throw new NoMoneyException("Tu n'as pas assez d'argent !");

				this.capital = value;
			}
		}
		/// <summary>
		/// Gets or sets the player experiences information.
		/// </summary>
		[DataMember]
		public LPExperiences Experiences { get; set; } = new LPExperiences();

		[DataMember]
		public ItemBaseCollection Items
		{
			get; private set;
		} = new ItemBaseCollection();
		/// <summary>
		/// Gets or sets the player Job
		/// </summary>
		[DataMember]
		public JobBase Job
		{
			get
			{
				return this.job;
			}
			set
			{
				this.job = value;
			}
		}

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

		[DataMember]
		public int JailDays
		{
			get
			{
				return this.jailDays;
            }
			set
			{
				this.jailDays = value;
            }
		}

		[DataMember]
		public BankAccountCollection BankAccounts
		{
			get
			{
				return this.bankAccounts;
            }
			set
			{
				this.bankAccounts = value;
            }
		}
		#endregion

		public bool IsOwning(ItemBase item)
		{
			foreach (ItemBase curItem in this.Items)
			{
				if (curItem.Name == item.Name)
					return true;
			}

			return false;
		}

		public void Sleep(Game game)
		{
			if (game.JobData != null)
				this.workingRoundLeft = game.JobData.MaxWorkingRound;
		}

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
			if (this.Working && this.Job != null && this.jailDays == 0)
			{
				this.Capital += this.Job.SalaryPerRound * this.game.JobData.SalaryFactor;
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
				this.Capital += item.GainPerRound;

				item.CurrentCost -= item.CostLostPerRound;
            }

			if (this.jailDays > 0)
			{
				this.jailDays--;
			}
		}

		public override string ToString()
		{
			return this.Name;
		}

		public void ComputeThiefCatchedValues(out int jailDelay, out double fine)
		{
			if (this.Experiences.Thief == 0)
			{
				jailDelay = 2;
				fine = 0.0;
				return;
			}

			if (this.Experiences.Thief < 5)
			{
				jailDelay = 3;
				fine = 500.0;
				return;
			}

			if (this.Experiences.Thief < 10)
			{
				jailDelay = 4;
				fine = 1000.0;
				return;
			}

			if (this.Experiences.Thief < 20)
			{
				jailDelay = 8;
				fine = 10000.0;
				return;
			}

			if (this.Experiences.Thief < 40)
			{
				jailDelay = 10;
				fine = 20000.0;
				return;
			}

			fine = 50000.0;
			jailDelay = 20;
		}
	}
}
