namespace Legopoly
{
    partial class FormPlay
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
			this.listViewHeritage = new System.Windows.Forms.ListView();
			this.groupBoxHeritage = new System.Windows.Forms.GroupBox();
			this.buttonSoldItem = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonBuyItem = new System.Windows.Forms.Button();
			this.labelCapital = new System.Windows.Forms.Label();
			this.groupBoxIdentification = new System.Windows.Forms.GroupBox();
			this.labelGrade = new System.Windows.Forms.Label();
			this.buttonChangeJob = new System.Windows.Forms.Button();
			this.pictureBoxJob = new System.Windows.Forms.PictureBox();
			this.textBoxEmpathy = new System.Windows.Forms.TextBox();
			this.textBoxCreativity = new System.Windows.Forms.TextBox();
			this.textBoxManagement = new System.Windows.Forms.TextBox();
			this.textBoxFitness = new System.Windows.Forms.TextBox();
			this.textBoxScientific = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonMove = new System.Windows.Forms.Button();
			this.buttonNextPlayer = new System.Windows.Forms.Button();
			this.buttonStopGame = new System.Windows.Forms.Button();
			this.groupBoxHeritage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBoxIdentification.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJob)).BeginInit();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.Location = new System.Drawing.Point(6, 17);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(161, 42);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Frédéric";
			// 
			// listViewHeritage
			// 
			this.listViewHeritage.Location = new System.Drawing.Point(6, 81);
			this.listViewHeritage.Name = "listViewHeritage";
			this.listViewHeritage.Size = new System.Drawing.Size(972, 267);
			this.listViewHeritage.TabIndex = 1;
			this.listViewHeritage.UseCompatibleStateImageBehavior = false;
			this.listViewHeritage.View = System.Windows.Forms.View.Details;
			// 
			// groupBoxHeritage
			// 
			this.groupBoxHeritage.Controls.Add(this.buttonSoldItem);
			this.groupBoxHeritage.Controls.Add(this.pictureBox1);
			this.groupBoxHeritage.Controls.Add(this.buttonBuyItem);
			this.groupBoxHeritage.Controls.Add(this.listViewHeritage);
			this.groupBoxHeritage.Controls.Add(this.labelCapital);
			this.groupBoxHeritage.Location = new System.Drawing.Point(12, 287);
			this.groupBoxHeritage.Name = "groupBoxHeritage";
			this.groupBoxHeritage.Size = new System.Drawing.Size(984, 354);
			this.groupBoxHeritage.TabIndex = 2;
			this.groupBoxHeritage.TabStop = false;
			this.groupBoxHeritage.Text = "Patrimoine";
			// 
			// buttonSoldItem
			// 
			this.buttonSoldItem.Location = new System.Drawing.Point(88, 24);
			this.buttonSoldItem.Name = "buttonSoldItem";
			this.buttonSoldItem.Size = new System.Drawing.Size(75, 23);
			this.buttonSoldItem.TabIndex = 3;
			this.buttonSoldItem.Text = "Vendre";
			this.buttonSoldItem.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Legopoly.Properties.Resources.money;
			this.pictureBox1.Location = new System.Drawing.Point(670, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// buttonBuyItem
			// 
			this.buttonBuyItem.Location = new System.Drawing.Point(7, 24);
			this.buttonBuyItem.Name = "buttonBuyItem";
			this.buttonBuyItem.Size = new System.Drawing.Size(75, 23);
			this.buttonBuyItem.TabIndex = 2;
			this.buttonBuyItem.Text = "Acheter";
			this.buttonBuyItem.UseVisualStyleBackColor = true;
			this.buttonBuyItem.Click += new System.EventHandler(this.buttonBuyItem_Click);
			// 
			// labelCapital
			// 
			this.labelCapital.AutoSize = true;
			this.labelCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCapital.Location = new System.Drawing.Point(740, 33);
			this.labelCapital.Name = "labelCapital";
			this.labelCapital.Size = new System.Drawing.Size(156, 31);
			this.labelCapital.TabIndex = 5;
			this.labelCapital.Text = "-- capital --";
			// 
			// groupBoxIdentification
			// 
			this.groupBoxIdentification.Controls.Add(this.labelGrade);
			this.groupBoxIdentification.Controls.Add(this.buttonChangeJob);
			this.groupBoxIdentification.Controls.Add(this.pictureBoxJob);
			this.groupBoxIdentification.Controls.Add(this.textBoxEmpathy);
			this.groupBoxIdentification.Controls.Add(this.textBoxCreativity);
			this.groupBoxIdentification.Controls.Add(this.labelName);
			this.groupBoxIdentification.Controls.Add(this.textBoxManagement);
			this.groupBoxIdentification.Controls.Add(this.textBoxFitness);
			this.groupBoxIdentification.Controls.Add(this.textBoxScientific);
			this.groupBoxIdentification.Controls.Add(this.label1);
			this.groupBoxIdentification.Controls.Add(this.label5);
			this.groupBoxIdentification.Controls.Add(this.label2);
			this.groupBoxIdentification.Controls.Add(this.label4);
			this.groupBoxIdentification.Controls.Add(this.label3);
			this.groupBoxIdentification.Location = new System.Drawing.Point(12, 12);
			this.groupBoxIdentification.Name = "groupBoxIdentification";
			this.groupBoxIdentification.Size = new System.Drawing.Size(984, 269);
			this.groupBoxIdentification.TabIndex = 6;
			this.groupBoxIdentification.TabStop = false;
			this.groupBoxIdentification.Text = "Carte d\'identité";
			// 
			// labelGrade
			// 
			this.labelGrade.AutoSize = true;
			this.labelGrade.Location = new System.Drawing.Point(13, 209);
			this.labelGrade.Name = "labelGrade";
			this.labelGrade.Size = new System.Drawing.Size(52, 13);
			this.labelGrade.TabIndex = 27;
			this.labelGrade.Text = "-- grade --";
			// 
			// buttonChangeJob
			// 
			this.buttonChangeJob.Location = new System.Drawing.Point(661, 36);
			this.buttonChangeJob.Name = "buttonChangeJob";
			this.buttonChangeJob.Size = new System.Drawing.Size(118, 23);
			this.buttonChangeJob.TabIndex = 26;
			this.buttonChangeJob.Text = "Changer de métier";
			this.buttonChangeJob.UseVisualStyleBackColor = true;
			this.buttonChangeJob.Click += new System.EventHandler(this.buttonChangeJob_Click);
			// 
			// pictureBoxJob
			// 
			this.pictureBoxJob.Image = global::Legopoly.Properties.Resources.policeman_usa;
			this.pictureBoxJob.Location = new System.Drawing.Point(13, 69);
			this.pictureBoxJob.Name = "pictureBoxJob";
			this.pictureBoxJob.Size = new System.Drawing.Size(128, 128);
			this.pictureBoxJob.TabIndex = 25;
			this.pictureBoxJob.TabStop = false;
			// 
			// textBoxEmpathy
			// 
			this.textBoxEmpathy.Location = new System.Drawing.Point(665, 203);
			this.textBoxEmpathy.Name = "textBoxEmpathy";
			this.textBoxEmpathy.ReadOnly = true;
			this.textBoxEmpathy.Size = new System.Drawing.Size(77, 20);
			this.textBoxEmpathy.TabIndex = 24;
			// 
			// textBoxCreativity
			// 
			this.textBoxCreativity.Location = new System.Drawing.Point(665, 177);
			this.textBoxCreativity.Name = "textBoxCreativity";
			this.textBoxCreativity.ReadOnly = true;
			this.textBoxCreativity.Size = new System.Drawing.Size(77, 20);
			this.textBoxCreativity.TabIndex = 23;
			// 
			// textBoxManagement
			// 
			this.textBoxManagement.Location = new System.Drawing.Point(665, 151);
			this.textBoxManagement.Name = "textBoxManagement";
			this.textBoxManagement.ReadOnly = true;
			this.textBoxManagement.Size = new System.Drawing.Size(77, 20);
			this.textBoxManagement.TabIndex = 22;
			// 
			// textBoxFitness
			// 
			this.textBoxFitness.Location = new System.Drawing.Point(665, 125);
			this.textBoxFitness.Name = "textBoxFitness";
			this.textBoxFitness.ReadOnly = true;
			this.textBoxFitness.Size = new System.Drawing.Size(77, 20);
			this.textBoxFitness.TabIndex = 21;
			// 
			// textBoxScientific
			// 
			this.textBoxScientific.Location = new System.Drawing.Point(665, 99);
			this.textBoxScientific.Name = "textBoxScientific";
			this.textBoxScientific.ReadOnly = true;
			this.textBoxScientific.Size = new System.Drawing.Size(77, 20);
			this.textBoxScientific.TabIndex = 20;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(562, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Points Scientifique:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(562, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 13);
			this.label5.TabIndex = 19;
			this.label5.Text = "Points Physiques:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(562, 206);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Points Empathie:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(562, 154);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "Points Management:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(562, 180);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Points Créativité:";
			// 
			// buttonMove
			// 
			this.buttonMove.Image = global::Legopoly.Properties.Resources.nav_right_green;
			this.buttonMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonMove.Location = new System.Drawing.Point(12, 647);
			this.buttonMove.Name = "buttonMove";
			this.buttonMove.Size = new System.Drawing.Size(154, 70);
			this.buttonMove.TabIndex = 0;
			this.buttonMove.Text = "Se déplacer";
			this.buttonMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonMove.UseVisualStyleBackColor = true;
			// 
			// buttonNextPlayer
			// 
			this.buttonNextPlayer.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonNextPlayer.Image = global::Legopoly.Properties.Resources.ok;
			this.buttonNextPlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonNextPlayer.Location = new System.Drawing.Point(682, 647);
			this.buttonNextPlayer.Name = "buttonNextPlayer";
			this.buttonNextPlayer.Size = new System.Drawing.Size(154, 70);
			this.buttonNextPlayer.TabIndex = 3;
			this.buttonNextPlayer.Text = "Tour OK";
			this.buttonNextPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonNextPlayer.UseVisualStyleBackColor = true;
			// 
			// buttonStopGame
			// 
			this.buttonStopGame.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonStopGame.Image = global::Legopoly.Properties.Resources.sign_stop;
			this.buttonStopGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonStopGame.Location = new System.Drawing.Point(842, 647);
			this.buttonStopGame.Name = "buttonStopGame";
			this.buttonStopGame.Size = new System.Drawing.Size(154, 70);
			this.buttonStopGame.TabIndex = 4;
			this.buttonStopGame.Text = "Arrêter la partie";
			this.buttonStopGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonStopGame.UseVisualStyleBackColor = true;
			// 
			// FormPlay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.buttonMove);
			this.Controls.Add(this.buttonNextPlayer);
			this.Controls.Add(this.buttonStopGame);
			this.Controls.Add(this.groupBoxIdentification);
			this.Controls.Add(this.groupBoxHeritage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormPlay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Tour";
			this.groupBoxHeritage.ResumeLayout(false);
			this.groupBoxHeritage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBoxIdentification.ResumeLayout(false);
			this.groupBoxIdentification.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJob)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListView listViewHeritage;
        private System.Windows.Forms.GroupBox groupBoxHeritage;
        private System.Windows.Forms.Button buttonNextPlayer;
        private System.Windows.Forms.Button buttonStopGame;
        private System.Windows.Forms.Button buttonBuyItem;
        private System.Windows.Forms.Button buttonSoldItem;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.GroupBox groupBoxIdentification;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxScientific;
        private System.Windows.Forms.TextBox textBoxEmpathy;
        private System.Windows.Forms.TextBox textBoxCreativity;
        private System.Windows.Forms.TextBox textBoxManagement;
        private System.Windows.Forms.TextBox textBoxFitness;
        private System.Windows.Forms.PictureBox pictureBoxJob;
        private System.Windows.Forms.Button buttonChangeJob;
        private System.Windows.Forms.Label labelGrade;
    }
}