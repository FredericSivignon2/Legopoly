using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data
{
    public class LPExperiences
    {
		public LPExperiences()
		{

		}

		public LPExperiences(LPExperiences experiences)
		{
			this.Scientific = experiences.Scientific;
			this.PhysicalFitness = experiences.PhysicalFitness;
			this.ManagerialSkills = experiences.ManagerialSkills;
			this.Empathy = experiences.Empathy;
			this.Creativity = experiences.Creativity;
		}

		#region Public Properties
		public int Scientific { get; set; } = 0;
        public int PhysicalFitness { get; set; } = 0;
        public int ManagerialSkills { get; set; } = 0;
        public int Creativity { get; set; } = 0;
        public int Empathy { get; set; } = 0;
        #endregion
    }
}
