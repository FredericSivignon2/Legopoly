using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Items
{
    [KnownType(typeof(Bicycle))]
    [KnownType(typeof(Car))]
    [KnownType(typeof(Truck))]
	[KnownType(typeof(Motorbike))]
	[KnownType(typeof(ATC))]
	[DataContract]
    public class Vehicle : ItemBase
    {
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
        /// Gets or sets the cost when the Player move the item of one space.
        /// </summary>
        [DataMember]
        public double CostPerMove { get; set; } = 0.0;
    }
}
