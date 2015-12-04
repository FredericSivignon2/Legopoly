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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlay));
			this.labelName = new System.Windows.Forms.Label();
			this.groupBoxHeritage = new System.Windows.Forms.GroupBox();
			this.buttonSaleTo = new System.Windows.Forms.Button();
			this.userControlItems1 = new Legopoly.UserControlItems();
			this.buttonSoldItem = new System.Windows.Forms.Button();
			this.pictureBoxCapital = new System.Windows.Forms.PictureBox();
			this.buttonBuyItem = new System.Windows.Forms.Button();
			this.labelCapital = new System.Windows.Forms.Label();
			this.groupBoxIdentification = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxThief = new System.Windows.Forms.TextBox();
			this.labelThief = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxEmpathy = new System.Windows.Forms.TextBox();
			this.textBoxScientific = new System.Windows.Forms.TextBox();
			this.textBoxCreativity = new System.Windows.Forms.TextBox();
			this.textBoxFitness = new System.Windows.Forms.TextBox();
			this.textBoxManagement = new System.Windows.Forms.TextBox();
			this.groupBoxActivity = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxSalary = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.radioButtonWorking = new System.Windows.Forms.RadioButton();
			this.radioButtonOffWork = new System.Windows.Forms.RadioButton();
			this.labelGrade = new System.Windows.Forms.Label();
			this.buttonChangeJob = new System.Windows.Forms.Button();
			this.pictureBoxJob = new System.Windows.Forms.PictureBox();
			this.groupBoxState = new System.Windows.Forms.GroupBox();
			this.labelCapitalTotal = new System.Windows.Forms.Label();
			this.labeltiredness = new System.Windows.Forms.Label();
			this.labelCapitalTotalVal = new System.Windows.Forms.Label();
			this.progressBarTiredness = new System.Windows.Forms.ProgressBar();
			this.label9 = new System.Windows.Forms.Label();
			this.labelCapitalBanks = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.buttonBank = new System.Windows.Forms.Button();
			this.buttonThief = new System.Windows.Forms.Button();
			this.buttonSleep = new System.Windows.Forms.Button();
			this.buttonGame = new System.Windows.Forms.Button();
			this.buttonSchool = new System.Windows.Forms.Button();
			this.buttonMission = new System.Windows.Forms.Button();
			this.buttonMove = new System.Windows.Forms.Button();
			this.buttonNextPlayer = new System.Windows.Forms.Button();
			this.buttonStopGame = new System.Windows.Forms.Button();
			this.groupBoxHeritage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapital)).BeginInit();
			this.groupBoxIdentification.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBoxActivity.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJob)).BeginInit();
			this.groupBoxState.SuspendLayout();
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
			// groupBoxHeritage
			// 
			this.groupBoxHeritage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxHeritage.Controls.Add(this.buttonSaleTo);
			this.groupBoxHeritage.Controls.Add(this.userControlItems1);
			this.groupBoxHeritage.Controls.Add(this.buttonSoldItem);
			this.groupBoxHeritage.Controls.Add(this.pictureBoxCapital);
			this.groupBoxHeritage.Controls.Add(this.buttonBuyItem);
			this.groupBoxHeritage.Location = new System.Drawing.Point(12, 287);
			this.groupBoxHeritage.Name = "groupBoxHeritage";
			this.groupBoxHeritage.Size = new System.Drawing.Size(977, 354);
			this.groupBoxHeritage.TabIndex = 2;
			this.groupBoxHeritage.TabStop = false;
			this.groupBoxHeritage.Text = "Patrimoine";
			// 
			// buttonSaleTo
			// 
			this.buttonSaleTo.Location = new System.Drawing.Point(719, 77);
			this.buttonSaleTo.Name = "buttonSaleTo";
			this.buttonSaleTo.Size = new System.Drawing.Size(88, 23);
			this.buttonSaleTo.TabIndex = 9;
			this.buttonSaleTo.Text = "Vendre à...";
			this.buttonSaleTo.UseVisualStyleBackColor = true;
			this.buttonSaleTo.Click += new System.EventHandler(this.buttonSaleTo_Click);
			// 
			// userControlItems1
			// 
			this.userControlItems1.Items = new Legopoly.Data.Items.ItemBase[0];
			this.userControlItems1.Location = new System.Drawing.Point(76, 19);
			this.userControlItems1.Name = "userControlItems1";
			this.userControlItems1.Size = new System.Drawing.Size(637, 329);
			this.userControlItems1.TabIndex = 8;
			// 
			// buttonSoldItem
			// 
			this.buttonSoldItem.Location = new System.Drawing.Point(719, 48);
			this.buttonSoldItem.Name = "buttonSoldItem";
			this.buttonSoldItem.Size = new System.Drawing.Size(88, 23);
			this.buttonSoldItem.TabIndex = 3;
			this.buttonSoldItem.Text = "Vendre";
			this.buttonSoldItem.UseVisualStyleBackColor = true;
			this.buttonSoldItem.Click += new System.EventHandler(this.buttonSoldItem_Click);
			// 
			// pictureBoxCapital
			// 
			this.pictureBoxCapital.Image = global::Legopoly.Properties.Resources.money;
			this.pictureBoxCapital.Location = new System.Drawing.Point(6, 19);
			this.pictureBoxCapital.Name = "pictureBoxCapital";
			this.pictureBoxCapital.Size = new System.Drawing.Size(64, 64);
			this.pictureBoxCapital.TabIndex = 7;
			this.pictureBoxCapital.TabStop = false;
			// 
			// buttonBuyItem
			// 
			this.buttonBuyItem.Location = new System.Drawing.Point(719, 19);
			this.buttonBuyItem.Name = "buttonBuyItem";
			this.buttonBuyItem.Size = new System.Drawing.Size(88, 23);
			this.buttonBuyItem.TabIndex = 2;
			this.buttonBuyItem.Text = "Acheter";
			this.buttonBuyItem.UseVisualStyleBackColor = true;
			this.buttonBuyItem.Click += new System.EventHandler(this.buttonBuyItem_Click);
			// 
			// labelCapital
			// 
			this.labelCapital.AutoSize = true;
			this.labelCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCapital.Location = new System.Drawing.Point(6, 98);
			this.labelCapital.Name = "labelCapital";
			this.labelCapital.Size = new System.Drawing.Size(128, 26);
			this.labelCapital.TabIndex = 5;
			this.labelCapital.Text = "-- capital --";
			// 
			// groupBoxIdentification
			// 
			this.groupBoxIdentification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxIdentification.Controls.Add(this.groupBox1);
			this.groupBoxIdentification.Controls.Add(this.groupBoxActivity);
			this.groupBoxIdentification.Controls.Add(this.labelGrade);
			this.groupBoxIdentification.Controls.Add(this.buttonChangeJob);
			this.groupBoxIdentification.Controls.Add(this.pictureBoxJob);
			this.groupBoxIdentification.Controls.Add(this.labelName);
			this.groupBoxIdentification.Location = new System.Drawing.Point(12, 12);
			this.groupBoxIdentification.Name = "groupBoxIdentification";
			this.groupBoxIdentification.Size = new System.Drawing.Size(977, 269);
			this.groupBoxIdentification.TabIndex = 6;
			this.groupBoxIdentification.TabStop = false;
			this.groupBoxIdentification.Text = "Carte d\'identité";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxThief);
			this.groupBox1.Controls.Add(this.labelThief);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBoxEmpathy);
			this.groupBox1.Controls.Add(this.textBoxScientific);
			this.groupBox1.Controls.Add(this.textBoxCreativity);
			this.groupBox1.Controls.Add(this.textBoxFitness);
			this.groupBox1.Controls.Add(this.textBoxManagement);
			this.groupBox1.Location = new System.Drawing.Point(393, 168);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(578, 95);
			this.groupBox1.TabIndex = 31;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Expériences Cumulée";
			// 
			// textBoxThief
			// 
			this.textBoxThief.Location = new System.Drawing.Point(485, 59);
			this.textBoxThief.Name = "textBoxThief";
			this.textBoxThief.ReadOnly = true;
			this.textBoxThief.Size = new System.Drawing.Size(77, 20);
			this.textBoxThief.TabIndex = 26;
			// 
			// labelThief
			// 
			this.labelThief.AutoSize = true;
			this.labelThief.Location = new System.Drawing.Point(398, 62);
			this.labelThief.Name = "labelThief";
			this.labelThief.Size = new System.Drawing.Size(40, 13);
			this.labelThief.TabIndex = 25;
			this.labelThief.Text = "Voleur:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Scientifique:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(197, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Créativité:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "Management:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(398, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Empathie:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(197, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 19;
			this.label5.Text = "Physiques:";
			// 
			// textBoxEmpathy
			// 
			this.textBoxEmpathy.Location = new System.Drawing.Point(485, 33);
			this.textBoxEmpathy.Name = "textBoxEmpathy";
			this.textBoxEmpathy.ReadOnly = true;
			this.textBoxEmpathy.Size = new System.Drawing.Size(77, 20);
			this.textBoxEmpathy.TabIndex = 24;
			// 
			// textBoxScientific
			// 
			this.textBoxScientific.Location = new System.Drawing.Point(109, 33);
			this.textBoxScientific.Name = "textBoxScientific";
			this.textBoxScientific.ReadOnly = true;
			this.textBoxScientific.Size = new System.Drawing.Size(77, 20);
			this.textBoxScientific.TabIndex = 20;
			// 
			// textBoxCreativity
			// 
			this.textBoxCreativity.Location = new System.Drawing.Point(300, 59);
			this.textBoxCreativity.Name = "textBoxCreativity";
			this.textBoxCreativity.ReadOnly = true;
			this.textBoxCreativity.Size = new System.Drawing.Size(77, 20);
			this.textBoxCreativity.TabIndex = 23;
			// 
			// textBoxFitness
			// 
			this.textBoxFitness.Location = new System.Drawing.Point(300, 33);
			this.textBoxFitness.Name = "textBoxFitness";
			this.textBoxFitness.ReadOnly = true;
			this.textBoxFitness.Size = new System.Drawing.Size(77, 20);
			this.textBoxFitness.TabIndex = 21;
			// 
			// textBoxManagement
			// 
			this.textBoxManagement.Location = new System.Drawing.Point(109, 59);
			this.textBoxManagement.Name = "textBoxManagement";
			this.textBoxManagement.ReadOnly = true;
			this.textBoxManagement.Size = new System.Drawing.Size(77, 20);
			this.textBoxManagement.TabIndex = 22;
			// 
			// groupBoxActivity
			// 
			this.groupBoxActivity.Controls.Add(this.label7);
			this.groupBoxActivity.Controls.Add(this.textBoxSalary);
			this.groupBoxActivity.Controls.Add(this.label6);
			this.groupBoxActivity.Controls.Add(this.radioButtonWorking);
			this.groupBoxActivity.Controls.Add(this.radioButtonOffWork);
			this.groupBoxActivity.Location = new System.Drawing.Point(393, 17);
			this.groupBoxActivity.Name = "groupBoxActivity";
			this.groupBoxActivity.Size = new System.Drawing.Size(578, 145);
			this.groupBoxActivity.TabIndex = 30;
			this.groupBoxActivity.TabStop = false;
			this.groupBoxActivity.Text = "Activité";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(48, 82);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 13);
			this.label7.TabIndex = 31;
			this.label7.Text = "Salaire par tour:";
			// 
			// textBoxSalary
			// 
			this.textBoxSalary.Location = new System.Drawing.Point(135, 79);
			this.textBoxSalary.Name = "textBoxSalary";
			this.textBoxSalary.ReadOnly = true;
			this.textBoxSalary.Size = new System.Drawing.Size(77, 20);
			this.textBoxSalary.TabIndex = 32;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(539, 26);
			this.label6.TabIndex = 30;
			this.label6.Text = "Un joueur au travail reçoit automatiquement des points d\'expérience après chaque " +
    "tour, en fonction de son grade\r\ncourant, ainsi qu\'un salaire également défini pa" +
    "r son grade.";
			// 
			// radioButtonWorking
			// 
			this.radioButtonWorking.AutoSize = true;
			this.radioButtonWorking.Location = new System.Drawing.Point(27, 56);
			this.radioButtonWorking.Name = "radioButtonWorking";
			this.radioButtonWorking.Size = new System.Drawing.Size(328, 17);
			this.radioButtonWorking.TabIndex = 28;
			this.radioButtonWorking.TabStop = true;
			this.radioButtonWorking.Text = "Au travail (Le joueur doit être présent à son travail ou en mission)";
			this.radioButtonWorking.UseVisualStyleBackColor = true;
			this.radioButtonWorking.CheckedChanged += new System.EventHandler(this.radioButtonWorking_CheckedChanged);
			// 
			// radioButtonOffWork
			// 
			this.radioButtonOffWork.AutoSize = true;
			this.radioButtonOffWork.Location = new System.Drawing.Point(27, 105);
			this.radioButtonOffWork.Name = "radioButtonOffWork";
			this.radioButtonOffWork.Size = new System.Drawing.Size(473, 17);
			this.radioButtonOffWork.TabIndex = 29;
			this.radioButtonOffWork.TabStop = true;
			this.radioButtonOffWork.Text = "En repos (Le joueur est libre d\'aller où il veut, mais il ne touchera ni salaire " +
    "ni point d\'expérience)";
			this.radioButtonOffWork.UseVisualStyleBackColor = true;
			this.radioButtonOffWork.CheckedChanged += new System.EventHandler(this.radioButtonOffWork_CheckedChanged);
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
			this.buttonChangeJob.Image = global::Legopoly.Properties.Resources.hat_blue;
			this.buttonChangeJob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonChangeJob.Location = new System.Drawing.Point(13, 240);
			this.buttonChangeJob.Name = "buttonChangeJob";
			this.buttonChangeJob.Size = new System.Drawing.Size(128, 23);
			this.buttonChangeJob.TabIndex = 26;
			this.buttonChangeJob.Text = "Changer de métier";
			this.buttonChangeJob.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			// groupBoxState
			// 
			this.groupBoxState.Controls.Add(this.labelCapitalTotal);
			this.groupBoxState.Controls.Add(this.labeltiredness);
			this.groupBoxState.Controls.Add(this.labelCapitalTotalVal);
			this.groupBoxState.Controls.Add(this.progressBarTiredness);
			this.groupBoxState.Controls.Add(this.label9);
			this.groupBoxState.Controls.Add(this.labelCapitalBanks);
			this.groupBoxState.Controls.Add(this.label8);
			this.groupBoxState.Controls.Add(this.labelCapital);
			this.groupBoxState.Location = new System.Drawing.Point(995, 12);
			this.groupBoxState.Name = "groupBoxState";
			this.groupBoxState.Size = new System.Drawing.Size(179, 629);
			this.groupBoxState.TabIndex = 32;
			this.groupBoxState.TabStop = false;
			this.groupBoxState.Text = "Etat";
			// 
			// labelCapitalTotal
			// 
			this.labelCapitalTotal.AutoSize = true;
			this.labelCapitalTotal.Location = new System.Drawing.Point(7, 187);
			this.labelCapitalTotal.Name = "labelCapitalTotal";
			this.labelCapitalTotal.Size = new System.Drawing.Size(65, 13);
			this.labelCapitalTotal.TabIndex = 14;
			this.labelCapitalTotal.Text = "Capital total:";
			// 
			// labeltiredness
			// 
			this.labeltiredness.AutoSize = true;
			this.labeltiredness.Location = new System.Drawing.Point(7, 28);
			this.labeltiredness.Name = "labeltiredness";
			this.labeltiredness.Size = new System.Drawing.Size(43, 13);
			this.labeltiredness.TabIndex = 1;
			this.labeltiredness.Text = "Energie";
			// 
			// labelCapitalTotalVal
			// 
			this.labelCapitalTotalVal.AutoSize = true;
			this.labelCapitalTotalVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCapitalTotalVal.Location = new System.Drawing.Point(4, 203);
			this.labelCapitalTotalVal.Name = "labelCapitalTotalVal";
			this.labelCapitalTotalVal.Size = new System.Drawing.Size(128, 26);
			this.labelCapitalTotalVal.TabIndex = 13;
			this.labelCapitalTotalVal.Text = "-- capital --";
			// 
			// progressBarTiredness
			// 
			this.progressBarTiredness.Location = new System.Drawing.Point(6, 47);
			this.progressBarTiredness.Name = "progressBarTiredness";
			this.progressBarTiredness.Size = new System.Drawing.Size(167, 23);
			this.progressBarTiredness.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 132);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(107, 13);
			this.label9.TabIndex = 12;
			this.label9.Text = "Capital en banque(s):";
			// 
			// labelCapitalBanks
			// 
			this.labelCapitalBanks.AutoSize = true;
			this.labelCapitalBanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCapitalBanks.Location = new System.Drawing.Point(5, 148);
			this.labelCapitalBanks.Name = "labelCapitalBanks";
			this.labelCapitalBanks.Size = new System.Drawing.Size(128, 26);
			this.labelCapitalBanks.TabIndex = 11;
			this.labelCapitalBanks.Text = "-- capital --";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 82);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(92, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Capital disponible:";
			// 
			// buttonBank
			// 
			this.buttonBank.Image = global::Legopoly.Properties.Resources.bank_house2_euro;
			this.buttonBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonBank.Location = new System.Drawing.Point(642, 647);
			this.buttonBank.Name = "buttonBank";
			this.buttonBank.Size = new System.Drawing.Size(120, 70);
			this.buttonBank.TabIndex = 12;
			this.buttonBank.Text = "Banque ";
			this.buttonBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonBank.UseVisualStyleBackColor = true;
			this.buttonBank.Click += new System.EventHandler(this.buttonBank_Click);
			// 
			// buttonThief
			// 
			this.buttonThief.Image = global::Legopoly.Properties.Resources.robber;
			this.buttonThief.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonThief.Location = new System.Drawing.Point(516, 647);
			this.buttonThief.Name = "buttonThief";
			this.buttonThief.Size = new System.Drawing.Size(120, 70);
			this.buttonThief.TabIndex = 11;
			this.buttonThief.Text = "Voler ";
			this.buttonThief.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonThief.UseVisualStyleBackColor = true;
			this.buttonThief.Click += new System.EventHandler(this.buttonThief_Click);
			// 
			// buttonSleep
			// 
			this.buttonSleep.Image = global::Legopoly.Properties.Resources.moon_half_64;
			this.buttonSleep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSleep.Location = new System.Drawing.Point(768, 647);
			this.buttonSleep.Name = "buttonSleep";
			this.buttonSleep.Size = new System.Drawing.Size(120, 70);
			this.buttonSleep.TabIndex = 10;
			this.buttonSleep.Text = "Dormir";
			this.buttonSleep.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.buttonSleep.UseVisualStyleBackColor = true;
			this.buttonSleep.Click += new System.EventHandler(this.buttonSleep_Click);
			// 
			// buttonGame
			// 
			this.buttonGame.Image = global::Legopoly.Properties.Resources.gambling_chips2_64;
			this.buttonGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonGame.Location = new System.Drawing.Point(390, 647);
			this.buttonGame.Name = "buttonGame";
			this.buttonGame.Size = new System.Drawing.Size(120, 70);
			this.buttonGame.TabIndex = 9;
			this.buttonGame.Text = "Jeux ";
			this.buttonGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonGame.UseVisualStyleBackColor = true;
			this.buttonGame.Click += new System.EventHandler(this.buttonGame_Click);
			// 
			// buttonSchool
			// 
			this.buttonSchool.Image = global::Legopoly.Properties.Resources.school;
			this.buttonSchool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSchool.Location = new System.Drawing.Point(264, 647);
			this.buttonSchool.Name = "buttonSchool";
			this.buttonSchool.Size = new System.Drawing.Size(120, 70);
			this.buttonSchool.TabIndex = 8;
			this.buttonSchool.Text = "Université";
			this.buttonSchool.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonSchool.UseVisualStyleBackColor = true;
			this.buttonSchool.Click += new System.EventHandler(this.buttonSchool_Click);
			// 
			// buttonMission
			// 
			this.buttonMission.Image = global::Legopoly.Properties.Resources.target3;
			this.buttonMission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonMission.Location = new System.Drawing.Point(138, 647);
			this.buttonMission.Name = "buttonMission";
			this.buttonMission.Size = new System.Drawing.Size(120, 70);
			this.buttonMission.TabIndex = 7;
			this.buttonMission.Text = "Mission   ";
			this.buttonMission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonMission.UseVisualStyleBackColor = true;
			this.buttonMission.Click += new System.EventHandler(this.buttonMission_Click);
			// 
			// buttonMove
			// 
			this.buttonMove.Image = global::Legopoly.Properties.Resources.dice_red;
			this.buttonMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonMove.Location = new System.Drawing.Point(12, 647);
			this.buttonMove.Name = "buttonMove";
			this.buttonMove.Size = new System.Drawing.Size(120, 70);
			this.buttonMove.TabIndex = 0;
			this.buttonMove.Text = "Se déplacer";
			this.buttonMove.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.buttonMove.UseVisualStyleBackColor = true;
			this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonNextPlayer
			// 
			this.buttonNextPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonNextPlayer.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonNextPlayer.Image = global::Legopoly.Properties.Resources.ok;
			this.buttonNextPlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonNextPlayer.Location = new System.Drawing.Point(936, 647);
			this.buttonNextPlayer.Name = "buttonNextPlayer";
			this.buttonNextPlayer.Size = new System.Drawing.Size(120, 70);
			this.buttonNextPlayer.TabIndex = 3;
			this.buttonNextPlayer.Text = "Tour OK ";
			this.buttonNextPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonNextPlayer.UseVisualStyleBackColor = true;
			this.buttonNextPlayer.Click += new System.EventHandler(this.buttonNextPlayer_Click);
			// 
			// buttonStopGame
			// 
			this.buttonStopGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStopGame.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonStopGame.Image = global::Legopoly.Properties.Resources.sign_stop;
			this.buttonStopGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonStopGame.Location = new System.Drawing.Point(1062, 647);
			this.buttonStopGame.Name = "buttonStopGame";
			this.buttonStopGame.Size = new System.Drawing.Size(120, 70);
			this.buttonStopGame.TabIndex = 4;
			this.buttonStopGame.Text = "Arrêter";
			this.buttonStopGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonStopGame.UseVisualStyleBackColor = true;
			this.buttonStopGame.Click += new System.EventHandler(this.buttonStopGame_Click);
			// 
			// FormPlay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1194, 729);
			this.Controls.Add(this.groupBoxState);
			this.Controls.Add(this.buttonBank);
			this.Controls.Add(this.buttonThief);
			this.Controls.Add(this.buttonSleep);
			this.Controls.Add(this.buttonGame);
			this.Controls.Add(this.buttonSchool);
			this.Controls.Add(this.buttonMission);
			this.Controls.Add(this.buttonMove);
			this.Controls.Add(this.buttonNextPlayer);
			this.Controls.Add(this.buttonStopGame);
			this.Controls.Add(this.groupBoxIdentification);
			this.Controls.Add(this.groupBoxHeritage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormPlay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Tour";
			this.Shown += new System.EventHandler(this.FormPlay_Shown);
			this.groupBoxHeritage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapital)).EndInit();
			this.groupBoxIdentification.ResumeLayout(false);
			this.groupBoxIdentification.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBoxActivity.ResumeLayout(false);
			this.groupBoxActivity.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxJob)).EndInit();
			this.groupBoxState.ResumeLayout(false);
			this.groupBoxState.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxHeritage;
        private System.Windows.Forms.Button buttonNextPlayer;
        private System.Windows.Forms.Button buttonStopGame;
        private System.Windows.Forms.Button buttonBuyItem;
        private System.Windows.Forms.Button buttonSoldItem;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.GroupBox groupBoxIdentification;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.PictureBox pictureBoxCapital;
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
		private System.Windows.Forms.RadioButton radioButtonOffWork;
		private System.Windows.Forms.RadioButton radioButtonWorking;
		private System.Windows.Forms.GroupBox groupBoxActivity;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxSalary;
		private System.Windows.Forms.Button buttonMission;
		private UserControlItems userControlItems1;
		private System.Windows.Forms.Button buttonSchool;
		private System.Windows.Forms.Button buttonGame;
		private System.Windows.Forms.GroupBox groupBoxState;
		private System.Windows.Forms.Label labeltiredness;
		private System.Windows.Forms.ProgressBar progressBarTiredness;
		private System.Windows.Forms.Button buttonSleep;
		private System.Windows.Forms.Button buttonSaleTo;
		private System.Windows.Forms.Button buttonThief;
		private System.Windows.Forms.TextBox textBoxThief;
		private System.Windows.Forms.Label labelThief;
		private System.Windows.Forms.Button buttonBank;
		private System.Windows.Forms.Label labelCapitalTotal;
		private System.Windows.Forms.Label labelCapitalTotalVal;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label labelCapitalBanks;
		private System.Windows.Forms.Label label8;
	}
}