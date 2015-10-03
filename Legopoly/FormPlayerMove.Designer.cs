namespace Legopoly
{
	partial class FormPlayerMove
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
			this.radioButtonFoot = new System.Windows.Forms.RadioButton();
			this.radioButtonVehicle = new System.Windows.Forms.RadioButton();
			this.comboBoxVehicles = new System.Windows.Forms.ComboBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// radioButtonFoot
			// 
			this.radioButtonFoot.AutoSize = true;
			this.radioButtonFoot.Location = new System.Drawing.Point(13, 13);
			this.radioButtonFoot.Name = "radioButtonFoot";
			this.radioButtonFoot.Size = new System.Drawing.Size(114, 17);
			this.radioButtonFoot.TabIndex = 0;
			this.radioButtonFoot.TabStop = true;
			this.radioButtonFoot.Text = "Se déplacer à pied";
			this.radioButtonFoot.UseVisualStyleBackColor = true;
			this.radioButtonFoot.CheckedChanged += new System.EventHandler(this.radioButtonFoot_CheckedChanged);
			// 
			// radioButtonVehicle
			// 
			this.radioButtonVehicle.AutoSize = true;
			this.radioButtonVehicle.Location = new System.Drawing.Point(13, 36);
			this.radioButtonVehicle.Name = "radioButtonVehicle";
			this.radioButtonVehicle.Size = new System.Drawing.Size(117, 17);
			this.radioButtonVehicle.TabIndex = 1;
			this.radioButtonVehicle.TabStop = true;
			this.radioButtonVehicle.Text = "Utiliser un véhicule:";
			this.radioButtonVehicle.UseVisualStyleBackColor = true;
			this.radioButtonVehicle.CheckedChanged += new System.EventHandler(this.radioButtonVehicle_CheckedChanged);
			// 
			// comboBoxVehicles
			// 
			this.comboBoxVehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVehicles.FormattingEnabled = true;
			this.comboBoxVehicles.Location = new System.Drawing.Point(39, 59);
			this.comboBoxVehicles.Name = "comboBoxVehicles";
			this.comboBoxVehicles.Size = new System.Drawing.Size(508, 21);
			this.comboBoxVehicles.TabIndex = 2;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(471, 109);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Annuler";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(390, 109);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// FormPlayerMove
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 144);
			this.ControlBox = false;
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.comboBoxVehicles);
			this.Controls.Add(this.radioButtonVehicle);
			this.Controls.Add(this.radioButtonFoot);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormPlayerMove";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Déplacement";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton radioButtonFoot;
		private System.Windows.Forms.RadioButton radioButtonVehicle;
		private System.Windows.Forms.ComboBox comboBoxVehicles;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
	}
}