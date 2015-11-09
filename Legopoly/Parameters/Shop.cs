﻿using FoundationLibraries.Xml;
using Legopoly.Data.Items;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Legopoly.Parameters
{
    [DataContract]
    public class Shop
    {
		private const string itemsDataFilePath = "items_data.xml";

        /// <summary>
        /// 
        /// </summary>
        public Shop()
        {
			try
			{
				ItemBase[] items = XmlSerializationHelper.HelperUTF8.FromFile<ItemBase[]>(DataFilePath);
				Items.AddRange(items);
			}
			catch (Exception exp)
			{
				LPMessageBox.ShowError("Impossible de charger le magasin en mémoire.\r\nVérifiez la validité du fichier: " + DataFilePath);
			}

			//string str = XmlSerializationHelper.HelperUTF8.ToString<ItemBase[]>(this.Items.ToArray<ItemBase>());
			
			//XDocument document = XDocument.Parse(str, LoadOptions.None);
			//XDocument formattedDocument = XDocument.Parse(document.ToString(SaveOptions.None));

			//string xformatted = formattedDocument.ToString();
			//File.WriteAllText(@"E:\Development\Jeux\Legopoly\items.xml", xformatted);
        }

        [DataMember]
        public List<ItemBase> Items { get; set; } = new List<ItemBase>();


		private static string DataFilePath
		{
			get
			{
				return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, itemsDataFilePath);
			}
		}
	}
}
