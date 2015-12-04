namespace Legopoly
{
	partial class FormBank
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBank));
			this.radioButtonPutMoney = new System.Windows.Forms.RadioButton();
			this.radioButtonGetMoney = new System.Windows.Forms.RadioButton();
			this.radioButtonTakeOutALoan = new System.Windows.Forms.RadioButton();
			this.labelDepositHelp = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDownPutMoney = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelBanqueName = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.labelDeposit = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.labelLoanRepaymentPerTurn = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPutMoney)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// radioButtonPutMoney
			// 
			this.radioButtonPutMoney.AutoSize = true;
			this.radioButtonPutMoney.Location = new System.Drawing.Point(13, 132);
			this.radioButtonPutMoney.Name = "radioButtonPutMoney";
			this.radioButtonPutMoney.Size = new System.Drawing.Size(117, 17);
			this.radioButtonPutMoney.TabIndex = 0;
			this.radioButtonPutMoney.TabStop = true;
			this.radioButtonPutMoney.Text = "Déposer de l\'argent";
			this.radioButtonPutMoney.UseVisualStyleBackColor = true;
			this.radioButtonPutMoney.CheckedChanged += new System.EventHandler(this.radioButtonPutMoney_CheckedChanged);
			// 
			// radioButtonGetMoney
			// 
			this.radioButtonGetMoney.AutoSize = true;
			this.radioButtonGetMoney.Location = new System.Drawing.Point(13, 239);
			this.radioButtonGetMoney.Name = "radioButtonGetMoney";
			this.radioButtonGetMoney.Size = new System.Drawing.Size(108, 17);
			this.radioButtonGetMoney.TabIndex = 1;
			this.radioButtonGetMoney.TabStop = true;
			this.radioButtonGetMoney.Text = "Retirer de l\'argent";
			this.radioButtonGetMoney.UseVisualStyleBackColor = true;
			this.radioButtonGetMoney.CheckedChanged += new System.EventHandler(this.radioButtonGetMoney_CheckedChanged);
			// 
			// radioButtonTakeOutALoan
			// 
			this.radioButtonTakeOutALoan.AutoSize = true;
			this.radioButtonTakeOutALoan.Location = new System.Drawing.Point(13, 324);
			this.radioButtonTakeOutALoan.Name = "radioButtonTakeOutALoan";
			this.radioButtonTakeOutALoan.Size = new System.Drawing.Size(114, 17);
			this.radioButtonTakeOutALoan.TabIndex = 2;
			this.radioButtonTakeOutALoan.TabStop = true;
			this.radioButtonTakeOutALoan.Text = "Souscrire à un prêt";
			this.radioButtonTakeOutALoan.UseVisualStyleBackColor = true;
			this.radioButtonTakeOutALoan.CheckedChanged += new System.EventHandler(this.radioButtonTakeOutALoan_CheckedChanged);
			// 
			// labelDepositHelp
			// 
			this.labelDepositHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelDepositHelp.ForeColor = System.Drawing.SystemColors.Highlight;
			this.labelDepositHelp.Location = new System.Drawing.Point(53, 156);
			this.labelDepositHelp.Name = "labelDepositHelp";
			this.labelDepositHelp.Size = new System.Drawing.Size(774, 34);
			this.labelDepositHelp.TabIndex = 3;
			this.labelDepositHelp.Text = "A LEGOPoly, déposer de l\'argent dans une banque, en plus de pouvoir te rapporter " +
    "de temps en temps, te permet aussi, comme pour une assurance, de t\'aider financi" +
    "èrement en cas de problème.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 193);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Somme à déposer:";
			// 
			// numericUpDownPutMoney
			// 
			this.numericUpDownPutMoney.Location = new System.Drawing.Point(157, 191);
			this.numericUpDownPutMoney.Name = "numericUpDownPutMoney";
			this.numericUpDownPutMoney.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownPutMoney.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(283, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "€";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(283, 272);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "€";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(157, 270);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown2.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(56, 272);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Somme à retirer:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 13);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Compte dans la banque:";
			// 
			// labelBanqueName
			// 
			this.labelBanqueName.AutoSize = true;
			this.labelBanqueName.Location = new System.Drawing.Point(142, 13);
			this.labelBanqueName.Name = "labelBanqueName";
			this.labelBanqueName.Size = new System.Drawing.Size(110, 13);
			this.labelBanqueName.TabIndex = 11;
			this.labelBanqueName.Text = "-- nom de la banque --";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 38);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Solde:";
			// 
			// labelDeposit
			// 
			this.labelDeposit.AutoSize = true;
			this.labelDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDeposit.Location = new System.Drawing.Point(53, 38);
			this.labelDeposit.Name = "labelDeposit";
			this.labelDeposit.Size = new System.Drawing.Size(39, 13);
			this.labelDeposit.TabIndex = 13;
			this.labelDeposit.Text = "0.00€";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(13, 53);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(212, 13);
			this.label9.TabIndex = 14;
			this.label9.Text = "Remboursement de prêt en cours (par tour):";
			// 
			// labelLoanRepaymentPerTurn
			// 
			this.labelLoanRepaymentPerTurn.AutoSize = true;
			this.labelLoanRepaymentPerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLoanRepaymentPerTurn.Location = new System.Drawing.Point(231, 53);
			this.labelLoanRepaymentPerTurn.Name = "labelLoanRepaymentPerTurn";
			this.labelLoanRepaymentPerTurn.Size = new System.Drawing.Size(39, 13);
			this.labelLoanRepaymentPerTurn.TabIndex = 15;
			this.labelLoanRepaymentPerTurn.Text = "0.00€";
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(670, 500);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 17;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(751, 500);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 16;
			this.buttonCancel.Text = "Annuler";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// FormBank
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(838, 535);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.labelLoanRepaymentPerTurn);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.labelDeposit);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.labelBanqueName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numericUpDownPutMoney);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelDepositHelp);
			this.Controls.Add(this.radioButtonTakeOutALoan);
			this.Controls.Add(this.radioButtonGetMoney);
			this.Controls.Add(this.radioButtonPutMoney);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormBank";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Banque";
			this.Load += new System.EventHandler(this.FormBank_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPutMoney)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton radioButtonPutMoney;
		private System.Windows.Forms.RadioButton radioButtonGetMoney;
		private System.Windows.Forms.RadioButton radioButtonTakeOutALoan;
		private System.Windows.Forms.Label labelDepositHelp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDownPutMoney;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelBanqueName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label labelDeposit;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label labelLoanRepaymentPerTurn;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
	}
}