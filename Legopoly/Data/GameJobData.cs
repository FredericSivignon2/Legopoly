using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data
{
	public class GameJobData
	{
		/// <summary>
		/// Gets or sets the maximum number of consecutive rounds a player can work, before to go to sleep at home
		/// </summary>
		public int MaxWorkingRound { get; set; }

		/// <summary>
		/// Gets or sets the factor to multiply salary from job_default.ini file
		/// </summary>
		public int SalaryFactor { get; set; }
	}
}
