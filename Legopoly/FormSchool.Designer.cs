namespace Legopoly
{
	partial class FormSchool
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchool));
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxCourses = new System.Windows.Forms.ComboBox();
			this.labelPrice = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxEmpathy = new System.Windows.Forms.TextBox();
			this.textBoxScientific = new System.Windows.Forms.TextBox();
			this.textBoxCreativity = new System.Windows.Forms.TextBox();
			this.textBoxFitness = new System.Windows.Forms.TextBox();
			this.textBoxManagement = new System.Windows.Forms.TextBox();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.labelEUuros = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(453, 291);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 6;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(534, 291);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Annuler";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Legopoly.Properties.Resources.school_32;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(194, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Choisis le cours auquel tu veux assister:";
			// 
			// comboBoxCourses
			// 
			this.comboBoxCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCourses.FormattingEnabled = true;
			this.comboBoxCourses.Location = new System.Drawing.Point(54, 58);
			this.comboBoxCourses.Name = "comboBoxCourses";
			this.comboBoxCourses.Size = new System.Drawing.Size(555, 21);
			this.comboBoxCourses.TabIndex = 9;
			this.comboBoxCourses.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourses_SelectedIndexChanged);
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(54, 96);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(27, 13);
			this.labelPrice.TabIndex = 10;
			this.labelPrice.Text = "Prix:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(54, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 25;
			this.label2.Text = "Scientifique:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(54, 202);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 27;
			this.label3.Text = "Créativité:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(54, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 13);
			this.label4.TabIndex = 28;
			this.label4.Text = "Management:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(54, 228);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "Empathie:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(54, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 29;
			this.label6.Text = "Physiques:";
			// 
			// textBoxEmpathy
			// 
			this.textBoxEmpathy.Location = new System.Drawing.Point(157, 225);
			this.textBoxEmpathy.Name = "textBoxEmpathy";
			this.textBoxEmpathy.ReadOnly = true;
			this.textBoxEmpathy.Size = new System.Drawing.Size(77, 20);
			this.textBoxEmpathy.TabIndex = 34;
			// 
			// textBoxScientific
			// 
			this.textBoxScientific.Location = new System.Drawing.Point(157, 121);
			this.textBoxScientific.Name = "textBoxScientific";
			this.textBoxScientific.ReadOnly = true;
			this.textBoxScientific.Size = new System.Drawing.Size(77, 20);
			this.textBoxScientific.TabIndex = 30;
			// 
			// textBoxCreativity
			// 
			this.textBoxCreativity.Location = new System.Drawing.Point(157, 199);
			this.textBoxCreativity.Name = "textBoxCreativity";
			this.textBoxCreativity.ReadOnly = true;
			this.textBoxCreativity.Size = new System.Drawing.Size(77, 20);
			this.textBoxCreativity.TabIndex = 33;
			// 
			// textBoxFitness
			// 
			this.textBoxFitness.Location = new System.Drawing.Point(157, 173);
			this.textBoxFitness.Name = "textBoxFitness";
			this.textBoxFitness.ReadOnly = true;
			this.textBoxFitness.Size = new System.Drawing.Size(77, 20);
			this.textBoxFitness.TabIndex = 31;
			// 
			// textBoxManagement
			// 
			this.textBoxManagement.Location = new System.Drawing.Point(157, 147);
			this.textBoxManagement.Name = "textBoxManagement";
			this.textBoxManagement.ReadOnly = true;
			this.textBoxManagement.Size = new System.Drawing.Size(77, 20);
			this.textBoxManagement.TabIndex = 32;
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(157, 95);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.ReadOnly = true;
			this.textBoxPrice.Size = new System.Drawing.Size(77, 20);
			this.textBoxPrice.TabIndex = 35;
			// 
			// labelEUuros
			// 
			this.labelEUuros.AutoSize = true;
			this.labelEUuros.Location = new System.Drawing.Point(238, 99);
			this.labelEUuros.Name = "labelEUuros";
			this.labelEUuros.Size = new System.Drawing.Size(13, 13);
			this.labelEUuros.TabIndex = 36;
			this.labelEUuros.Text = "€";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(54, 13);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(316, 13);
			this.label7.TabIndex = 37;
			this.label7.Text = "Tu dois te trouver à l\'Université pour pouvoir participer aux cours !";
			// 
			// FormSchool
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 326);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.labelEUuros);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxEmpathy);
			this.Controls.Add(this.textBoxScientific);
			this.Controls.Add(this.textBoxCreativity);
			this.Controls.Add(this.textBoxFitness);
			this.Controls.Add(this.textBoxManagement);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.comboBoxCourses);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormSchool";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Université";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxCourses;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxEmpathy;
		private System.Windows.Forms.TextBox textBoxScientific;
		private System.Windows.Forms.TextBox textBoxCreativity;
		private System.Windows.Forms.TextBox textBoxFitness;
		private System.Windows.Forms.TextBox textBoxManagement;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Label labelEUuros;
		private System.Windows.Forms.Label label7;
	}
}