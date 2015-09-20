using Legopoly.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Parameters
{
    [DataContract]
    public class Shop
    {
        /// <summary>
        /// 
        /// </summary>
        public Shop()
        {
            this.Items.Add(new Home()
            {
                Name = "Maison Toit bleu",
                InitialCost = 60000,
                CostLostPerRound = 0,
                CostPerRound = 5,
                GainPerRound = 0
            });

            this.Items.Add(new Home()
            {
                Name = "Maison Toit rouge",
                InitialCost = 72000,
                CostLostPerRound = 0,
                CostPerRound = 6,
                GainPerRound = 0
            });
            this.Items.Add(new Car()
            {
                Name = "Voiture Sport Bordeau",
                InitialCost = 8000,
                CostLostPerRound = 2,
                CostPerRound = 4,
                GainPerRound = 0,
                MaxMovePerRound = 8,
                MinMovePerRound = 4
            });
            this.Items.Add(new Bicycle()
            {
                Name = "Vélo rouge",
                InitialCost = 130,
                CostLostPerRound = 0,
                CostPerRound = 0,
                GainPerRound = 0,
                MaxMovePerRound = 2,
                MinMovePerRound = 1
            });
        }

        [DataMember]
        public List<ItemBase> Items { get; set; } = new List<ItemBase>();
    }
}
