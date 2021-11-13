using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCI
{
    public class SmartPhone:Phone
    {
        public void TakeCamera(string captureType)
        {
            if (captureType.Equals("image"))
            {
                Console.WriteLine("Capture image.");
            }
            else
            {
                Console.WriteLine("Capture Video.");
            }          
        }
        public void UseMobileData()
        {
            Console.WriteLine("using mobile data.");
        }
    }
}
