using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Legopoly.Data.Items;
using System.Windows.Forms;
using Legopoly.Data.Jobs;
using System.Diagnostics;

namespace Legopoly.Data
{
	[DebuggerDisplay("{Name}, {Capital}€")]
	public class Player
    {
		private Game game;

        #region Public Properties
        /// <summary>
        /// Gets or sets the player Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the player capital (in € for example)
        /// </summary>
        public int Capital { get; set; } = 10000;
        /// <summary>
        /// Gets or sets the player experiences information.
        /// </summary>
        public LPExperiences Experiences { get; set; } = new LPExperiences();

        public List<ItemBase> Items { get; } = new List<ItemBase>();
        /// <summary>
        /// Gets or sets the player Job
        /// </summary>
        public JobBase Job { get; set; } = null;

		/// <summary>
		/// Gets or sets a boolean value that indicates whether this player is currently working.
		/// </summary>
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
