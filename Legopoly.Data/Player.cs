using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data
{
    public class Player
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the player Name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the player capital (in € for example)
        /// </summary>
        public int Capital { get; set; } = 10000;
        /// <summary>
        /// Gets or sets the play experiences information.
        /// </summary>
        public Experiences Experiences { get; set; } = new Experiences();
        #endregion
    }
}
