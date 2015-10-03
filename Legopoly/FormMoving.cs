using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legopoly
{
	public partial class FormMoving : Form
	{
		public FormMoving(int number)
		{
			InitializeComponent();
			this.labelNumber.Text = number.ToString();
		}
	}
}
