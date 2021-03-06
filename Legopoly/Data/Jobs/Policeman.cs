﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Jobs
{
    public class Policeman : JobBase
    {
        public Policeman()
        {
            this.Name = "Policier";
			SetImagesForAllLevels(global::Legopoly.Properties.Resources.policeman_usa);
		}

		public Policeman(Policeman pm) : base(pm)
		{
		}

		public override JobBase Clone()
		{
			return new Policeman(this);
		}
	}
}
