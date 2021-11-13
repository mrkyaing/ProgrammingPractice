using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDev
{
    public static class TimeUtility
    {
        public static void PrintTime()
        {
            Console.WriteLine($"Current Time:{DateTime.Now.ToShortTimeString()}");
        }
        public static void PrintDate()
        {
            Console.WriteLine($"Print Date:{DateTime.Now.ToShortDateString()}");
        }
    }
}
