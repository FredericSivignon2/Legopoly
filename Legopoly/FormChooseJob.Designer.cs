namespace Legopoly
{
    partial class FormChooseJob
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
			this.listViewJobs = new System.Windows.Forms.ListView();
			this.labelDescription = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.pictureBoxJob = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJob)).BeginInit();
			this.SuspendLayout();
			// 
			// listViewJobs
			// 
			this.listViewJobs.FullRowSelect = true;
			this.listViewJobs.GridLines = true;
			this.listViewJobs.Location = new System.Drawing.Point(164, 29);
			this.listViewJobs.MultiSelect = false;
			this.listViewJobs.Name = "listViewJobs";
			this.listViewJobs.Size = new System.Drawing.Size(756, 403);
			this.listViewJobs.TabIndex = 0;
			this.listViewJobs.UseCompatibleStateImageBehavior = false;
			this.listViewJobs.View = System.Windows.Forms.View.Details;
			this.listViewJobs.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewJobs_ColumnClick);
			this.listViewJobs.SelectedIndexChanged += new System.EventHandler(this.listViewJobs_SelectedIndexChanged);
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(161, 13);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(761, 13);
			this.labelDescription.TabIndex = 1;
			this.labelDescription.Text = "Veuillez sélectionner un métier dans la liste des métiers suivante (Le contenu co" +
    "rrespondant aux choix possibles avec le nombre de points d\'expérience courant):";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(845, 438);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Annuler";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(764, 438);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// pictureBoxJob
			// 
			this.pictureBoxJob.Location = new System.Drawing.Point(13, 13);
			this.pictureBoxJob.Name = "pictureBoxJob";
			this.pictureBoxJob.Size = new System.Drawing.Size(128, 128);
			this.pictureBoxJob.TabIndex = 4;
			this.pictureBoxJob.TabStop = false;
			// 
			// FormChooseJob
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(932, 473);
			this.ControlBox = false;
			this.Controls.Add(this.pictureBoxJob);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.listViewJobs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormChooseJob";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Sélection d\'un Métier";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJob)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.ListView listViewJobs;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.PictureBox pictureBoxJob;
	}
}