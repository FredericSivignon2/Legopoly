using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Legopoly.Data.Items;
using System.Windows.Forms;
using Legopoly.Data.Jobs;

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
        /// Gets or sets the player experiences information.
        /// </summary>
        public LPExperiences Experiences { get; set; } = new LPExperiences();

        public List<ItemBase> Items { get; } = new List<ItemBase>();
        /// <summary>
        /// Gets or sets the player Job
        /// </summary>
        public JobBase Job { get; set; }
        #endregion 

        public bool Play(Form parentForm, Game game)
        {
            using (FormPlay play = new FormPlay(this, game))
            {
                if (play.ShowDialog(parentForm) != DialogResult.OK)
                    return false;
            }
            return true;
        }
    }
}
