using FoundationLibraries.Xml;
using System;
using System.Collections.Generic;
using System.IO;
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
	[KnownType(typeof(ATC))]
    [DataContract]
    public class ItemBase
    {
		private const string itemsDataFilePath = "items_data.xml";
		
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
        public double InitialCost { get; set; } = 0.0;

		[DataMember]
		public double CurrentCost { get; set; } = 0.0;

        /// <summary>
        /// The amount of money that decriese 
        /// </summary>
        [DataMember]
        public double CostLostPerRound { get; set; } = 0.0;

        /// <summary>
        /// Gets or sets the amount of money needed to keep this item, per round.
        /// </summary>
        [DataMember]
        public double CostPerRound { get; set; } = 0.0;

        /// <summary>
        /// Gets or sets the amount of money win per round (for example, if the item is the "PetShop", you will gain something)
        /// </summary>
        [DataMember]
        public double GainPerRound { get; set; } = 0.0;

		[DataMember]
		public string PicturePath { get; set; }
		#endregion

		public virtual string GetDisplayType()
        {
			return string.Empty;
        }

		public override string ToString()
		{
			StringBuilder result = new StringBuilder(string.Format("{0} ({1}){2}", this.Name, GetDisplayType(), Environment.NewLine));
			result.AppendLine();
			result.AppendLine(string.Format("Valeur d'achat: {0:C2}", InitialCost));
			result.AppendLine(string.Format("Valeur actuelle de vente: {0:C2}", CurrentCost));

			result.AppendLine();
			result.AppendLine(string.Format("Coût par tour: {0:C2}", CostPerRound));
			result.AppendLine(string.Format("Gain par tour: {0:C2}", GainPerRound));

			return result.ToString();
		}

		public ItemBase Clone()
		{
			Type type = this.GetType();
			string serializedObj = XmlSerializationHelper.HelperUTF8.ToString(type, this);

			return (ItemBase)XmlSerializationHelper.HelperUTF8.FromString(serializedObj, type);
		}

		public static ItemBase[] GetAllItems()
		{
			try
			{
				ItemBase[] items = XmlSerializationHelper.HelperUTF8.FromFile<ItemBase[]>(DataFilePath);
				return items;
			}
			catch (Exception exp)
			{
				LPMessageBox.ShowError("Impossible de charger la liste des items en mémoire.\r\nVérifiez la validité du fichier: " + DataFilePath, exp);
				return new ItemBase[0];
			}
		}

		private static string DataFilePath
		{
			get
			{
				return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, itemsDataFilePath);
			}
		}
	}
}
