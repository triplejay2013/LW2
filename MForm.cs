using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	class MForm : Form
	{
		Label label1;
		RichTextBox scoreBoard;
		Control control = Control.GetInstance();
		bool gameOver = false;
		Button[,] grid = new Button[3, 3];

		private void init()
		{
			label1 = new Label();
			label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label1.UseMnemonic = true;
			label1.Text = control.Current().GetName();
			label1.Size = new Size(300, 30);
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.Parent = this;

			Text = "Tic Tac Toe";
			this.AutoSize = true;
			String btn1String = "";
			String btn2String = "";
			String btn3String = "";
			String btn4String = "";
			String btn5String = "";
			String btn6String = "";
			String btn7String = "";
			String btn8String = "";
			String btn9String = "";

			int fontSize = 50;
			scoreBoard = new RichTextBox();
			scoreBoard.Font = new Font(scoreBoard.Font.FontFamily, 10);
			scoreBoard.Name = "ScoreBoard";
			scoreBoard.Size = new Size(100, 100);
			ScoreBoard();
			scoreBoard.Location = new Point(1, 160);
			scoreBoard.Anchor = (AnchorStyles.Bottom);
			scoreBoard.Parent = this;
			scoreBoard.Parent.Size = new Size(300, 500);

			scoreBoard.BringToFront();

			Button btn1 = buildButton(btn1String, 0, 50, fontSize);
			grid[0, 0] = btn1;

			Button btn2 = buildButton(btn2String, 100, 50, fontSize);
			grid[0, 1] = btn2;

			Button btn3 = buildButton(btn3String, 200, 50, fontSize);
			grid[0, 2] = btn3;

			Button btn4 = buildButton(btn4String, 0, 150, fontSize);
			grid[1, 0] = btn4;

			Button btn5 = buildButton(btn5String, 100, 150, fontSize);
			grid[1, 1] = btn5;

			Button btn6 = buildButton(btn6String, 200, 150, fontSize);
			grid[1, 2] = btn6;

			Button btn7 = buildButton(btn7String, 0, 250, fontSize);
			grid[2, 0] = btn7;

			Button btn8 = buildButton(btn8String, 100, 250, fontSize);
			grid[2, 1] = btn8;

			Button btn9 = buildButton(btn9String, 200, 250, fontSize);
			grid[2, 2] = btn9;
		}
		
		private Button buildButton(String buttonString, int x, int y, int fontSize)
		{
			Button button = new Button();
			button.Text = buttonString;
			button.Font = new Font(button.Font.FontFamily, fontSize);
			button.Parent = this;
			button.Location = new Point(x, y);
			button.Size = new Size(100, 100);
			button.Click += new EventHandler(this.selectTile);
			return button;
		}

		public MForm()
		{
			init();

			CenterToScreen();
		}

		void selectTile(Object sender, EventArgs e)
		{
			if (!gameOver)
			{
				Button clickedButton = (Button)sender;
				clickedButton.Text = control.GetMark(control.Current().GetNumber()); //use method to select X or O Dependant upon players turn
				clickedButton.Enabled = false;
				checkWin();
			}
			if (!gameOver)
			{
				control.Next();
				label1.Text = control.Current().GetName();
			}
		}

		private void checkWin()
		{
			bool winExists = false;

			//check rows for win
			for (int i = 0; i < 3; ++i)
			{
				bool matchingRow = true;
				for (int j = 1; j < 3; ++j)
				{
					if (grid[i, j].Text == "")
					{
						matchingRow = false;
						break;
					}
					if (grid[i, 0].Text != grid[i, j].Text)
					{
						matchingRow = false;
					}
				}
				if (matchingRow == true)
				{
					winExists = true;
					break;
				}
			}

			//check columns for win
			for (int j = 0; j < 3; ++j)
			{
				bool matchingCol = true;
				for (int i = 1; i < 3; ++i)
				{
					if (grid[i, j].Text == "")
					{
						matchingCol = false;
						break;
					}
					if (grid[0, j].Text != grid[i, j].Text)
					{
						matchingCol = false;
					}
				}
				if (matchingCol == true)
				{
					winExists = true;
					break;
				}
			}

			//check right diagonal \
			bool matchingDiagR = true;
			for (int i = 0; i < 3; ++i)
			{
				if (grid[0, 0].Text != grid[i, i].Text || grid[i, i].Text == "")
				{
					matchingDiagR = false;
				}
			}
			if (matchingDiagR == true)
			{
				winExists = true;
			}

			//check left diagonal /
			bool matchingDiagL = true;
			for (int i = 0; i < 3; ++i)
			{
				if (grid[0, 2].Text != grid[i, 2 - i].Text || grid[i, 2 - i].Text == "")
				{
					matchingDiagL = false;
				}
			}
			if (matchingDiagL == true)
			{
				winExists = true;
			}
			
			//check for win
			if (winExists == true)
			{
				control.Current().SetWin(true);
				gameOver = true;
				GameOverDisplay();
			}
			
			//check for draw
			int counter = 0;
			for (int i = 0; i < 3; ++i)
			{
				for (int j = 0; j < 3; ++j)
				{
					if (grid[i, j].Text != "")
					{
						++counter;
					}
				}
			}
			if (counter >= 9 && winExists == false)
			{
				gameOver = true;
				GameOverDisplay();
			}
			control.Current().SetWin(false);
		}
		public void ScoreBoard()
		{
			scoreBoard.Text = "SCORE :\n\nPlayer 1 :" + control.getPlayers(1).numOfWins() + "\nPlayer 2: " + control.getPlayers(2).numOfWins();
		}
		public void GameOverDisplay()
		{
			//displays an Alert that notify's user of winner and game over
			string message;
			if (control.Current().GetWin())
			{
				message = control.Current().GetName() + " won!";
				control.Current().incNumOfWins();
				ScoreBoard();
			}
			else
			{
				message = "Game ends in a draw!";
			}
			string caption = "GAME OVER";
			MessageBoxButtons buttons = MessageBoxButtons.OK;
			DialogResult result;

			// Displays the MessageBox.
			result = MessageBox.Show(message, caption, buttons);

			if (result == System.Windows.Forms.DialogResult.OK)
			{
				// Closes the parent form.
				DialogResult check = MessageBox.Show("Play Again?", "Again?", MessageBoxButtons.YesNo);
				if (check == DialogResult.Yes)
				{
					gameOver = false;
					foreach (Button x in grid)
					{
						x.Enabled = true;
						x.Text = "";
					}


				}
				else
				{
					this.Close();
				}


			}
		}
	}
}