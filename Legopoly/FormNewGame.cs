using Legopoly.Data;
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
    public partial class FormNewGame : Form
    {
        private Game game;

        public FormNewGame()
        {
            InitializeComponent();

            this.game = new Game();
            InitializeFormContent();
            //this.listViewPlayers.DataBindings.Add("Name", this.game.Players, "Name");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (FormPlayerEdition dlg = new FormPlayerEdition())
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    this.game.Players.Add(dlg.Player);
                    AddPlayerItem(dlg.Player);
                }
            }
        }

        private void InitializeFormContent()
        {
            this.listViewPlayers.Columns.Add("Name", 220);

            foreach (Player player in this.game.Players)
            {
                AddPlayerItem(player);
                
            }
        }

        private void AddPlayerItem(Player player)
        {
            ListViewItem item = new ListViewItem(player.Name);
            this.listViewPlayers.Items.Add(item);
        }
    }
}
