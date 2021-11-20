using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class WarnningDialogWindow : Window
    {
        public override void Close()
        {
            Console.WriteLine("Warnning Dialog Window is closed");
        }

        public override void Open()
        {
            Console.WriteLine($"warning dialog window is open at:{base.Width} and {base.Height}");
        }
    }
}
