using FoundationLibraries.Xml;
using Legopoly.Data;
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
		#region Data Members
		private const string locationsFileName = "locations.txt";
		private const string missionVehiclesFileName = "missions_vehicles.xml";

		private Mission mission;
		private Player player;
		private Game game;
		private int roundLeft;
		#endregion

		#region Constructor
		public FormMission(Mission mission, Player player, Game game)
		{
			this.mission = mission;
			this.player = player;
			this.game = game;
			this.roundLeft = game.GetRandomNumber(this.mission.MinRounds, this.mission.MaxRounds);

			InitializeComponent();
			InitializeFormContent();
		}
		#endregion

		#region Public Properties
		public double Gain
		{
			get
			{
				return ComputeGain();
			}
		}
		#endregion

		#region Private Methods
		private void InitializeFormContent()
		{
			this.labelMissionDescription.Text = GetMissionDescription();
			this.buttonMove.Enabled = false;
			UpdateRoundLeftDisplay();
			ComputeGain();
			UpdateGainDisplay();
			PopulateVehicles();
        }

		private void PopulateVehicles()
		{
			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, missionVehiclesFileName);
			if (!File.Exists(filePath))
				throw new FileNotFoundException(string.Format("Impossible de trouver le fichier '{0}' !", filePath));

			MissionVehicle[] vehicles = XmlSerializationHelper.HelperUTF8.FromFile<MissionVehicle[]>(filePath);
			foreach (MissionVehicle vehicle in vehicles)
			{
				if (vehicle.ForJobName == this.player.Job.Name)
					this.listBoxVehicles.Items.Add(vehicle);
			}
        }

		private void UpdateRoundLeftDisplay()
		{
			this.labelRoundLeft.Text = this.roundLeft.ToString();
        }

		private void UpdateGainDisplay()
		{
			this.labelGain.Text = string.Format("{0,8:N0}€", ComputeGain());
		}

		private double ComputeGain()
		{
			double baseGain = this.mission.Gain * this.roundLeft;
            double finalGain = baseGain;
			MissionVehicle vehicle = (MissionVehicle)this.listBoxVehicles.SelectedItem;
			if (vehicle != null)
			{
				finalGain = baseGain - (baseGain * vehicle.PercentCostPerMission / 100.0);
				if (finalGain < 0.0)
					finalGain = 0.0;
			}
			return finalGain;
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

		private string GetImageLocation(string imagePath)
		{
			if (string.IsNullOrWhiteSpace(imagePath))
				return null;

			string root = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Pictures");
			if (Directory.Exists(root) == false)
				return string.Empty;

			return Path.Combine(root, imagePath);
		}

		private void UpdateSelectedItemDisplay()
		{
			if (this.listBoxVehicles.SelectedItem == null)
			{
				this.pictureBox1.Image = null;
				return;
			}
			MissionVehicle vehicle = (MissionVehicle)this.listBoxVehicles.SelectedItem;

			this.pictureBox1.ImageLocation = GetImageLocation(vehicle.PicturePath);
			this.textBoxDescription.Text = vehicle.Description;
		}

		private void UpdateAccessRights()
		{
			MissionVehicle vehicle = (MissionVehicle)this.listBoxVehicles.SelectedItem;
			if (vehicle.MinimumGradeLevel > this.player.Job.GradeLevel)
			{
				this.labelAccess.Text = "Tu n'es pas encore autorisé à utiliser ce véhicule !";
				this.buttonMove.Enabled = false;
				return;
			}
			else
			{
				this.labelAccess.Text = "Tu es autorisé à utiliser ce véhicule.";
				this.buttonMove.Enabled = true;
			}
		}
		#endregion

		#region Event Handlers
		private void buttonMove_Click(object sender, EventArgs e)
		{
			MissionVehicle vehicle = this.listBoxVehicles.SelectedItem as MissionVehicle;
			if (vehicle == null)
			{
				LPMessageBox.ShowExclamation("Sélectionnes un véhicule avant de te déplacer !");
				return;
			}

			if (this.listBoxVehicles.Enabled && 
				LPMessageBox.ShowQuestion(string.Format(
				"Es-tu sur de vouloir utiliser '{0}' ?\r\n\r\nTu ne pourras plus changer de véhicule en cours de mission.", vehicle.Name)) != DialogResult.Yes)
				return;

			// As soon as a vehicle has been selected, don't allow user to select a new one after the first move
			this.listBoxVehicles.Enabled = false;

			int number = this.game.GetRandomNumber(vehicle.MinMovePerRound, vehicle.MaxMovePerRound);
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

		private void listBoxVehicles_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateSelectedItemDisplay();
			UpdateAccessRights();
			UpdateGainDisplay();
		}
		#endregion
	}
}
