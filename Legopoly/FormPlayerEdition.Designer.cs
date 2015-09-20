namespace Legopoly
{
    partial class FormPlayerEdition
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCapital = new System.Windows.Forms.TextBox();
            this.labelCapital = new System.Windows.Forms.Label();
            this.labelEuros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownScientific = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEmpathy = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownCreativity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownManagement = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownPhysicalFitness = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxExperiences = new System.Windows.Forms.GroupBox();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMaxPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScientific)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmpathy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreativity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhysicalFitness)).BeginInit();
            this.groupBoxExperiences.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nom:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(91, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(275, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxCapital
            // 
            this.textBoxCapital.Location = new System.Drawing.Point(91, 52);
            this.textBoxCapital.Name = "textBoxCapital";
            this.textBoxCapital.ReadOnly = true;
            this.textBoxCapital.Size = new System.Drawing.Size(79, 20);
            this.textBoxCapital.TabIndex = 3;
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Location = new System.Drawing.Point(6, 55);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(42, 13);
            this.labelCapital.TabIndex = 2;
            this.labelCapital.Text = "Capital:";
            // 
            // labelEuros
            // 
            this.labelEuros.AutoSize = true;
            this.labelEuros.Location = new System.Drawing.Point(176, 55);
            this.labelEuros.Name = "labelEuros";
            this.labelEuros.Size = new System.Drawing.Size(13, 13);
            this.labelEuros.TabIndex = 5;
            this.labelEuros.Text = "€";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Scientifique:";
            // 
            // numericUpDownScientific
            // 
            this.numericUpDownScientific.Location = new System.Drawing.Point(140, 71);
            this.numericUpDownScientific.Name = "numericUpDownScientific";
            this.numericUpDownScientific.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownScientific.TabIndex = 7;
            this.numericUpDownScientific.ValueChanged += new System.EventHandler(this.numericUpDownScientific_ValueChanged);
            this.numericUpDownScientific.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDownScientific_Validating);
            // 
            // numericUpDownEmpathy
            // 
            this.numericUpDownEmpathy.Location = new System.Drawing.Point(140, 175);
            this.numericUpDownEmpathy.Name = "numericUpDownEmpathy";
            this.numericUpDownEmpathy.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownEmpathy.TabIndex = 9;
            this.numericUpDownEmpathy.ValueChanged += new System.EventHandler(this.numericUpDownEmpathy_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Empathie:";
            // 
            // numericUpDownCreativity
            // 
            this.numericUpDownCreativity.Location = new System.Drawing.Point(140, 149);
            this.numericUpDownCreativity.Name = "numericUpDownCreativity";
            this.numericUpDownCreativity.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownCreativity.TabIndex = 11;
            this.numericUpDownCreativity.ValueChanged += new System.EventHandler(this.numericUpDownCreativity_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Créativité:";
            // 
            // numericUpDownManagement
            // 
            this.numericUpDownManagement.Location = new System.Drawing.Point(140, 123);
            this.numericUpDownManagement.Name = "numericUpDownManagement";
            this.numericUpDownManagement.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownManagement.TabIndex = 13;
            this.numericUpDownManagement.ValueChanged += new System.EventHandler(this.numericUpDownManagement_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Aptitudes au management:";
            // 
            // numericUpDownPhysicalFitness
            // 
            this.numericUpDownPhysicalFitness.Location = new System.Drawing.Point(140, 97);
            this.numericUpDownPhysicalFitness.Name = "numericUpDownPhysicalFitness";
            this.numericUpDownPhysicalFitness.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownPhysicalFitness.TabIndex = 15;
            this.numericUpDownPhysicalFitness.ValueChanged += new System.EventHandler(this.numericUpDownPhysicalFitness_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Aptitudes physiques:";
            // 
            // groupBoxExperiences
            // 
            this.groupBoxExperiences.Controls.Add(this.labelMaxPoints);
            this.groupBoxExperiences.Controls.Add(this.label1);
            this.groupBoxExperiences.Controls.Add(this.numericUpDownPhysicalFitness);
            this.groupBoxExperiences.Controls.Add(this.numericUpDownScientific);
            this.groupBoxExperiences.Controls.Add(this.label5);
            this.groupBoxExperiences.Controls.Add(this.label2);
            this.groupBoxExperiences.Controls.Add(this.numericUpDownManagement);
            this.groupBoxExperiences.Controls.Add(this.numericUpDownEmpathy);
            this.groupBoxExperiences.Controls.Add(this.label4);
            this.groupBoxExperiences.Controls.Add(this.label3);
            this.groupBoxExperiences.Controls.Add(this.numericUpDownCreativity);
            this.groupBoxExperiences.Location = new System.Drawing.Point(13, 107);
            this.groupBoxExperiences.Name = "groupBoxExperiences";
            this.groupBoxExperiences.Size = new System.Drawing.Size(394, 228);
            this.groupBoxExperiences.TabIndex = 16;
            this.groupBoxExperiences.TabStop = false;
            this.groupBoxExperiences.Text = "Points d\'expériences";
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.labelName);
            this.groupBoxGeneral.Controls.Add(this.textBoxName);
            this.groupBoxGeneral.Controls.Add(this.labelEuros);
            this.groupBoxGeneral.Controls.Add(this.labelCapital);
            this.groupBoxGeneral.Controls.Add(this.textBoxCapital);
            this.groupBoxGeneral.Location = new System.Drawing.Point(13, 13);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(394, 88);
            this.groupBoxGeneral.TabIndex = 17;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "Genéral";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(252, 342);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 18;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(333, 341);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelMaxPoints
            // 
            this.labelMaxPoints.AutoSize = true;
            this.labelMaxPoints.Location = new System.Drawing.Point(6, 39);
            this.labelMaxPoints.Name = "labelMaxPoints";
            this.labelMaxPoints.Size = new System.Drawing.Size(192, 13);
            this.labelMaxPoints.TabIndex = 16;
            this.labelMaxPoints.Text = "Tu as {0} points d\'expérience à répartir:";
            // 
            // FormPlayerEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 376);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxGeneral);
            this.Controls.Add(this.groupBoxExperiences);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlayerEdition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edition d\'un joueur";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScientific)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmpathy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreativity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhysicalFitness)).EndInit();
            this.groupBoxExperiences.ResumeLayout(false);
            this.groupBoxExperiences.PerformLayout();
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCapital;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.Label labelEuros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownScientific;
        private System.Windows.Forms.NumericUpDown numericUpDownEmpathy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownCreativity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownManagement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownPhysicalFitness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxExperiences;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMaxPoints;
    }
}