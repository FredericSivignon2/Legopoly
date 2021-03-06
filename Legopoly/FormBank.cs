﻿using Legopoly.Data;
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
		private double loanRepaymentPerTurn;
		private int loanRepaymentTurnsLeft;
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
			this.label18.Text = string.Format("{0}%", this.bank.DepositPercentInterestPerTurn);

			this.radioButtonPutMoney.Checked = true;

			this.numericUpDownPutMoney.Maximum = Convert.ToDecimal(this.player.Capital);
			this.numericUpDownGetMoney.Maximum = Convert.ToDecimal(this.bankAccount.Deposit);

			this.numericUpDownTurnNumber.Value = 20;
			this.textBox1.Text = string.Format("{0}%", this.bank.LoanRate);

			// IMPORTANT!!!
			this.numericUpDownLoanAmount.Minimum = Convert.ToDecimal(this.bank.MinLoanAmount);
			this.numericUpDownLoanAmount.Maximum = Convert.ToDecimal(this.bank.MaxLoanAmount);

			this.labelTurnLeftValue.Text = string.Format("{0}", this.bankAccount.LoanRepaymentTurnsLeft);
			if (this.bankAccount.LoanRepaymentTurnsLeft <= 0)
			{
				this.label16.Visible = false;
				this.labelTurnLeftValue.Visible = false;
				this.labelTurnsLeft.Visible = false;
            }
			else
			{
				this.label16.Visible = true;
				this.labelTurnLeftValue.Visible = true;
				this.labelTurnsLeft.Visible = true;

				if (this.bankAccount.LoanRepaymentTurnsLeft == 1)
				{
					this.labelTurnsLeft.Text = "tour.";
                }
				else
				{
					this.labelTurnsLeft.Text = "tours.";
				}
			}
        }

		private void UpdateControlsEnabled()
		{
			this.label2.Enabled = this.radioButtonPutMoney.Checked;
			this.numericUpDownPutMoney.Enabled = this.radioButtonPutMoney.Checked;
			this.label3.Enabled = this.radioButtonPutMoney.Checked;

			this.label5.Enabled = this.radioButtonGetMoney.Checked;
			this.numericUpDownGetMoney.Enabled = this.radioButtonGetMoney.Checked;
			this.label4.Enabled = this.radioButtonGetMoney.Checked;

			this.panelLoan.Enabled = this.radioButtonTakeOutALoan.Checked;

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

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (this.radioButtonPutMoney.Checked)
			{
				double amount = Convert.ToDouble(this.numericUpDownPutMoney.Value);
				this.player.Capital -= amount;
				this.bankAccount.Deposit += amount;
			}
			else
			{
				if (this.radioButtonGetMoney.Checked)
				{
					double amount = Convert.ToDouble(this.numericUpDownGetMoney.Value);
					this.player.Capital += amount;
					this.bankAccount.Deposit -= amount;
				}
				else
				{
					if (this.radioButtonTakeOutALoan.Checked)
					{
						this.player.Capital += Convert.ToDouble(this.numericUpDownLoanAmount.Value);
						this.bankAccount.LoanRepaymentPerTurn = this.loanRepaymentPerTurn;
						this.bankAccount.LoanRepaymentTurnsLeft = Convert.ToInt32(this.numericUpDownTurnNumber.Value);
                    }
				}
			}
		}

		private void numericUpDownLoanAmount_ValueChanged(object sender, EventArgs e)
		{
			UpdateLoanValues();
		}

		private void numericUpDownTurnNumber_ValueChanged(object sender, EventArgs e)
		{
			UpdateLoanValues();
		}

		private void UpdateLoanValues()
		{
			double amount = Convert.ToDouble(this.numericUpDownLoanAmount.Value);
			double totalCost = amount + (amount * this.bank.LoanRate / 100.0);
			this.loanRepaymentPerTurn = totalCost / Convert.ToDouble(this.numericUpDownTurnNumber.Value);
            this.textBox2.Text = string.Format("{0:C2}", this.loanRepaymentPerTurn);	
        }
	}
}
