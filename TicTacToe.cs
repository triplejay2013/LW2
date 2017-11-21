using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe {
    class MForm : Form{
        public MForm(){
            Text = "TicTacToe";
            Size = new Size(500, 500);

            DataGridView board = new DataGridView();

            CenterToScreen();
        }
    }

    private void SetupLayout(){

    }

    class Program {
        public static void Main(){
            Application.Run(new MForm());
        }
    }
}