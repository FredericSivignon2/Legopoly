using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Jobs
{
	/// <summary>
	/// 
	/// </summary>
	[DebuggerDisplay("{Name}, Per round: {SalaryPerRound}€")]
	public class Grade
    {
        /// <summary>
        /// 
        /// </summary>
        public Grade()
        {  
        }

		public Grade(Grade grade)
		{
			this.Name = grade.Name;
			this.MinimalExperiences = new LPExperiences(grade.MinimalExperiences);
			this.MaxExperiencesGainPerRound = new LPExperiences(grade.MaxExperiencesGainPerRound);
			this.SalaryPerRound = grade.SalaryPerRound;
        }

		public string Name { get; set; }
        /// <summary>
        /// Defines the minimal experiences needed to have this Grade.
        /// </summary>
        public LPExperiences MinimalExperiences { get; set; }

        /// <summary>
        /// Defines the maximum experience gain after a round.
        /// </summary>
        public LPExperiences MaxExperiencesGainPerRound { get; set;  }

        /// <summary>
        /// Salary per round when the player is present at his Job (and only when he is present!!!)
        /// </summary>
        public int SalaryPerRound { get; set; }
    }
}
