using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Items
{
	[DataContract]
	public class MotorVehicle : Vehicle
	{
		private int tankCapacity;

		[DataMember]
		public int TankCapacity
		{
			get
			{
				return this.tankCapacity;
			}

			private set
			{
				this.tankCapacity = value;
				// Set full level by default
				FuelLevel = this.tankCapacity;
			}
		}

		[DataMember]
		public int FuelLevel { get; set; } = -1;

		[DataMember]
		public int ConsumptionPerMove { get; set; }

		/// <summary>
		/// Gets the number of move the vehicle is able to perform with the current fuel level
		/// </summary>
		public int NumberOfMoveLeft
		{
			get
			{
				return FuelLevel / ConsumptionPerMove;
            }
		}

		public double GetRefuelValue()
		{
			return (this.TankCapacity - this.FuelLevel) * GlobalData.Instance.CurrentGame.VehicleData.FuelCost;
		}
	}
}
