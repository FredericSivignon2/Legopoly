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
			this.labelMissionDescription = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelRound1 = new System.Windows.Forms.Label();
			this.labelRoundLeft = new System.Windows.Forms.Label();
			this.labelRound2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelGain = new System.Windows.Forms.Label();
			this.buttonMove = new System.Windows.Forms.Button();
			this.buttonSuccess = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelMissionDescription
			// 
			this.labelMissionDescription.Location = new System.Drawing.Point(12, 9);
			this.labelMissionDescription.Name = "labelMissionDescription";
			this.labelMissionDescription.Size = new System.Drawing.Size(578, 52);
			this.labelMissionDescription.TabIndex = 0;
			this.labelMissionDescription.Text = "-- Mission Description  --";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(473, 290);
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
			this.labelRound1.Location = new System.Drawing.Point(12, 73);
			this.labelRound1.Name = "labelRound1";
			this.labelRound1.Size = new System.Drawing.Size(50, 13);
			this.labelRound1.TabIndex = 6;
			this.labelRound1.Text = "Il te reste";
			// 
			// labelRoundLeft
			// 
			this.labelRoundLeft.AutoSize = true;
			this.labelRoundLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRoundLeft.Location = new System.Drawing.Point(64, 73);
			this.labelRoundLeft.Name = "labelRoundLeft";
			this.labelRoundLeft.Size = new System.Drawing.Size(19, 13);
			this.labelRoundLeft.TabIndex = 7;
			this.labelRoundLeft.Text = "---";
			// 
			// labelRound2
			// 
			this.labelRound2.AutoSize = true;
			this.labelRound2.Location = new System.Drawing.Point(87, 73);
			this.labelRound2.Name = "labelRound2";
			this.labelRound2.Size = new System.Drawing.Size(104, 13);
			this.labelRound2.TabIndex = 8;
			this.labelRound2.Text = "tour(s) de disponible.";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(231, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Si tu arrive à destination maintenant, tu gagnes:";
			// 
			// labelGain
			// 
			this.labelGain.AutoSize = true;
			this.labelGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGain.Location = new System.Drawing.Point(243, 99);
			this.labelGain.Name = "labelGain";
			this.labelGain.Size = new System.Drawing.Size(19, 13);
			this.labelGain.TabIndex = 10;
			this.labelGain.Text = "---";
			// 
			// buttonMove
			// 
			this.buttonMove.Image = global::Legopoly.Properties.Resources.dice_red;
			this.buttonMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonMove.Location = new System.Drawing.Point(225, 166);
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
			this.buttonSuccess.Location = new System.Drawing.Point(350, 290);
			this.buttonSuccess.Name = "buttonSuccess";
			this.buttonSuccess.Size = new System.Drawing.Size(117, 23);
			this.buttonSuccess.TabIndex = 12;
			this.buttonSuccess.Text = "Mission Réussie";
			this.buttonSuccess.UseVisualStyleBackColor = true;
			// 
			// FormMission
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 325);
			this.ControlBox = false;
			this.Controls.Add(this.buttonSuccess);
			this.Controls.Add(this.buttonMove);
			this.Controls.Add(this.labelGain);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelRound2);
			this.Controls.Add(this.labelRoundLeft);
			this.Controls.Add(this.labelRound1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.labelMissionDescription);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMission";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Mission";
			this.ResumeLayout(false);
			this.PerformLayout();

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
	}
}