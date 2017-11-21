using System;
using System.Drawing;
using System.Windows.Forms;

class MForm : Form {


    public MForm() {
        Text = "Anchor";
        Size = new Size(210, 210);

        Button btn1 = new Button();
        btn1.Text = "Button1";
        btn1.Parent = this;
        btn1.Location = new Point(0, 0);

        Button btn2 = new Button();
        btn2.Text = "Button2";
        btn2.Parent = this;
        btn2.Location = new Point(95, 0);

         Button btn3 = new Button();
        btn3.Text = "Button3";
        btn3.Parent = this;
        btn3.Location = new Point(195, 0);

         Button btn4 = new Button();
        btn4.Text = "Button4";
        btn4.Parent = this;
        btn4.Location = new Point(30, 80);

         Button btn5 = new Button();
        btn5.Text = "Button5";
        btn5.Parent = this;
        btn5.Location = new Point(30, 80);

         Button btn6 = new Button();
        btn6.Text = "Button6";
        btn6.Parent = this;
        btn6.Location = new Point(30, 80);
        

         Button btn7 = new Button();
        btn7.Text = "Button7";
        btn7.Parent = this;
        btn7.Location = new Point(30, 80);
        
         Button btn8 = new Button();
        btn8.Text = "Button8";
        btn8.Parent = this;
        btn8.Location = new Point(30, 80);
        
         Button btn9 = new Button();
        btn9.Text = "Button9";
        btn9.Parent = this;
        btn9.Location = new Point(30, 80);
        
        CenterToScreen();
    }
}


class MApplication {
    public static void Main() {
        MForm mf = new MForm();
        Application.Run(mf);
    }
}