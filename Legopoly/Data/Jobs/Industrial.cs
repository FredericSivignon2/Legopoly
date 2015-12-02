using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Jobs
{
	public class Industrial : JobBase
	{
		public Industrial()
		{
			this.Name = "Industriel";
			switch (base.GradeLevel)
			{
				case 0:
				case 1:
					this.Image = global::Legopoly.Properties.Resources.worker2;
					break;
				case 2:
					this.Image = global::Legopoly.Properties.Resources.engineer;
					break;
				case 3:
					this.Image = global::Legopoly.Properties.Resources.businessman2;
					break;
				default:
				case 4:
					this.Image = global::Legopoly.Properties.Resources.businessman3;
					break;

			}
		}

		public Industrial(Industrial fm) : base(fm)
		{
		}
		
		public override JobBase Clone()
		{
			return new Industrial(this);
		}
	}
}
