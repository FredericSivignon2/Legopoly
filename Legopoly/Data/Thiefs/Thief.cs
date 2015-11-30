using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Thiefs
{
	[DataContract]
	public class Thief
	{
		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public string Description { get; set; }

		/// <summary>
		/// Percentage of risk to be catched
		/// </summary>
		[DataMember]
		public double PercentRisk { get; set; }

		/// <summary>
		/// If true, this Thief represents a bank holdup
		/// </summary>
		[DataMember]
		public bool BankHoldUp { get; set; }

		/// <summary>
		/// If true, it means that the entire item will be stolen. Meaning that, if this
		/// item belongs to another player, this player loose it. Otherwise, if false but
		/// the item also belongs to a user, this user loose the money win by the thief
		/// </summary>
		[DataMember]
		public bool StoleItem { get; set; }

		public override string ToString()
		{
			return this.Name;
		}
	}
}
