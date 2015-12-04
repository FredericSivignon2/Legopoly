using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Items
{
	[DataContract]
	public class Bank : Building
	{
		[DataMember]
		public double LoanRate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public double MinLoanAmount { get; set; }

		/// <summary>
		/// Maximum value allowed for a Loan
		/// </summary>
		[DataMember]
		public double MaxLoanAmount { get; set; }

		/// <summary>
		/// When deposing money to the bank, the percentage of interest of the deposited value, per turn.
		/// </summary>
		[DataMember]
		public double DepositPercentInterestPerTurn { get; set; }

		public override string GetDisplayType()
		{
			return "Banque";
		}
	}
}
