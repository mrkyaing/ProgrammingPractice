using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class BankAccount : ICreditCardService,IShowDetailInfo
    {
        
        public string BankAccountType { get; set; }
        public string AccountNo { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; set; }
        public DateTime ManufacturedDate { get; set; }
        public bool IsValid { get; set; }

        public void GetDollorsExchangeRate(double baseAmount)
        {
            //1930
            double result = 1930 * baseAmount;
            Console.WriteLine($"Dollor {baseAmount} is equal in {result} MMK");
        }

        public void GetPoundsExchangeRate(double baseAmount)
        {
            double result = 2380 * baseAmount;
            Console.WriteLine($"Pound {baseAmount} is equal in {result} MMK");
        }

        public void GetRupeesExchangeRate(double baseAmount)
        {
            double result = 23 * baseAmount;
            Console.WriteLine($"Rupee {baseAmount} is equal in {result} MMK");
        }

        public void GetSGDolorsExchangeRate(double baseAmount)
        {
            double result = 1300 * baseAmount;
            Console.WriteLine($"SG Dolor {baseAmount} is equal in {result} MMK");
        }

        public void ShowDetailInfo()
        {
            Console.WriteLine($"Bank Account Type{BankAccountType}");
            Console.WriteLine($"Bank Account No{AccountNo}");
            Console.WriteLine($"Bank Account Balance{Balance} in MMK");
            Console.WriteLine($"Bank Account Issued Date{ManufacturedDate}");
            Console.WriteLine($"Bank Account Holder Name{AccountHolderName}");
            Console.WriteLine($"Bank Account Card is still Valid? {IsValid}");
        }
    }
}
