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


			this.Images = new Image[5];
			this.Images[0] = global::Legopoly.Properties.Resources.worker2;
			this.Images[1] = global::Legopoly.Properties.Resources.worker2;
			this.Images[2] = global::Legopoly.Properties.Resources.engineer;
			this.Images[3] = global::Legopoly.Properties.Resources.businessman2;
			this.Images[4] = global::Legopoly.Properties.Resources.businessman3;
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
