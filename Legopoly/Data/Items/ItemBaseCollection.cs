using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data.Items
{
	public class ItemBaseCollection : List<ItemBase>
	{
		public ItemBaseCollection()
		{
		}

		public new bool Remove(ItemBase item)
		{
			ItemBase itemToRemove = null;
			foreach (ItemBase curItem in this)
			{
				if (curItem.Name == item.Name)
				{
					itemToRemove = curItem;
					break;
                }
			}
			if (itemToRemove != null)
				return base.Remove(itemToRemove);

			return false;
		}
	}
}
