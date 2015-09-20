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
            this.buttonBuyItem = new System.Windows.Forms.Button();
            this.buttonNextPlayer = new System.Windows.Forms.Button();
            this.buttonStopGame = new System.Windows.Forms.Button();
            this.labelCapital = new System.Windows.Forms.Label();
            this.groupBoxHeritage.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(161, 42);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Frédéric";
            // 
            // listViewHeritage
            // 
            this.listViewHeritage.Location = new System.Drawing.Point(6, 53);
            this.listViewHeritage.Name = "listViewHeritage";
            this.listViewHeritage.Size = new System.Drawing.Size(972, 195);
            this.listViewHeritage.TabIndex = 1;
            this.listViewHeritage.UseCompatibleStateImageBehavior = false;
            this.listViewHeritage.View = System.Windows.Forms.View.Details;
            // 
            // groupBoxHeritage
            // 
            this.groupBoxHeritage.Controls.Add(this.buttonSoldItem);
            this.groupBoxHeritage.Controls.Add(this.buttonBuyItem);
            this.groupBoxHeritage.Controls.Add(this.listViewHeritage);
            this.groupBoxHeritage.Location = new System.Drawing.Point(12, 66);
            this.groupBoxHeritage.Name = "groupBoxHeritage";
            this.groupBoxHeritage.Size = new System.Drawing.Size(984, 254);
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
            // buttonNextPlayer
            // 
            this.buttonNextPlayer.Location = new System.Drawing.Point(766, 426);
            this.buttonNextPlayer.Name = "buttonNextPlayer";
            this.buttonNextPlayer.Size = new System.Drawing.Size(109, 23);
            this.buttonNextPlayer.TabIndex = 3;
            this.buttonNextPlayer.Text = "Jouer suivant";
            this.buttonNextPlayer.UseVisualStyleBackColor = true;
            // 
            // buttonStopGame
            // 
            this.buttonStopGame.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonStopGame.Location = new System.Drawing.Point(881, 426);
            this.buttonStopGame.Name = "buttonStopGame";
            this.buttonStopGame.Size = new System.Drawing.Size(109, 23);
            this.buttonStopGame.TabIndex = 4;
            this.buttonStopGame.Text = "Arrêter la partie";
            this.buttonStopGame.UseVisualStyleBackColor = true;
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapital.Location = new System.Drawing.Point(840, 18);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(156, 31);
            this.labelCapital.TabIndex = 5;
            this.labelCapital.Text = "-- capital --";
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 464);
            this.Controls.Add(this.labelCapital);
            this.Controls.Add(this.buttonStopGame);
            this.Controls.Add(this.buttonNextPlayer);
            this.Controls.Add(this.groupBoxHeritage);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPlay";
            this.groupBoxHeritage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}