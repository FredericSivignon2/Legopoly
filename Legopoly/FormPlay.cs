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
    public partial class FormPlay : Form
    {
        private Player player;

        public FormPlay(Player player)
        {
            this.player = player;

            InitializeComponent();
            InitializeFormContent();
        }

        private void InitializeFormContent()
        {
            this.labelName.Text = this.player.Name;
            UpdateCapitalDisplay();
             InitializeHeritageList();
        }

        private void InitializeHeritageList()
        {
            this.listViewHeritage.Columns.Add("Nom", 220);
            this.listViewHeritage.Columns.Add("Type", 150);
            this.listViewHeritage.Columns.Add("Prix par tour", 100);
        }

        private void buttonBuyItem_Click(object sender, EventArgs e)
        {
            using (FormChooseItem dlg = new FormChooseItem(this.player))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    ItemBase itemBase = dlg.SelectedItem;
                    AddListViewItem(itemBase);
                }
            }
        }

        private void AddListViewItem(ItemBase itemBase)
        {
            ListViewItem item = new ListViewItem(itemBase.Name);

            item.SubItems.Add(itemBase.GetDisplayType());
            item.SubItems.Add(itemBase.CostPerRound.ToString());
            this.listViewHeritage.Items.Add(item);

            this.player.Items.Add(itemBase);
        }

        private void UpdateCapitalDisplay()
        {
            this.labelCapital.Text = string.Format("{0}€", this.player.Capital);
        }
    }
}
