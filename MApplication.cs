using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//I compiled this code using the following
/*
   mcs -r:System.Windows.Forms.dll -r:System.Drawing.dll *.cs -out:run.exe
*/

namespace TicTacToe
{
    class MApplication
    {
        public static void Main()
        {
            MForm mf = new MForm();
            Application.Run(mf);
        }
    }
}