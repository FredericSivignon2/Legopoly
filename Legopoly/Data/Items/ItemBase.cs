using FoundationLibraries.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Items
{
    [KnownType(typeof(Home))]
    [KnownType(typeof(Building))]
    [KnownType(typeof(Vehicle))]
    [KnownType(typeof(Bicycle))]
    [KnownType(typeof(Car))]
    [KnownType(typeof(Truck))]
    [DataContract]
    public class ItemBase
    {
		#region Public Properties
		/// <summary>
		/// Gets or sets the item name.
		/// </summary>
		[DataMember]
        public string Name { get; set; }

        /// <summary>
        /// The initial cost of the item when a Player want to buy it.
        /// </summary>
        [DataMember]
        public int InitialCost { get; set; } = 0;

        /// <summary>
        /// The amount of money that decriese 
        /// </summary>
        [DataMember]
        public int CostLostPerRound { get; set; } = 0;

        /// <summary>
        /// Gets or sets the amount of money needed to keep this item, per round.
        /// </summary>
        [DataMember]
        public int CostPerRound { get; set; } = 0;

        /// <summary>
        /// Gets or sets the amount of money win per round.
        /// </summary>
        [DataMember]
        public int GainPerRound { get; set; } = 0;

		[DataMember]
		public string PicturePath { get; set; }
		#endregion

		public string GetDisplayType()
        {
            if (this is Home)
                return "Habitation";
            if (this is Building)
                return "Batiment";
            if (this is Bicycle)
                return "Bicyclette";
            if (this is Car)
                return "Voiture";
            if (this is Truck)
                return "Camion";
			if (this is Motorbike)
				return "Moto";

            return "Inconnu";
        }

		public override string ToString()
		{
			return string.Format("{0} ({1})", this.Name, GetDisplayType());
		}

		public ItemBase Clone()
		{
			Type type = this.GetType();
			string serializedObj = XmlSerializationHelper.HelperUTF8.ToString(type, this);

			return (ItemBase)XmlSerializationHelper.HelperUTF8.FromString(serializedObj, type);
		}
	}
}
