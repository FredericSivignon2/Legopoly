using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Items
{
	[KnownType(typeof(Car))]
	[KnownType(typeof(Truck))]
	[KnownType(typeof(Motorbike))]
	[KnownType(typeof(ATC))]
	[DataContract]
	public class MotorVehicle : Vehicle
	{
		private double tankCapacity;

		[DataMember]
		public double TankCapacity
		{
			get
			{
				return this.tankCapacity;
			}

			private set
			{
				this.tankCapacity = value;
				// Set full level by default
				if (FuelLevel == -1)
					FuelLevel = this.tankCapacity;
			}
		}

		[DataMember]
		public double FuelLevel { get; set; } = -1;

		[DataMember]
		public double ConsumptionPerMove { get; set; } = 0.0;

		/// <summary>
		/// Gets the number of move the vehicle is able to perform with the current fuel level
		/// </summary>
		public int NumberOfMoveLeft
		{
			get
			{
				return (int)(FuelLevel / ConsumptionPerMove);
            }
		}

		public double GetRefuelValue()
		{
			return (this.TankCapacity - this.FuelLevel) * GlobalData.Instance.CurrentGame.VehicleData.FuelCost;
		}
	}
}
