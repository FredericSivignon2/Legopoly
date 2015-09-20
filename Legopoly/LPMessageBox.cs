using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legopoly
{
    public static class LPMessageBox
    {
        private const string title = "LEGOPoly";

        public static void ShowMessage(string message)
        {
            MessageBox.Show(Program.MainForm, message, title, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public static void ShowError(string message, Exception exp = null)
        {
            StringBuilder msg = new StringBuilder(message);

            while (exp != null)
            {
                msg.AppendLine();
                msg.AppendLine(exp.Message);
                exp = exp.InnerException;
            }

            MessageBox.Show(Program.MainForm, msg.ToString(), title, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}
