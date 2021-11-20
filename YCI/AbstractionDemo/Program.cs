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
           
            PayrollService payrollService = new PayrollService();
            payrollService.CalculatePayroll();
            payrollService.CalculateBonus();

            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
