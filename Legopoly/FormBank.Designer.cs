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
			this.labelChooseBank = new System.Windows.Forms.Label();
			this.userControlItems1 = new Legopoly.UserControlItems();
			this.SuspendLayout();
			// 
			// labelChooseBank
			// 
			this.labelChooseBank.AutoSize = true;
			this.labelChooseBank.Location = new System.Drawing.Point(13, 13);
			this.labelChooseBank.Name = "labelChooseBank";
			this.labelChooseBank.Size = new System.Drawing.Size(474, 13);
			this.labelChooseBank.TabIndex = 0;
			this.labelChooseBank.Text = "Choisis la banque dans laquelle tu souhaites rentrer: (utiliser items pour affich" +
    "er la liste des banques)";
			// 
			// userControlItems1
			// 
			this.userControlItems1.Items = new Legopoly.Data.Items.ItemBase[0];
			this.userControlItems1.Location = new System.Drawing.Point(12, 29);
			this.userControlItems1.Name = "userControlItems1";
			this.userControlItems1.Size = new System.Drawing.Size(637, 209);
			this.userControlItems1.TabIndex = 1;
			// 
			// FormBank
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(838, 535);
			this.Controls.Add(this.userControlItems1);
			this.Controls.Add(this.labelChooseBank);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormBank";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Banque";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelChooseBank;
		private UserControlItems userControlItems1;
	}
}