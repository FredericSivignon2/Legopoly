using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Missions
{
	[DataContract]
	public class MissionVehicle
	{
		[DataMember]
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the name of the Job for which the vehicule is dedicated
		/// (equals the JobBase.Name property. e.g.: "Pompier")
		/// </summary>
		[DataMember]
		public string ForJobName { get; set; }

		/// <summary>
		/// Gets or sets the minimum Grade Level that must have the Player to use this Vehicule
		/// </summary>
		[DataMember]
		public int MinimumGradeLevel { get; set; }

		/// <summary>
		///  Gets or sets the minimum number of space(s) this vehicle can achieve per round.
		/// </summary>
		[DataMember]
		public int MinMovePerRound { get; set; } = 0;

		/// <summary>
		///  Gets or sets the maximum number of space(s) this vehicle can achieve per round.
		/// </summary>
		[DataMember]
		public int MaxMovePerRound { get; set; } = 0;

		/// <summary>
		/// Gets or sets the maximum number of passengers this vehicle can carrie on
		/// For example, if a policeman must bring a gangster to jail, he must at least be able to
		/// carrie one passenger (the gangster), so a motorbike is not adapted!!!
		/// </summary>
		[DataMember]
		public int MaxPassengers { get; set; } = 0;

		[DataMember]
		public string PicturePath { get; set; }

		[DataMember]
		public double PercentCostPerMission { get; set; }

		public override string ToString()
		{
			return this.Name;
		}

		public string Description
		{
			get
			{
				StringBuilder description = new StringBuilder(this.Name);
				description.AppendLine();
				description.AppendLine();
				description.AppendLine(string.Format("Tu dois avoir au minimum un métier de niveau {0}.", MinimumGradeLevel));
				description.AppendLine(string.Format("Vitesse: {0} à {1} cases par tour.", MinMovePerRound, MaxMovePerRound));
				description.AppendLine(string.Format("Nombre de passagers: {0}", MaxPassengers));
				description.AppendLine(string.Format("Retenue sur le gain de la mission: {0:N2}%", PercentCostPerMission));

				return description.ToString();
			}
		}
	}
}
