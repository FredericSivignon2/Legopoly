﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Items
{
	[DataContract]
	public class Motorbike : MotorVehicle
	{
		public override string GetDisplayType()
		{
			return "Motocyclette";
		}
	}
}
