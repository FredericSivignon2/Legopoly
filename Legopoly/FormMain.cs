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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                using (FormNewGame dlg = new FormNewGame())
                {
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        // Start the game
                        Game game = dlg.Game;

						GlobalData.Instance.InitializeGame(game);
						try
						{
							game.Start(this);
						}
						finally
						{
							game.Save();
						}
						
                    }
                }
            }
            finally
            {
                this.Show();
            }
        }

		private void buttonLoad_Click(object sender, EventArgs e)
		{
			this.Hide();
			try
			{
				Game game = Game.Load();
				GlobalData.Instance.InitializeGame(game);

				try
				{
					game.Start(this);
				}
				finally
				{
					game.Save();
				}
			}
			finally
			{
				this.Show();
			}

		}

		private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {

            using (FormParameters dlg = new FormParameters())
            {
                dlg.ShowDialog();
            }

        }

		
	}
}
