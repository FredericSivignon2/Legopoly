using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Legopoly.Data.Missions;
using FoundationLibraries.Xml;

namespace Legopoly.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
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
					Name = "Voiture TOTO"
				},
				new MissionVehicle()
				{
					ForJobName = "Pompier",
					MaxMovePerRound = 10,
					MinMovePerRound = 4,
					MaxPassengers = 1,
					MinimumGradeLevel = 1,
					Name = "Camion A"
				}
			};

			XmlSerializationHelper.HelperUTF8.ToFile<MissionVehicle[]>("E:\\mission_vehicles.xml", vehicles);
        }
	}
}
