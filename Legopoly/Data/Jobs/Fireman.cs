using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Jobs
{
    public class Fireman : JobBase
    {
        public Fireman()
        {
            this.Name = "Pompier";
			this.Image = global::Legopoly.Properties.Resources.firefighter;        
        }

		public Fireman(Fireman fm) : base(fm)
		{
		}

		public override JobBase Clone()
		{
			return new Fireman(this);
		}
	}
}
