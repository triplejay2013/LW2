//I compiled this code using the following
/*
   mcs -r:System.Windows.Forms.dll -r:System.Drawing.dll ticTacToe.cs -out:run.exe
*/
using System;
using System.Drawing;
using System.Windows.Forms;

class Control {//Singleton class
    private static Control instance = null;
    Player[] players;
    Player currentPlayer;

    public void Next() {
        if(currentPlayer.GetNumber()==1) {
            currentPlayer = players[1];
        } else if(currentPlayer.GetNumber()==2) {
            currentPlayer = players[0];
        }
    }

    public Player Current() {
        return currentPlayer;
    }

    private Control() {
        Init();
    }

    public static Control GetInstance() {
        if(instance==null)
            instance=new Control();
        return instance;
    }

    private void Init() {
        players = new Player[2];
        players[0] = new Player(true, 1);//Player one "X"
        players[1] = new Player(false, 2);//Player two "O"
        currentPlayer = players[0];
    }

    public bool GetTurn(int playerNumber) {
        //not indexed at 0 to avoid confusion
        //ex: playerOne == 1 and playerTwo == 2
        //if(playerNumber > 0 && playerNumber <= 2)
        return players[playerNumber-1].GetTurn();
        //else throw exception
    }

    public string GetMark(int playerNumber) {
        //not indexed at 0 to avoid confusion
        //ex: playerOne == 1 and playerTwo == 2
        //if(playerNumber > 0 && playerNumber <= 2)
        return players[playerNumber-1].GetMark();
        //else throw exception
    }
}

class Player {
    bool playersTurn;
    int playerNumber;
    string playerSymbol;
    bool playerWins=false;
	string name;

    public bool GetWin() {
        return playerWins;
    }

    public void SetWin(bool flag) {
        playerWins=flag;
    }

	public string GetName(){
		return name;
	}

    public int GetNumber() {
        return playerNumber;
    }

    public bool GetTurn() {
        return playersTurn;
    }

    public string GetMark() {
        return playerSymbol;
    }

    public Player(int num) {
        playerNumber=num;
        playersTurn=false;
        if(playerNumber==1) {
            playerSymbol="X";
			name = "Player One (X)";
        }
        else if(playerNumber==2) {
            playerSymbol="O";
			name = "Player Two (O)";
        }
    }

    public Player(bool turn) {
        playerNumber=1;
		name = "Player One (X)";
        playersTurn=turn;
    }

    public Player(bool turn, int num) {
        playerNumber=num;
        playersTurn=turn;
        if(playerNumber==1) {
            playerSymbol="X";
			name = "Player One (X)";
        }
        else if(playerNumber==2) {
            playerSymbol="O";
			name = "Player Two (O)";
        }
    }
}

class MForm : Form {
	Label label1;
    Control control = Control.GetInstance();
    bool gameOver = false;
    Button[,] grid = new Button[3,3];

    private void init() {
        label1 = new Label();
        label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        label1.UseMnemonic = true;
        label1.Text = control.Current().GetName();
        label1.Size = new Size (300, 30);
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

        Button btn1 = new Button();
        btn1.Text = btn1String;
        btn1.Font = new Font(btn1.Font.FontFamily, fontSize);
        btn1.Parent = this;
        btn1.Location = new Point(0, 50);
        btn1.Size = new Size(100, 100);
        btn1.Click += new EventHandler(this.selectTile);
        grid[0,0] = btn1;

        Button btn2 = new Button();
        btn2.Text = btn2String;
        btn2.Font = new Font(btn2.Font.FontFamily, fontSize);
        btn2.Parent = this;
        btn2.Location = new Point(100, 50);
        btn2.Size = new Size(100, 100);
        btn2.Click += new EventHandler(this.selectTile);
        grid[0,1] = btn2;

        Button btn3 = new Button();
        btn3.Text = btn3String;
        btn3.Font = new Font(btn3.Font.FontFamily, fontSize);
        btn3.Parent = this;
        btn3.Location = new Point(200, 50);
        btn3.Size = new Size(100, 100);
        btn3.Click += new EventHandler(this.selectTile);
        grid[0,2] = btn3;

        Button btn4 = new Button();
        btn4.Text = btn4String;
        btn4.Font = new Font(btn4.Font.FontFamily, fontSize);
        btn4.Parent = this;
        btn4.Location = new Point(0, 150);
        btn4.Size = new Size(100, 100);
        btn4.Click += new EventHandler(this.selectTile);
        grid[1,0] = btn4;

        Button btn5 = new Button();
        btn5.Text = btn5String;
        btn5.Font = new Font(btn5.Font.FontFamily, fontSize);
        btn5.Parent = this;
        btn5.Location = new Point(100, 150);
        btn5.Size = new Size(100, 100);
        btn5.Click += new EventHandler(this.selectTile);
        grid[1,1] = btn5;

        Button btn6 = new Button();
        btn6.Text = btn6String;
        btn6.Font = new Font(btn6.Font.FontFamily, fontSize);
        btn6.Parent = this;
        btn6.Location = new Point(200, 150);
        btn6.Size = new Size(100, 100);
        btn6.Click += new EventHandler(this.selectTile);
        grid[1,2] = btn6;

        Button btn7 = new Button();
        btn7.Text = btn7String;
        btn7.Font = new Font(btn7.Font.FontFamily, fontSize);
        btn7.Parent = this;
        btn7.Location = new Point(0, 250);
        btn7.Size = new Size(100, 100);
        btn7.Click += new EventHandler(this.selectTile);
        grid[2,0] = btn7;

        Button btn8 = new Button();
        btn8.Text = btn8String;
        btn8.Font = new Font(btn8.Font.FontFamily, fontSize);
        btn8.Parent = this;
        btn8.Location = new Point(100, 250);
        btn8.Size = new Size(100, 100);
        btn8.Click += new EventHandler(this.selectTile);
        grid[2,1] = btn8;

        Button btn9 = new Button();
        btn9.Text = btn9String;
        btn9.Font = new Font(btn9.Font.FontFamily, fontSize);
        btn9.Parent = this;
        btn9.Location = new Point(200, 250);
        btn9.Size = new Size(100, 100);
        btn9.Click += new EventHandler(this.selectTile);
        grid[2,2] = btn9;
    }

    public MForm() {
        init();

        CenterToScreen();
    }

    void selectTile(Object sender, EventArgs e) {
        if(!gameOver) {
            Button clickedButton = (Button) sender;
            clickedButton.Text = control.GetMark(control.Current().GetNumber()); //use method to select X or O Dependant upon players turn
            clickedButton.Enabled = false;
            checkWin();
        }
        if(!gameOver){
            control.Next();
			label1.Text = control.Current().GetName();
		}
    }

    private void checkWin() {
        int counter = 0;
        //check for draw
        for(int i = 0; i < 3; ++i) {
            for(int j = 0; j < 3; ++j) {
                if(grid[i,j].Text != "") {
                    ++counter;
                }
            }
        }
        if(counter>=9) {
            gameOver = true;
            GameOverDisplay();
        }
        control.Current().SetWin(false);

        //check rows for win
        for(int i = 0; i < 3; ++i) {
            counter = 1;
            for(int j = 0; j < 2; ++j) {
                if(grid[i,j].Text == grid[i,j+1].Text && grid[i,j].Text != "") {
                    ++counter;
                }
            }
            if(counter == 3) break;
        }
        if(counter == 3) {
            control.Current().SetWin(true);
            gameOver = true;
            GameOverDisplay();
        }

        //check verticles for win
        counter = 0;
        if(grid[0,0].Text == grid[1,0].Text && grid[1,0].Text == grid[2,0].Text && grid[0,0].Text != "") {
            ++counter;
        }
        else if(grid[0,1].Text == grid[1,1].Text && grid[1,1].Text == grid[2,1].Text && grid[0,1].Text != "") {
            ++counter;
        }
        else if(grid[0,2].Text == grid[1,2].Text && grid[1,2].Text == grid[2,2].Text && grid[0,2].Text != "") {
            ++counter;
        }
        if(counter != 0) {
            control.Current().SetWin(true);
            gameOver = true;
            GameOverDisplay();
        }

        //check right diagonal \
        counter = 0;
        string match = "";
        for(int i = 0; i < 3; ++i) {
            if(grid[i, i].Text != "" && i == 0) {
                match = grid[i, i].Text;
                ++counter;
            }
            else if(match == grid[i, i].Text && grid[i, i].Text != "") {
                ++counter;
            }
        }
        if(counter == 3) {
            control.Current().SetWin(true);
            gameOver = true;
            GameOverDisplay();
        }

        //check left diagonal /
        counter = 0;
        match = "";
        for(int i = 0; i < 3; ++i) {
            if(grid[i, 2-i].Text != "" && i == 0) {
                match = grid[i, 2-i].Text;
                ++counter;
            }
            else if(match == grid[i, 2-i].Text && grid[i, 2-i].Text != "") {
                ++counter;
            }
        }
        if(counter == 3) {
            control.Current().SetWin(true);
            gameOver = true;
            GameOverDisplay();
        }
    }

    public void GameOverDisplay() {
        //displays an Alert that notify's user of winner and game over
        string message;
        if(control.Current().GetWin()) {
            message = control.Current().GetName() + " won!";
        }
        else {
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
            //TODO: if time, we can make an option to reset the game, or close
            this.Close();

        }
    }
}


class MApplication {
    public static void Main() {
        MForm mf = new MForm();
        Application.Run(mf);
    }
}
