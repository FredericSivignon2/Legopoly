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
			this.SuspendLayout();
			// 
			// listViewJobs
			// 
			this.listViewJobs.Location = new System.Drawing.Point(16, 29);
			this.listViewJobs.Name = "listViewJobs";
			this.listViewJobs.Size = new System.Drawing.Size(756, 270);
			this.listViewJobs.TabIndex = 0;
			this.listViewJobs.UseCompatibleStateImageBehavior = false;
			this.listViewJobs.View = System.Windows.Forms.View.Details;
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(13, 13);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(761, 13);
			this.labelDescription.TabIndex = 1;
			this.labelDescription.Text = "Veuillez sélectionner un métier dans la liste des métiers suivante (Le contenu co" +
    "rrespondant aux choix possibles avec le nombre de points d\'expérience courant):";
			// 
			// FormChooseJob
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 473);
			this.ControlBox = false;
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.listViewJobs);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormChooseJob";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Sélection d\'un Métier";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.ListView listViewJobs;
		private System.Windows.Forms.Label labelDescription;
	}
}