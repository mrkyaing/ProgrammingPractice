using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Add(1, 2);
            calculator.Add(1, 2, 3);
            calculator.Add(2.3, 9.5);
            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
