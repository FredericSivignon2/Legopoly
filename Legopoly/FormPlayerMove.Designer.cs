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
			this.buttonRefuel = new System.Windows.Forms.Button();
			this.labelRefuel = new System.Windows.Forms.Label();
			this.labelTank = new System.Windows.Forms.Label();
			this.panelTankLevel = new System.Windows.Forms.Panel();
			this.labelTankLevelComment = new System.Windows.Forms.Label();
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
			this.comboBoxVehicles.SelectedIndexChanged += new System.EventHandler(this.comboBoxVehicles_SelectedIndexChanged);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(474, 313);
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
			this.buttonOK.Location = new System.Drawing.Point(393, 313);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonRefuel
			// 
			this.buttonRefuel.Image = global::Legopoly.Properties.Resources.fuel_dispenser;
			this.buttonRefuel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonRefuel.Location = new System.Drawing.Point(39, 152);
			this.buttonRefuel.Name = "buttonRefuel";
			this.buttonRefuel.Size = new System.Drawing.Size(75, 100);
			this.buttonRefuel.TabIndex = 5;
			this.buttonRefuel.Text = "Faire le plein d\'essence";
			this.buttonRefuel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonRefuel.UseVisualStyleBackColor = true;
			this.buttonRefuel.Click += new System.EventHandler(this.buttonRefuel_Click);
			// 
			// labelRefuel
			// 
			this.labelRefuel.AutoSize = true;
			this.labelRefuel.Location = new System.Drawing.Point(121, 153);
			this.labelRefuel.Name = "labelRefuel";
			this.labelRefuel.Size = new System.Drawing.Size(51, 13);
			this.labelRefuel.TabIndex = 6;
			this.labelRefuel.Text = "-- refuel --";
			// 
			// labelTank
			// 
			this.labelTank.AutoSize = true;
			this.labelTank.Location = new System.Drawing.Point(39, 87);
			this.labelTank.Name = "labelTank";
			this.labelTank.Size = new System.Drawing.Size(55, 13);
			this.labelTank.TabIndex = 7;
			this.labelTank.Text = "Réservoir:";
			// 
			// panelTankLevel
			// 
			this.panelTankLevel.BackColor = System.Drawing.Color.Silver;
			this.panelTankLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelTankLevel.Location = new System.Drawing.Point(100, 85);
			this.panelTankLevel.Name = "panelTankLevel";
			this.panelTankLevel.Size = new System.Drawing.Size(446, 22);
			this.panelTankLevel.TabIndex = 8;
			this.panelTankLevel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTankLevel_Paint);
			// 
			// labelTankLevelComment
			// 
			this.labelTankLevelComment.AutoSize = true;
			this.labelTankLevelComment.Location = new System.Drawing.Point(42, 120);
			this.labelTankLevelComment.Name = "labelTankLevelComment";
			this.labelTankLevelComment.Size = new System.Drawing.Size(172, 13);
			this.labelTankLevelComment.TabIndex = 9;
			this.labelTankLevelComment.Text = "-- Commentaire niveau d\'essence --";
			// 
			// FormPlayerMove
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 348);
			this.ControlBox = false;
			this.Controls.Add(this.labelTankLevelComment);
			this.Controls.Add(this.panelTankLevel);
			this.Controls.Add(this.labelTank);
			this.Controls.Add(this.labelRefuel);
			this.Controls.Add(this.buttonRefuel);
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
		private System.Windows.Forms.Button buttonRefuel;
		private System.Windows.Forms.Label labelRefuel;
		private System.Windows.Forms.Label labelTank;
		private System.Windows.Forms.Panel panelTankLevel;
		private System.Windows.Forms.Label labelTankLevelComment;
	}
}