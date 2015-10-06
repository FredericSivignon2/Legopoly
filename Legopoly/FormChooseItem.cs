using Legopoly.Data;
using Legopoly.Data.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legopoly
{
    public partial class FormChooseItem : Form
    {
        private Player player;
       
        public FormChooseItem(Player player)
        {
            this.player = player;

            InitializeComponent();
            InitializeFormContent();
        }

        public ItemBase SelectedItem
        {
            get
            {
                return this.userControlItems1.SelectedItem;
            }
        }

        private void InitializeFormContent()
        {
            
            List<ItemBase> allItems = Parameters.ParametersMain.Instance.Shop.Items;

            foreach (ItemBase item in allItems)
            {
				if (item.InitialCost <= this.player.Capital)
				{
					// Make a clone, so we won't modify shop property
					ItemBase newItem = item.Clone();
					this.userControlItems1.AddItem(newItem);
				}
            }
			this.userControlItems1.Refresh();
        }

        /*private void UpdateDescription()
        {
            if (this.selectedItem is Car)
            {
                Car car = this.selectedItem as Car;
                this.textBox1.Text = string.Format("Chaque tour, cette voiture consomme {0}€ d'essence et d'entretien. Elle perd également {0}€ de sa valeur de revente. Elle peut se déplacer de {0} à {1} cases par tour.", 
                    car.CostPerRound, car.CostLostPerRound, car.MinMovePerRound, car.MaxMovePerRound);
            }
            if (this.selectedItem is Bicycle)
            {
                Bicycle bicycle = this.selectedItem as Bicycle;
                this.textBox1.Text = string.Format("Chaque tour, ce vélo consomme {0}€ d'entretien. Il perd également {0}€ de sa valeur de revente. Il peut se déplacer de {0} à {1} cases par tour.",
                    bicycle.CostPerRound, bicycle.CostLostPerRound, bicycle.MinMovePerRound, bicycle.MaxMovePerRound);
            }
            if (this.selectedItem is Home)
            {
                Home home = this.selectedItem as Home;
                this.textBox1.Text = string.Format("Chaque tour, cette maison vous fait dépenser {0}€ en entretien.", home.CostPerRound);
            }
            if (this.selectedItem is Truck)
            {
                Truck truck = this.selectedItem as Truck;
                this.textBox1.Text = string.Format("Chaque tour, ce camion consomme {0}€ d'essence et d'entretien. Il perd également {0}€ de sa valeur de revente. Il peut se déplacer de {0} à {1} cases par tour.",
                    truck.CostPerRound, truck.CostLostPerRound, truck.MinMovePerRound, truck.MaxMovePerRound);
            }

            if (this.selectedItem is Building)
            {
                Building building = this.selectedItem as Building;
                this.textBox1.Text = string.Format("Chaque tour, ce batiment vous rapporte {0}€", building.GainPerRound);
            }
        }*/
    }
}
