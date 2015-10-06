using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Legopoly.Data.Items;
using System.IO;

namespace Legopoly
{
	public partial class UserControlItems : UserControl
	{
		#region Data Members
		private List<ItemBase> items = new List<ItemBase>();
		private ItemBase selectedItem;
		#endregion

		#region Constructor
		public UserControlItems()
		{
			InitializeComponent();
			UpdateInfoDisplay();
        }
		#endregion

		#region Public Properties
		public ItemBase[] Items
		{
			get
			{
				return this.items.ToArray<ItemBase>();
			}
			set
			{
				this.items.Clear();
				this.items.AddRange(value);
				UpdateInfoDisplay();
			}
		}

		public ItemBase SelectedItem
		{
			get
			{
				return this.selectedItem;
			}
		}
		#endregion

		#region Public Methods
		public void AddItem(ItemBase item)
		{
			this.items.Add(item);
        }

		public void Refresh()
		{
			UpdateInfoDisplay();
        }
		#endregion

		#region Private Methods
		private void UpdateInfoDisplay()
		{
			this.listViewHeritage.Items.Clear();
			this.listViewHeritage.Columns.Clear();

			if (this.items == null || this.items.Count == 0)
				return;

			this.listViewHeritage.Columns.Add("Nom", 220);
			this.listViewHeritage.Columns.Add("Type", 150);

			foreach (ItemBase item in this.items)
			{
				AddListViewItem(item);
			}

		}

		private void AddListViewItem(ItemBase itemBase)
		{
			ListViewItem item = new ListViewItem(itemBase.Name);
			item.SubItems.Add(itemBase.GetDisplayType());

			item.Tag = itemBase;
			this.listViewHeritage.Items.Add(item);
			this.listViewHeritage.Invalidate();
		}

		private void UpdateSelectedItemDisplay()
		{
			if (this.selectedItem == null)
			{
				this.textBoxDescription.Text = string.Empty;
				this.pictureBox1.Image = null;
                return;
			}
			this.textBoxDescription.Text = this.selectedItem.ToString();
			this.pictureBox1.ImageLocation = GetImageLocation(this.selectedItem.PicturePath);
		}

		private string GetImageLocation(string imagePath)
		{
			if (string.IsNullOrWhiteSpace(imagePath))
				return null;

			string root = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Pictures");
			if (Directory.Exists(root) == false)
				return string.Empty;

			return Path.Combine(root, imagePath);
		}
		#endregion

		#region Event Handlers
		private void listViewHeritage_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listViewHeritage.SelectedItems.Count == 0)
			{
				this.selectedItem = null;
				return;
			}

			ListViewItem item = this.listViewHeritage.SelectedItems[0];

			this.selectedItem = item.Tag as ItemBase;
			UpdateSelectedItemDisplay();
		}
		#endregion
	}
}
