using System;
using System.Drawing;
using System.Windows.Forms;

class MForm : Form {


    public MForm() {
        Text = "Anchor";
        Size = new Size(350, 350);

        Button btn1 = new Button();
        btn1.Text = "Button1";
        btn1.Parent = this;
        btn1.Location = new Point(0, 0);
        btn1.Size = new Size(100, 100);

        Button btn2 = new Button();
        btn2.Text = "Button2";
        btn2.Parent = this;
        btn2.Location = new Point(100, 0);
        btn2.Size = new Size(100, 100);

         Button btn3 = new Button();
        btn3.Text = "Button3";
        btn3.Parent = this;
        btn3.Location = new Point(200, 0);
        btn3.Size = new Size(100, 100);

         Button btn4 = new Button();
        btn4.Text = "Button4";
        btn4.Parent = this;
        btn4.Location = new Point(0, 100);
        btn4.Size = new Size(100, 100);
         
         Button btn5 = new Button();
        btn5.Text = "Button5";
        btn5.Parent = this;
        btn5.Location = new Point(100, 100);
        btn5.Size = new Size(100, 100);
        
         Button btn6 = new Button();
        btn6.Text = "Button6";
        btn6.Parent = this;
        btn6.Location = new Point(200, 100);
        btn6.Size = new Size(100, 100);

         Button btn7 = new Button();
        btn7.Text = "Button7";
        btn7.Parent = this;
        btn7.Location = new Point(0, 200);
        btn7.Size = new Size(100, 100);
         Button btn8 = new Button();
        btn8.Text = "Button8";
        btn8.Parent = this;
        btn8.Location = new Point(100, 200);
        btn8.Size = new Size(100, 100);
         Button btn9 = new Button();
        btn9.Text = "Button9";
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