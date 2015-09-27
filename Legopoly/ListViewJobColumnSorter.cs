using Legopoly.Data.Jobs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legopoly
{
	public class ListViewJobColumnSorter : IComparer
	{
		private SortOrder order;
		private int columnToSort;

		public ListViewJobColumnSorter()
		{
			this.order = SortOrder.Ascending;
			this.columnToSort = 0;
		}

		public int Compare(object x, object y)
		{
			int compareResult = 0;
			ListViewItem listviewX, listviewY;

			// Envoit les objets à comparer aux objets ListViewItem
			listviewX = (ListViewItem)x;
			listviewY = (ListViewItem)y;

			JobBase jobX = listviewX.Tag as JobBase;
			JobBase jobY = listviewY.Tag as JobBase;
			// Compare les deux éléments
			switch (this.columnToSort)
			{
				case 0:
					compareResult = jobX.Name.CompareTo(jobY.Name);
					break;
				case 1:
					compareResult = jobX.GradeNumber - jobY.GradeNumber;
					break;
				case 2:
					compareResult = jobX.SalaryPerRound - jobY.SalaryPerRound;
					break;
				default:
					throw new InvalidOperationException("Invalid column to sort!");
					
			}

			// Calcule la valeur correcte d'après la comparaison d'objets
			if (this.order == SortOrder.Ascending)
			{
				// Le tri croissant est sélectionné, renvoie des résultats normaux de comparaison
				return compareResult;
			}
			else if (this.order == SortOrder.Descending)
			{
				// Le tri décroissant est sélectionné, renvoie des résultats négatifs de comparaison
				return (-compareResult);
			}
			else
			{
				// Renvoie '0' pour indiquer qu'ils sont égaux
				return 0;
			}
		}

		public int ColumnToSort
		{
			get
			{
				return this.columnToSort;
			}
			set
			{
				this.columnToSort = value;
			}
		}

		public SortOrder Order
		{
			set
			{
				this.order = value;
			}
			get
			{
				return this.order;
			}
		}
	}
}
