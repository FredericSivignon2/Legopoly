using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legopoly.Data
{
    [DataContract]
    public class Game
    {
        #region Data Members
        [DataMember]
        private int round = 1;
        [DataMember]
        private List<Player> players;
        #endregion

        #region Constructor
        public Game()
        {
            this.players = new List<Player>();
        }
        #endregion

        #region Public Properties
        public List<Player> Players
        {
            get
            {
                return this.players;
            }
        }

        public int Round
        {
            get
            {
                return this.round;
            }
        }
        #endregion

        #region Public Methods
        public void Start(Form parentForm)
        {
            for (;;)
            {
                
                foreach (Player player in this.players)
                {
                    if (!player.Play(parentForm, this))
                    {
                        // Stop the game
                        return;
                    }
                }
                this.round++;
            }
        }
        #endregion
    }
}
