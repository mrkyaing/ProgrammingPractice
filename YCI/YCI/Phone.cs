using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCI
{
    public class Phone:ElectronicDevice
    {
        public void MakeDial()
        {
            Console.WriteLine("Dialing");
        }
        public void SendSMS()
        {
            Console.WriteLine("sending sms");
        }
        public void PressKeys()
        {
            Console.WriteLine("pressing a key.");
        }
    }
}
