using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Legopoly.Data.Items;
using System.Windows.Forms;

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
        public LPExperiences Experiences { get; set; } = new LPExperiences();

        public List<ItemBase> Items { get; } = new List<ItemBase>();
        #endregion 

        public bool Play(Form parentForm)
        {
            using (FormPlay play = new FormPlay(this))
            {
                if (play.ShowDialog(parentForm) != DialogResult.OK)
                    return false;
            }
            return true;
        }
    }
}
