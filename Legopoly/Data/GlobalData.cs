using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Data
{
	public class GlobalData
	{
		private static GlobalData instance;

		public static GlobalData Instance
		{
			get
			{
				if (instance == null)
					instance = new GlobalData();
				return instance;
			}
		}

		private Game currentGame;

		public void InitializeGame(Game game)
		{
			this.currentGame = game;
		}

		public Game CurrentGame
		{
			get
			{
				return this.currentGame;
			}
		}
	}
}
