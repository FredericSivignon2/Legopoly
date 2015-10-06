namespace Legopoly
{
    partial class FormChooseItem
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
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonBuy = new System.Windows.Forms.Button();
			this.userControlItems1 = new Legopoly.UserControlItems();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(694, 443);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Annuler";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonBuy
			// 
			this.buttonBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBuy.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonBuy.Location = new System.Drawing.Point(613, 443);
			this.buttonBuy.Name = "buttonBuy";
			this.buttonBuy.Size = new System.Drawing.Size(75, 23);
			this.buttonBuy.TabIndex = 2;
			this.buttonBuy.Text = "Acheter";
			this.buttonBuy.UseVisualStyleBackColor = true;
			// 
			// userControlItems1
			// 
			this.userControlItems1.Items = new Legopoly.Data.Items.ItemBase[0];
			this.userControlItems1.Location = new System.Drawing.Point(12, 12);
			this.userControlItems1.Name = "userControlItems1";
			this.userControlItems1.Size = new System.Drawing.Size(757, 426);
			this.userControlItems1.TabIndex = 4;
			// 
			// FormChooseItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(781, 478);
			this.Controls.Add(this.userControlItems1);
			this.Controls.Add(this.buttonBuy);
			this.Controls.Add(this.buttonCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormChooseItem";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Achat";
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonBuy;
		private UserControlItems userControlItems1;
	}
}