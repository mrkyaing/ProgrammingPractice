using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class AlertDialogWindow : Window
    {
        //say how (now) >>means you must implement your abstract method of parent
        public override void Close()
        {
            Console.WriteLine("alert dialog window are closing now.");
        }

        public override void Open()
        {
            Console.WriteLine($"Alert dialog window is open at:{base.Width} and {base.Height}");
        }
    }
}
