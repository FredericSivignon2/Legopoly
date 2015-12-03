using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Jobs
{
	public class Politician : JobBase
	{
		public Politician()
		{
			this.Name = "Politicien";
			SetImagesForAllLevels(global::Legopoly.Properties.Resources.lecture);
		}

		public Politician(Politician pt) : base(pt)
		{
		}

		public override JobBase Clone()
		{
			return new Politician(this);
		}
	}
}
