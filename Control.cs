using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	class Control
	{//Singleton class
		private static Control instance = null;
		Player[] players;
		Player currentPlayer;

		public void Next()
		{
			if (currentPlayer.GetNumber() == 1)
			{
				currentPlayer = players[1];
			}
			else if (currentPlayer.GetNumber() == 2)
			{
				currentPlayer = players[0];
			}
		}

		public Player Current()
		{
			return currentPlayer;
		}

		private Control()
		{
			Init();
		}

		public static Control GetInstance()
		{
			if (instance == null)
				instance = new Control();
			return instance;
		}

		private void Init()
		{
			players = new Player[2];
			players[0] = new Player(true, 1);//Player one "X"
			players[1] = new Player(false, 2);//Player two "O"
			currentPlayer = players[0];
		}

		public bool GetTurn(int playerNumber)
		{
			//not indexed at 0 to avoid confusion
			//ex: playerOne == 1 and playerTwo == 2
			//if(playerNumber > 0 && playerNumber <= 2)
			return players[playerNumber - 1].GetTurn();
			//else throw exception
		}

		public string GetMark(int playerNumber)
		{
			//not indexed at 0 to avoid confusion
			//ex: playerOne == 1 and playerTwo == 2
			//if(playerNumber > 0 && playerNumber <= 2)
			return players[playerNumber - 1].GetMark();
			//else throw exception
		}
		public Player getPlayers(int playerNumber)
		{
			Player temp = players[playerNumber - 1];
			return temp;
		}
	}
}