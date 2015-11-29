using FoundationLibraries.Xml;
using Legopoly.Data;
using Legopoly.Data.Thiefs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legopoly
{
	public partial class FormThief : Form
	{
		#region Data Members
		private const string thiefFileName = "thiefs.xml";

		private Game _game;
		private Player _player;
		private Thief[] _thiefs;
		#endregion

		#region Constructor
		public FormThief(Game game, Player player)
		{
			this._game = game;
			this._player = player;

			InitializeComponent();
			InitializeFormContent();
		}
		#endregion

		#region Private Methods
		private void InitializeFormContent()
		{
			// Load Thief file
			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, thiefFileName);
			if (File.Exists(filePath) == false)
				throw new FileNotFoundException(string.Format("Impossible de trouver le fichier '{0}' !", thiefFileName));

			this._thiefs = XmlSerializationHelper.HelperUTF8.FromFile<Thief[]>(filePath);

			foreach (Thief thief in this._thiefs)
			{
				this.comboBox1.Items.Add(thief);
			}
		}
		#endregion
	}
}
