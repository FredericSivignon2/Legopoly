using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Jobs
{
    /// <summary>
    /// 
    /// </summary>
    public class Grade
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="scientific"></param>
        /// <param name="physicalFitness"></param>
        /// <param name="managerialSkills"></param>
        /// <param name="creativity"></param>
        /// <param name="empathy"></param>
        public Grade(string name, int scientific, int physicalFitness, int managerialSkills, int creativity, int empathy, int salaryPerRound)
        {
            this.Name = name;
            this.MinimalExperiences = new LPExperiences()
            {
                Creativity = creativity,
                Empathy = empathy,
                ManagerialSkills = managerialSkills,
                PhysicalFitness = physicalFitness,
                Scientific = scientific
            };
            this.SalaryPerRound = salaryPerRound;
        }

        public string Name { get; set; }
        public LPExperiences MinimalExperiences { get; set; }
        /// <summary>
        /// Salary per round when the player is present at his Job (and only when he is present!!!)
        /// </summary>
        public int SalaryPerRound { get; set; }
    }
}
