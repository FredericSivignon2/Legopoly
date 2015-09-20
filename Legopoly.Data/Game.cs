using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
