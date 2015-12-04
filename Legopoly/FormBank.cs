using Legopoly.Data;
using Legopoly.Data.Items;
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
	/// <summary>
	/// 
	/// </summary>
	public partial class FormBank : Form
	{
		#region Data Members
		private Game game;
		private Player player;
		private Bank bank;
		private BankAccount bankAccount;
		#endregion

		#region Constructor
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_game"></param>
		/// <param name="_player"></param>
		public FormBank(Game _game, Player _player)
		{
			this.game = _game;
			this.player = _player;

			InitializeComponent();
			
		}
		#endregion

		#region Private Methods
		private void InitializeContent()
		{
			using (FormChooseBank dlg = new FormChooseBank())
			{
				if (dlg.ShowDialog(this) != DialogResult.OK)
				{
					return;
				}
				this.bank = dlg.SelectedBank;
				if (this.bank == null)
				{
					return;
				}
            }

			if (this.player.BankAccounts == null)
			{
				this.player.BankAccounts = new BankAccountCollection();
			}
			this.bankAccount = this.player.BankAccounts.GetAccountOrCreate(this.bank);
			this.labelBanqueName.Text = this.bank.Name;
			this.labelLoanRepaymentPerTurn.Text = string.Format("{0:C2}", this.bankAccount.LoanRepaymentPerTurn);
			this.labelDeposit.Text = string.Format("{0:C2}", this.bankAccount.Deposit);

			this.radioButtonPutMoney.Checked = true;

			this.numericUpDownPutMoney.Maximum = Convert.ToDecimal(this.player.Capital);
			this.numericUpDown2.Maximum = Convert.ToDecimal(this.bankAccount.Deposit);
        }

		private void UpdateControlsEnabled()
		{
			this.labelDepositHelp.Enabled = this.radioButtonPutMoney.Checked;
			this.label2.Enabled = this.radioButtonPutMoney.Checked;
			this.numericUpDownPutMoney.Enabled = this.radioButtonPutMoney.Checked;
			this.label3.Enabled = this.radioButtonPutMoney.Checked;

			this.label5.Enabled = this.radioButtonGetMoney.Checked;
			this.numericUpDown2.Enabled = this.radioButtonGetMoney.Checked;
			this.label4.Enabled = this.radioButtonGetMoney.Checked;
		}
		#endregion

		#region Event Handlers
		private void FormBank_Load(object sender, EventArgs e)
		{
			InitializeContent();
			if (this.bank == null)
			{
				this.DialogResult = DialogResult.Cancel;
			}
		}

		private void radioButtonPutMoney_CheckedChanged(object sender, EventArgs e)
		{
			UpdateControlsEnabled();
		}

		private void radioButtonGetMoney_CheckedChanged(object sender, EventArgs e)
		{
			UpdateControlsEnabled();
		}

		private void radioButtonTakeOutALoan_CheckedChanged(object sender, EventArgs e)
		{
			UpdateControlsEnabled();
		}
		#endregion


	}
}
