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
			CreateDefaultPlayers();
            InitializeFormContent();
        }

        public Game Game
        {
            get
            {
                return this.game;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (FormPlayerEdition dlg = new FormPlayerEdition())
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    AddPlayerItem(dlg.Player);
                    this.game.Players.Add(dlg.Player);
                    //this.listViewPlayers.Invalidate(true);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.listViewPlayers.SelectedItems.Count == 0)
                return;

            ListViewItem item = this.listViewPlayers.SelectedItems[0];

            using (FormPlayerEdition dlg = new FormPlayerEdition(item.Tag as Player))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    this.listViewPlayers.Items.Remove(item);
                    this.game.Players.Remove(item.Tag as Player);

                    AddPlayerItem(dlg.Player);
                    this.game.Players.Add(dlg.Player);
                    //this.listViewPlayers.Invalidate(true);
                }
            }
        }

        private void InitializeFormContent()
        {
            this.listViewPlayers.Columns.Add("Nom", 220);
            this.listViewPlayers.Columns.Add("Creativité", 100);
            this.listViewPlayers.Columns.Add("Empathie", 100);
            this.listViewPlayers.Columns.Add("Management", 100);
            this.listViewPlayers.Columns.Add("Forme Physique", 100);
            this.listViewPlayers.Columns.Add("Scientifique", 100);

            foreach (Player player in this.game.Players)
            {
                AddPlayerItem(player);
                
            }
        }

        private void AddPlayerItem(Player player)
        {
            ListViewItem item = new ListViewItem(player.Name);
            item.Tag = player;

            item.SubItems.Add(player.Experiences.Creativity.ToString());
            item.SubItems.Add(player.Experiences.Empathy.ToString());
            item.SubItems.Add(player.Experiences.ManagerialSkills.ToString());
            item.SubItems.Add(player.Experiences.PhysicalFitness.ToString());
            item.SubItems.Add(player.Experiences.Scientific.ToString());

            this.listViewPlayers.Items.Add(item);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.listViewPlayers.SelectedItems.Count == 0)
                return;

            ListViewItem item = this.listViewPlayers.SelectedItems[0];
            this.game.Players.Remove(item.Tag as Player);
            this.listViewPlayers.Items.Remove(item);
        }

		private void CreateDefaultPlayers()
		{
			try
			{
				this.game = new Game();
				Player player = new Player()
				{
					Name = "Damien",
					Capital = this.game.PlayerData.DefaultCapital
				};
				player.Experiences.Empathy = 10;
				player.Experiences.Creativity = 2;
				player.Experiences.PhysicalFitness = 20;
				player.Experiences.Scientific = 6;
				player.Experiences.ManagerialSkills = 2;

				this.game.Players.Add(player);

				player = new Player()
				{
					Name = "Léa",
					Capital = this.game.PlayerData.DefaultCapital
				};
				player.Experiences.Empathy = 2;
				player.Experiences.Creativity = 10;
				player.Experiences.PhysicalFitness = 20;
				player.Experiences.Scientific = 6;
				player.Experiences.ManagerialSkills = 2;

				this.game.Players.Add(player);

				player = new Player()
				{
					Name = "Frédéric",
					Capital = this.game.PlayerData.DefaultCapital
				};
				player.Experiences.Empathy = 2;
				player.Experiences.Creativity = 10;
				player.Experiences.PhysicalFitness = 20;
				player.Experiences.Scientific = 6;
				player.Experiences.ManagerialSkills = 2;

				this.game.Players.Add(player);
			}
			catch (Exception exp)
			{
				LPMessageBox.ShowError("Erreur pendant la creation des joueurs !", exp);
			}
		}
    }
}
