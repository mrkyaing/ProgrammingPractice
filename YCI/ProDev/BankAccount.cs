using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDev
{
    public class BankAccount
    {
        public string BankName { get; set; }
        public static double CurrentBalance { get; set; }
        private static double InterestRate = 0.5;
        public static void CalculateTotal()
        {
            double total = CurrentBalance * InterestRate + CurrentBalance;
            Console.WriteLine($"Total:{total}");
        }
       public void ShowBankInfo()
        {
            Console.WriteLine($"Bank name:{BankName}");
            Console.WriteLine($"Current Balance:{CurrentBalance}");
        }
    }
}
