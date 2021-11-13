using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.BankName = "KBZ";
            BankAccount.CurrentBalance = 50000;
            account.ShowBankInfo();
            BankAccount.CalculateTotal();

            TimeUtility.PrintTime();
            TimeUtility.PrintDate();

            Calculator calculator = new Calculator();
            int x = 10;
            calculator.Add1(x);
            Console.WriteLine($"x is {x}");//10
            calculator.Add2(ref x);
            Console.WriteLine($"x is {x}");//2010
            calculator.Add3(out x);
            Console.WriteLine($"x is {x}");//3000
            int n1 = 10, n2 = 12;
            if (calculator.IsEvenOrOdd(ref n1, ref n2))
            {
                Console.WriteLine("both n1 and n2 are even");
            }
            Console.WriteLine($"n1:{n1}");//11
            Console.WriteLine($"n2:{n2}");//13

            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
