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
		#region Data Members
		

		#endregion

		public Mission()
		{
		}

		public string Description { get; set; }
		public int MinRounds { get; set; }
		public int MaxRounds { get; set; }
		public int Gain { get; set; }
	}
}
