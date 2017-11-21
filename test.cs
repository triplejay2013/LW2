using System;
using System.Drawing;
using System.Windows.Forms;

class MForm : Form {


    public MForm() {
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

        int fontSize = 100;

        Button btn1 = new Button();
        btn1.Text = btn1String;
        btn1.Font = new Font(btn1.Font.FontFamily, fontSize);
        btn1.Parent = this;
        btn1.Location = new Point(0, 0);
        btn1.Size = new Size(100, 100);

        Button btn2 = new Button();
        btn2.Text = btn2String;
        btn2.Font = new Font(btn2.Font.FontFamily, fontSize);
        btn2.Parent = this;
        btn2.Location = new Point(100, 0);
        btn2.Size = new Size(100, 100);

        Button btn3 = new Button();
        btn3.Text = btn3String;
        btn3.Font = new Font(btn3.Font.FontFamily, fontSize);
        btn3.Parent = this;
        btn3.Location = new Point(200, 0);
        btn3.Size = new Size(100, 100);

        Button btn4 = new Button();
        btn4.Text = btn4String;
        btn4.Font = new Font(btn4.Font.FontFamily, fontSize);
        btn4.Parent = this;
        btn4.Location = new Point(0, 100);
        btn4.Size = new Size(100, 100);
         
        Button btn5 = new Button();
        btn5.Text = btn5String;
        btn5.Font = new Font(btn5.Font.FontFamily, fontSize);
        btn5.Parent = this;
        btn5.Location = new Point(100, 100);
        btn5.Size = new Size(100, 100);
        
        Button btn6 = new Button();
        btn6.Text = btn6String;
        btn6.Font = new Font(btn6.Font.FontFamily, fontSize);
        btn6.Parent = this;
        btn6.Location = new Point(200, 100);
        btn6.Size = new Size(100, 100);

        Button btn7 = new Button();
        btn7.Text = btn7String;
        btn7.Font = new Font(btn7.Font.FontFamily, fontSize);
        btn7.Parent = this;
        btn7.Location = new Point(0, 200);
        btn7.Size = new Size(100, 100);
        
        Button btn8 = new Button();
        btn8.Text = btn8String;
        btn8.Font = new Font(btn8.Font.FontFamily, fontSize);
        btn8.Parent = this;
        btn8.Location = new Point(100, 200);
        btn8.Size = new Size(100, 100);
        
        Button btn9 = new Button();
        btn9.Text = btn9String;
        btn9.Font = new Font(btn9.Font.FontFamily, fontSize);
        btn9.Parent = this;
        btn9.Location = new Point(200, 200);
        btn9.Size = new Size(100, 100);
        CenterToScreen();
    }
}


class MApplication {
    public static void Main() {
        MForm mf = new MForm();
        Application.Run(mf);
    }
}