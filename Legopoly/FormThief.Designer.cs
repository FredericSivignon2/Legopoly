namespace Legopoly
{
	partial class FormThief
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThief));
			this.labelNotes = new System.Windows.Forms.Label();
			this.labelSelection = new System.Windows.Forms.Label();
			this.labelType = new System.Windows.Forms.Label();
			this.comboBoxThiefType = new System.Windows.Forms.ComboBox();
			this.userControlItems1 = new Legopoly.UserControlItems();
			this.buttonThief = new System.Windows.Forms.Button();
			this.labelDescription = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelNotes
			// 
			this.labelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNotes.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelNotes.Location = new System.Drawing.Point(13, 13);
			this.labelNotes.Name = "labelNotes";
			this.labelNotes.Size = new System.Drawing.Size(703, 134);
			this.labelNotes.TabIndex = 0;
			this.labelNotes.Text = resources.GetString("labelNotes.Text");
			// 
			// labelSelection
			// 
			this.labelSelection.AutoSize = true;
			this.labelSelection.Location = new System.Drawing.Point(16, 129);
			this.labelSelection.Name = "labelSelection";
			this.labelSelection.Size = new System.Drawing.Size(195, 13);
			this.labelSelection.TabIndex = 1;
			this.labelSelection.Text = "Sélectionnes l\'endroit que tu veux voler:";
			// 
			// labelType
			// 
			this.labelType.AutoSize = true;
			this.labelType.Location = new System.Drawing.Point(16, 66);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(241, 13);
			this.labelType.TabIndex = 3;
			this.labelType.Text = "Sélectionnes le type de vol que tu veux perpétrer:";
			// 
			// comboBoxThiefType
			// 
			this.comboBoxThiefType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxThiefType.FormattingEnabled = true;
			this.comboBoxThiefType.Location = new System.Drawing.Point(16, 82);
			this.comboBoxThiefType.Name = "comboBoxThiefType";
			this.comboBoxThiefType.Size = new System.Drawing.Size(293, 21);
			this.comboBoxThiefType.TabIndex = 4;
			this.comboBoxThiefType.SelectedIndexChanged += new System.EventHandler(this.comboBoxThiefType_SelectedIndexChanged);
			// 
			// userControlItems2
			// 
			this.userControlItems1.Items = new Legopoly.Data.Items.ItemBase[0];
			this.userControlItems1.Location = new System.Drawing.Point(16, 145);
			this.userControlItems1.Name = "userControlItems2";
			this.userControlItems1.Size = new System.Drawing.Size(700, 398);
			this.userControlItems1.TabIndex = 5;
			// 
			// buttonThief
			// 
			this.buttonThief.Image = global::Legopoly.Properties.Resources.robber;
			this.buttonThief.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonThief.Location = new System.Drawing.Point(512, 549);
			this.buttonThief.Name = "buttonThief";
			this.buttonThief.Size = new System.Drawing.Size(201, 83);
			this.buttonThief.TabIndex = 6;
			this.buttonThief.Text = "    Voler !";
			this.buttonThief.UseVisualStyleBackColor = true;
			// 
			// labelDescription
			// 
			this.labelDescription.Location = new System.Drawing.Point(315, 82);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(398, 46);
			this.labelDescription.TabIndex = 7;
			this.labelDescription.Text = "Description...";
			// 
			// FormThief
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 644);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.buttonThief);
			this.Controls.Add(this.userControlItems1);
			this.Controls.Add(this.comboBoxThiefType);
			this.Controls.Add(this.labelType);
			this.Controls.Add(this.labelSelection);
			this.Controls.Add(this.labelNotes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormThief";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Voler";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelNotes;
		private System.Windows.Forms.Label labelSelection;
		private UserControlItems userControlItems1;
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.ComboBox comboBoxThiefType;
		private System.Windows.Forms.Button buttonThief;
		private System.Windows.Forms.Label labelDescription;
	}
}