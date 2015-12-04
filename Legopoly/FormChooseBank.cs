using Legopoly.Data.Items;
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
	public partial class FormChooseBank : Form
	{
		public FormChooseBank()
		{
			InitializeComponent();
			InitializeFormContent();
		}

		public Bank SelectedBank
		{
			get
			{
				return this.userControlItems1.SelectedItem as Bank;
			}
		}

		private void InitializeFormContent()
		{
			List<ItemBase> allItems = Parameters.ParametersMain.Instance.Shop.Items;

			foreach (ItemBase item in allItems)
			{
				if (!(item is Bank))
					continue;

				// Make a clone, so we won't modify shop property
				ItemBase newItem = item.Clone();
				this.userControlItems1.AddItem(newItem);
			}

			this.userControlItems1.Refresh();
		}
	}
}
