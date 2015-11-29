using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Items
{
	/// <summary>
	/// A home, a house.
	/// </summary>
	[DataContract]
	public class Home : Building
	{
		public override string GetDisplayType()
		{
			return "Habitation";
		}
	}
}
