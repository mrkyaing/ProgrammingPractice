using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class ErrorDialogWindow : Window
    {
        public override void Close()
        {
            Console.WriteLine("Error Dialog Window is closed");
        }

        public override void Open()
        {
            Console.WriteLine($"Error dialog window is open at:{base.Width} and {base.Height}");
        }
    }
}
