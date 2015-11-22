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
	public partial class FormChoosePlayer : Form
	{
		public FormChoosePlayer(Game game, Player player)
		{
			InitializeComponent();
			InitializeContent(game, player);
		}

		public Player SelectedPlayer
		{
			get
			{
				return this.listBoxPlayers.SelectedItem as Player;
			}
		}

		private void InitializeContent(Game game, Player player)
		{
			foreach (Player currentPlayer in game.Players)
			{
				if (player != null && currentPlayer.Name == player.Name)
					continue; // A player A cannot select himself!

				this.listBoxPlayers.Items.Add(currentPlayer);
			}
		}
    }
}
