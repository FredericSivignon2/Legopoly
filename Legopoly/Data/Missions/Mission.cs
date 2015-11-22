using Legopoly.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Missions
{
	public class Mission
	{
		#region Constructor
		public Mission()
		{
		}
		#endregion
		
		/// <summary>
		/// Gets or sets the mission description
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Gets or sets the minimum number of rounds allowed for this mission (random)
		/// </summary>
		public int MinRounds { get; set; }
		/// <summary>
		/// Gets or sets the maximum number of rounds allowed for this mission (random)
		/// </summary>
		public int MaxRounds { get; set; }
		/// <summary>
		/// Gets or sets the maximum gain for this mission
		/// </summary>
		public double Gain { get; set; }
		/// <summary>
		/// Gets or sets the minimum Job level needed to perform this mission
		/// </summary>
		public int MinLevel { get; set; }
    }
}
