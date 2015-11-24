namespace Legopoly
{
	partial class FormMission
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMission));
			this.labelMissionDescription = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelRound1 = new System.Windows.Forms.Label();
			this.labelRoundLeft = new System.Windows.Forms.Label();
			this.labelRound2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelGain = new System.Windows.Forms.Label();
			this.buttonMove = new System.Windows.Forms.Button();
			this.buttonSuccess = new System.Windows.Forms.Button();
			this.labelChoose = new System.Windows.Forms.Label();
			this.labelnotes = new System.Windows.Forms.Label();
			this.groupBoxData = new System.Windows.Forms.GroupBox();
			this.groupBoxMove = new System.Windows.Forms.GroupBox();
			this.listBoxVehicles = new System.Windows.Forms.ListBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBoxData.SuspendLayout();
			this.groupBoxMove.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelMissionDescription
			// 
			this.labelMissionDescription.Location = new System.Drawing.Point(6, 27);
			this.labelMissionDescription.Name = "labelMissionDescription";
			this.labelMissionDescription.Size = new System.Drawing.Size(578, 52);
			this.labelMissionDescription.TabIndex = 0;
			this.labelMissionDescription.Text = "-- Mission Description  --";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(769, 437);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(117, 23);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Annuler la Mission";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// labelRound1
			// 
			this.labelRound1.AutoSize = true;
			this.labelRound1.Location = new System.Drawing.Point(6, 91);
			this.labelRound1.Name = "labelRound1";
			this.labelRound1.Size = new System.Drawing.Size(50, 13);
			this.labelRound1.TabIndex = 6;
			this.labelRound1.Text = "Il te reste";
			// 
			// labelRoundLeft
			// 
			this.labelRoundLeft.AutoSize = true;
			this.labelRoundLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRoundLeft.Location = new System.Drawing.Point(58, 91);
			this.labelRoundLeft.Name = "labelRoundLeft";
			this.labelRoundLeft.Size = new System.Drawing.Size(19, 13);
			this.labelRoundLeft.TabIndex = 7;
			this.labelRoundLeft.Text = "---";
			// 
			// labelRound2
			// 
			this.labelRound2.AutoSize = true;
			this.labelRound2.Location = new System.Drawing.Point(81, 91);
			this.labelRound2.Name = "labelRound2";
			this.labelRound2.Size = new System.Drawing.Size(104, 13);
			this.labelRound2.TabIndex = 8;
			this.labelRound2.Text = "tour(s) de disponible.";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 117);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(231, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Si tu arrive à destination maintenant, tu gagnes:";
			// 
			// labelGain
			// 
			this.labelGain.AutoSize = true;
			this.labelGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGain.Location = new System.Drawing.Point(237, 117);
			this.labelGain.Name = "labelGain";
			this.labelGain.Size = new System.Drawing.Size(19, 13);
			this.labelGain.TabIndex = 10;
			this.labelGain.Text = "---";
			// 
			// buttonMove
			// 
			this.buttonMove.Image = global::Legopoly.Properties.Resources.dice_red;
			this.buttonMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonMove.Location = new System.Drawing.Point(625, 82);
			this.buttonMove.Name = "buttonMove";
			this.buttonMove.Size = new System.Drawing.Size(154, 70);
			this.buttonMove.TabIndex = 11;
			this.buttonMove.Text = "Se déplacer  ";
			this.buttonMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonMove.UseVisualStyleBackColor = true;
			this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonSuccess
			// 
			this.buttonSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSuccess.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonSuccess.Location = new System.Drawing.Point(646, 437);
			this.buttonSuccess.Name = "buttonSuccess";
			this.buttonSuccess.Size = new System.Drawing.Size(117, 23);
			this.buttonSuccess.TabIndex = 12;
			this.buttonSuccess.Text = "Mission Réussie";
			this.buttonSuccess.UseVisualStyleBackColor = true;
			this.buttonSuccess.Click += new System.EventHandler(this.buttonSuccess_Click);
			// 
			// labelChoose
			// 
			this.labelChoose.AutoSize = true;
			this.labelChoose.Location = new System.Drawing.Point(12, 27);
			this.labelChoose.Name = "labelChoose";
			this.labelChoose.Size = new System.Drawing.Size(173, 13);
			this.labelChoose.TabIndex = 13;
			this.labelChoose.Text = "Choisis un véhicule pour la mission:";
			// 
			// labelnotes
			// 
			this.labelnotes.AutoSize = true;
			this.labelnotes.Location = new System.Drawing.Point(6, 220);
			this.labelnotes.Name = "labelnotes";
			this.labelnotes.Size = new System.Drawing.Size(865, 26);
			this.labelnotes.TabIndex = 14;
			this.labelnotes.Text = resources.GetString("labelnotes.Text");
			// 
			// groupBoxData
			// 
			this.groupBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxData.Controls.Add(this.labelMissionDescription);
			this.groupBoxData.Controls.Add(this.labelRound1);
			this.groupBoxData.Controls.Add(this.labelRoundLeft);
			this.groupBoxData.Controls.Add(this.labelRound2);
			this.groupBoxData.Controls.Add(this.label1);
			this.groupBoxData.Controls.Add(this.labelGain);
			this.groupBoxData.Location = new System.Drawing.Point(12, 12);
			this.groupBoxData.Name = "groupBoxData";
			this.groupBoxData.Size = new System.Drawing.Size(871, 164);
			this.groupBoxData.TabIndex = 15;
			this.groupBoxData.TabStop = false;
			this.groupBoxData.Text = "Données de la Mission";
			// 
			// groupBoxMove
			// 
			this.groupBoxMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxMove.Controls.Add(this.pictureBox1);
			this.groupBoxMove.Controls.Add(this.listBoxVehicles);
			this.groupBoxMove.Controls.Add(this.labelChoose);
			this.groupBoxMove.Controls.Add(this.buttonMove);
			this.groupBoxMove.Controls.Add(this.labelnotes);
			this.groupBoxMove.Location = new System.Drawing.Point(12, 182);
			this.groupBoxMove.Name = "groupBoxMove";
			this.groupBoxMove.Size = new System.Drawing.Size(874, 249);
			this.groupBoxMove.TabIndex = 16;
			this.groupBoxMove.TabStop = false;
			this.groupBoxMove.Text = "Déplacements";
			// 
			// listBoxVehicles
			// 
			this.listBoxVehicles.FormattingEnabled = true;
			this.listBoxVehicles.Location = new System.Drawing.Point(15, 44);
			this.listBoxVehicles.Name = "listBoxVehicles";
			this.listBoxVehicles.Size = new System.Drawing.Size(241, 147);
			this.listBoxVehicles.TabIndex = 15;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(263, 44);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 150);
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// FormMission
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 472);
			this.ControlBox = false;
			this.Controls.Add(this.groupBoxMove);
			this.Controls.Add(this.groupBoxData);
			this.Controls.Add(this.buttonSuccess);
			this.Controls.Add(this.buttonCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMission";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Mission";
			this.groupBoxData.ResumeLayout(false);
			this.groupBoxData.PerformLayout();
			this.groupBoxMove.ResumeLayout(false);
			this.groupBoxMove.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelMissionDescription;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelRound1;
		private System.Windows.Forms.Label labelRoundLeft;
		private System.Windows.Forms.Label labelRound2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelGain;
		private System.Windows.Forms.Button buttonMove;
		private System.Windows.Forms.Button buttonSuccess;
		private System.Windows.Forms.Label labelChoose;
		private System.Windows.Forms.Label labelnotes;
		private System.Windows.Forms.GroupBox groupBoxData;
		private System.Windows.Forms.GroupBox groupBoxMove;
		private System.Windows.Forms.ListBox listBoxVehicles;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}