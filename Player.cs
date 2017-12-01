using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	class Player
	{
		bool playersTurn;
		int playerNumber;
		string playerSymbol;
		bool playerWins = false;
		string name;
		int numWins;

		public bool GetWin()
		{
			return playerWins;
		}

		public void SetWin(bool flag)
		{
			playerWins = flag;
		}

		public string GetName()
		{
			return name;
		}

		public int GetNumber()
		{
			return playerNumber;
		}

		public bool GetTurn()
		{
			return playersTurn;
		}

		public string GetMark()
		{
			return playerSymbol;
		}
		public void incNumOfWins()
		{
			numWins++;
		}
		public int numOfWins()
		{
			return numWins;
		}

		public Player(int num)
		{
			playerNumber = num;
			playersTurn = false;
			this.numWins = 0;
			if (playerNumber == 1)
			{
				playerSymbol = "X";
				name = "Player One (X)";
			}
			else if (playerNumber == 2)
			{
				playerSymbol = "O";
				name = "Player Two (O)";
			}
		}

		public Player(bool turn)
		{
			playerNumber = 1;
			name = "Player One (X)";
			playersTurn = turn;
		}

		public Player(bool turn, int num)
		{
			this.numWins = 0;
			playerNumber = num;
			playersTurn = turn;
			if (playerNumber == 1)
			{
				playerSymbol = "X";
				name = "Player One (X)";
			}
			else if (playerNumber == 2)
			{
				playerSymbol = "O";
				name = "Player Two (O)";
			}
		}
	}
}