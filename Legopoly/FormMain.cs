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
                    }
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
    }
}
