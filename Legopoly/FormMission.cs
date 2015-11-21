﻿using Legopoly.Data;
using Legopoly.Data.Missions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legopoly
{
	public partial class FormMission : Form
	{
		private const string locationsFileName = "locations.txt";

		private Mission mission;
		private Player player;
		private Game game;
		private int roundLeft;
		private double gain;

		public FormMission(Mission mission, Player player, Game game)
		{
			this.mission = mission;
			this.player = player;
			this.game = game;
			this.roundLeft = game.GetRandomNumber(this.mission.MinRounds, this.mission.MaxRounds);

			InitializeComponent();
			InitializeFormContent();
		}

		public double Gain
		{
			get
			{
				return this.gain;
			}
		}

		private void InitializeFormContent()
		{
			this.labelMissionDescription.Text = GetMissionDescription();
			UpdateRoundLeftDisplay();
			ComputeGain();
			UpdateGainDisplay();
        }

		private void UpdateRoundLeftDisplay()
		{
			this.labelRoundLeft.Text = this.roundLeft.ToString();
        }

		private void UpdateGainDisplay()
		{
			this.labelGain.Text = string.Format("{0,8:N0}€", this.gain);
		}

		private void ComputeGain()
		{
			this.gain = this.mission.Gain * this.roundLeft;
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			int number = this.game.GetRandomNumber(2, 12);
			using (FormMoving dlg = new FormMoving(number))
			{
				dlg.ShowDialog(this);

				this.roundLeft--;
				ComputeGain();
				UpdateRoundLeftDisplay();
				UpdateGainDisplay();

				if (this.roundLeft == 0)
				{
					this.buttonSuccess.Enabled = false;
					LPMessageBox.ShowExclamation("Tu n'es pas arrivé à temps pour réussir la Mission !");
				}
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			if (this.roundLeft > 0)
			{
				if (LPMessageBox.ShowQuestion("Veux-tu vraiment abandonner la Mission ?") == DialogResult.No)
				{
					this.DialogResult = DialogResult.None;
				}
			}
		}

		private void buttonSuccess_Click(object sender, EventArgs e)
		{

		}

		private string GetMissionDescription()
		{
			if (this.mission.Description.Contains("{0}"))
			{
				string locationsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, locationsFileName);
				if (File.Exists(locationsPath) == false)
					throw new InvalidOperationException(string.Format("Le fichier {0} est introuvable!", locationsPath));

				string[] locations = File.ReadAllLines(locationsPath);
				string location = locations[this.game.GetRandomNumber(0, locations.Length - 1)];

				return string.Format(this.mission.Description, location);
			}
			else
				return this.mission.Description;
		}
	}
}
