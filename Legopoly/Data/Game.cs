using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legopoly.Data
{
    public class Game
    {
        private List<Player> players;

        public Game()
        {
            this.players = new List<Player>();
        }

        public List<Player> Players
        {
            get
            {
                return this.players;
            }
        }

        public void Start(Form parentForm)
        {
            for (;;)
            {
                foreach (Player player in this.players)
                {
                    if (!player.Play(parentForm))
                    {
                        // Stop the game
                        return;
                    }
                }
            }
        }
    }
}
