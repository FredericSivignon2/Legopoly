using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Legopoly.Data.Missions;
using FoundationLibraries.Xml;
using Legopoly.Data.Thiefs;

namespace Legopoly.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void MissionVehicle_GenerateFile()
		{
			MissionVehicle[] vehicles = new MissionVehicle[]
			{
				new MissionVehicle()
				{
					ForJobName = "Pompier",
					MaxMovePerRound = 10,
					MinMovePerRound = 4,
					MaxPassengers = 1,
					MinimumGradeLevel = 1,
					Name = "Voiture TOTO",
					PercentCostPerMission = 5.3
				},
				new MissionVehicle()
				{
					ForJobName = "Pompier",
					MaxMovePerRound = 10,
					MinMovePerRound = 4,
					MaxPassengers = 1,
					MinimumGradeLevel = 1,
					Name = "Camion A",
					PercentCostPerMission = 10.5
				}
			};

			XmlSerializationHelper.HelperUTF8.ToFile<MissionVehicle[]>("E:\\mission_vehicles.xml", vehicles);
        }

		[TestMethod]
		public void Thief_GenerateFile()
		{
			Thief[] thiefs = new Thief[]
			{
				new Thief()
				{
					Name = "Vol rapide d'argent ou de bijoux",
					Description = "Vol rapide où tu prends l'argent ou les bijoux que tu trouves dans l'endroit sélectionné, sans trainer sur les lieux.",
					PercentRisk = 0.4,
					StoleItem = false
				},
				new Thief()
				{
					Name = "Vol d'un véhicule",
					Description = "Vol d'une bicyclette, d'une moto, d'un ATC, d'une voiture ou d'un camion.",
					PercentRisk = 1.0,
					StoleItem = true
				},
				new Thief()
				{
					Name = "Vol d'argent ou de bijoux avec fouille complète",
					Description = "Vol long où tu prends l'argent ou les bijoux que tu trouves dans l'endroit sélectionné en recherchant dans tous les endroits du lieu.",
					PercentRisk = 5.0,
					StoleItem = false
				},
				new Thief()
				{
					Name = "Vol de gros volumes de biens",
					Description = "Vol long où tu prends l'argent, les bijoux mais aussi du mobilier, des ordinateurs etc. que tu trouves dans l'endroit sélectionné.",
					PercentRisk = 8.0,
					StoleItem = false
				}
			};
			XmlSerializationHelper.HelperUTF8.ToFile<Thief[]>("E:\\thiefs.xml", thiefs);
		}
    }
}
