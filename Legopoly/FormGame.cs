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
	public partial class FormGame : Form
	{
		private Game game;
		private Player player;

		public FormGame(Game game, Player player)
		{
			this.game = game;
			this.player = player;

			InitializeComponent();
			InitializeContent();
		}

		private void InitializeContent()
		{
			this.radioButtonFlechettes.Checked = true;
			UpdateControlEnabled();
		}

		private void UpdateControlEnabled()
		{
			this.buttonOK.Enabled = this.numericUpDownMise.Value > 0;
		}

		private void numericUpDownMise_ValueChanged(object sender, EventArgs e)
		{
			UpdateControlEnabled();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			double gain = 0.0;
			double bet = Convert.ToDouble(this.numericUpDownMise.Value);
			try
			{
				this.player.Capital -= bet;
			}
			catch (NoMoneyException exp)
			{
				LPMessageBox.ShowError(exp.Message);
				DialogResult = DialogResult.None;
				return;
			}

			if (this.radioButtonFlechettes.Checked)
			{
				int number = this.game.GetRandomNumber(1, 5);
				if (number <= 4)
				{
					gain = bet * 2.0;
				}
			}
			else
			if (this.radioButtonBillard.Checked)
			{
				int number = this.game.GetRandomNumber(1, 3);
				if (number <= 2)
				{
					gain = bet * 3.0;
				}
			}
			else
			if (this.radioButtonPocker.Checked)
			{
				int number = this.game.GetRandomNumber(1, 10);
				int win = 3;
				if (bet >= 10.0)
					win = 4;
				else
					if (bet >= 100.0)
					win = 5;
				else
					if (bet >= 1000.0)
					win = 6;
				else
					if (bet >= 10000.0)
					win = 7;

				if (number <= win)
				{
					gain = bet * 5.0;
				}
			}


			if (gain > 0.0)
			{
				LPMessageBox.ShowMessage(string.Format("Tu as gagné {0,10:N0}€ ({1,10:N0}€ de gain) !", gain - bet, gain));
				this.player.Capital += gain;
			}
			else
			{
				LPMessageBox.ShowWarning(string.Format("Tu as perdu ta mise de {0,10:N0}€ !", bet));
			}
		}

		private void radioButtonFlechettes_CheckedChanged(object sender, EventArgs e)
		{
			this.numericUpDownMise.Maximum = 50;
		}

		private void radioButtonBillard_CheckedChanged(object sender, EventArgs e)
		{
			this.numericUpDownMise.Maximum = 200;
		}

		private void radioButtonPocker_CheckedChanged(object sender, EventArgs e)
		{
			this.numericUpDownMise.Maximum = decimal.MaxValue;
		}
	}
}
