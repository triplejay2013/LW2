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

	public void Next(){
		if(currentPlayer.GetNumber()==1){
			currentPlayer = players[1];
		} else if(currentPlayer.GetNumber()==2){
			currentPlayer = players[0];
		}
	}

	public Player Current(){
		return currentPlayer;
	}

	private Control(){
		Init();
	}

	public static Control GetInstance(){
		if(instance==null)
			instance=new Control();
		return instance;
	}

	private void Init(){
		players = new Player[2];
		players[0] = new Player(true, 1);//Player one "X"
		players[1] = new Player(false, 2);//Player two "O"
		currentPlayer = players[0];
	}

	public bool GetTurn(int playerNumber){
		//not indexed at 0 to avoid confusion
		//ex: playerOne == 1 and playerTwo == 2
		//if(playerNumber > 0 && playerNumber <= 2)
			return players[playerNumber-1].GetTurn();
		//else throw exception
	}

	public string GetMark(int playerNumber){
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

	public int GetNumber(){
		return playerNumber;
	}

	public bool GetTurn(){
		return playersTurn;
	}

	public string GetMark(){
		return playerSymbol;
	}

	public Player(int num){
		playerNumber=num;
		playersTurn=false;
		if(playerNumber==1){playerSymbol="X";}
		else if(playerNumber==2){playerSymbol="O";}
	}
	
	public Player(bool turn){
		playerNumber=1;
		playersTurn=turn;
	}
	
	public Player(bool turn, int num){
		playerNumber=num;
		playersTurn=turn;
		if(playerNumber==1){playerSymbol="X";}
		else if(playerNumber==2){playerSymbol="O";}
	}
}

class MForm : Form {
	Control control = Control.GetInstance();

	private void init(){
        Text = "Tic Tac Toe";
        Size = new Size(325, 350);
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
        btn1.Location = new Point(0, 0);
        btn1.Size = new Size(100, 100);
		btn1.Click += new EventHandler(this.selectTile);

        Button btn2 = new Button();
        btn2.Text = btn2String;
        btn2.Font = new Font(btn2.Font.FontFamily, fontSize);
        btn2.Parent = this;
        btn2.Location = new Point(100, 0);
        btn2.Size = new Size(100, 100);
		btn2.Click += new EventHandler(this.selectTile);

        Button btn3 = new Button();
        btn3.Text = btn3String;
        btn3.Font = new Font(btn3.Font.FontFamily, fontSize);
        btn3.Parent = this;
        btn3.Location = new Point(200, 0);
        btn3.Size = new Size(100, 100);
		btn3.Click += new EventHandler(this.selectTile);

        Button btn4 = new Button();
        btn4.Text = btn4String;
        btn4.Font = new Font(btn4.Font.FontFamily, fontSize);
        btn4.Parent = this;
        btn4.Location = new Point(0, 100);
        btn4.Size = new Size(100, 100);
		btn4.Click += new EventHandler(this.selectTile);
         
        Button btn5 = new Button();
        btn5.Text = btn5String;
        btn5.Font = new Font(btn5.Font.FontFamily, fontSize);
        btn5.Parent = this;
        btn5.Location = new Point(100, 100);
        btn5.Size = new Size(100, 100);
		btn5.Click += new EventHandler(this.selectTile);
        
        Button btn6 = new Button();
        btn6.Text = btn6String;
        btn6.Font = new Font(btn6.Font.FontFamily, fontSize);
        btn6.Parent = this;
        btn6.Location = new Point(200, 100);
        btn6.Size = new Size(100, 100);
		btn6.Click += new EventHandler(this.selectTile);

        Button btn7 = new Button();
        btn7.Text = btn7String;
        btn7.Font = new Font(btn7.Font.FontFamily, fontSize);
        btn7.Parent = this;
        btn7.Location = new Point(0, 200);
        btn7.Size = new Size(100, 100);
		btn7.Click += new EventHandler(this.selectTile);
        
        Button btn8 = new Button();
        btn8.Text = btn8String;
        btn8.Font = new Font(btn8.Font.FontFamily, fontSize);
        btn8.Parent = this;
        btn8.Location = new Point(100, 200);
        btn8.Size = new Size(100, 100);
		btn8.Click += new EventHandler(this.selectTile);
        
        Button btn9 = new Button();
        btn9.Text = btn9String;
        btn9.Font = new Font(btn9.Font.FontFamily, fontSize);
        btn9.Parent = this;
        btn9.Location = new Point(200, 200);
        btn9.Size = new Size(100, 100);
		btn9.Click += new EventHandler(this.selectTile);
	}

    public MForm() {
		init();

        CenterToScreen();
    }

	void selectTile(Object sender, EventArgs e){
		Button clickedButton = (Button) sender;
		clickedButton.Text = control.GetMark(control.Current().GetNumber()); //use method to select X or O Dependant upon players turn
		clickedButton.Enabled = false;
		control.Next();
	}
}


class MApplication {
    public static void Main() {
        MForm mf = new MForm();
        Application.Run(mf);
    }
}
