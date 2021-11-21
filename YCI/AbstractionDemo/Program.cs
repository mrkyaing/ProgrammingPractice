using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Window wd=new Window(); 
            AlertDialogWindow alertDialog = new AlertDialogWindow()
            {
                Title = "alert",
                Width = 200,
                Height = 200
            };
            alertDialog.Open();
            alertDialog.DiaplayInfo();
            alertDialog.Close();
            WarnningDialogWindow warnDialog = new WarnningDialogWindow()
            {

                Title = "warning",
                Width = 250,
                Height = 250
            };
            warnDialog.Open();
            warnDialog.DiaplayInfo();
            warnDialog.Close();
            ErrorDialogWindow errorDialog = new ErrorDialogWindow()
            {
                Title = "Error",
                Width = 250,
                Height = 250
            };
            errorDialog.Open();
            errorDialog.DiaplayInfo();
            errorDialog.Close();

            Staff staff1 = new Staff()
            {
                Name = "U Min Hla",
                StaffId = "SD-001",
                Department = "Admin Dept",
                JoinedDate = Convert.ToDateTime("12-10-2018"),
                BaseSalary = 200000,
                Email="minhal@yahoo.com",
                Phone="09265894512",
                Position="Administration"
            };
            staff1.ShowDetailInfo();
            
            PayrollService payrollService = new PayrollService();
            payrollService.CalculatePayroll(staff1);
            payrollService.CalculateBonus(staff1);

            BankAccount myAccount = new BankAccount()
            {
                Balance = 2000,
                AccountHolderName =staff1.Name,
                AccountNo = "0568952315456236",
                BankAccountType = "Current",
                ManufacturedDate = Convert.ToDateTime("10-12-2019"),
                IsValid = true
            };
            myAccount.GetDollorsExchangeRate(300);
            myAccount.ShowDetailInfo();
            myAccount.Balance +=payrollService.CalculatePayroll(staff1);//200000+2000
            Console.WriteLine($"Your balance after payroll:{myAccount.Balance}");
            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
