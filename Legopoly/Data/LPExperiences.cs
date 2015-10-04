using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data
{
	[DataContract]
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
		[DataMember]
		public int Scientific { get; set; } = 0;

		[DataMember]
		public int PhysicalFitness { get; set; } = 0;

		[DataMember]
		public int ManagerialSkills { get; set; } = 0;

		[DataMember]
		public int Creativity { get; set; } = 0;

		[DataMember]
		public int Empathy { get; set; } = 0;
        #endregion
    }
}
