using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class PayrollService : IPayrollService
    {
        public void CalculateBonus(Staff staff)
        {
            Console.WriteLine($"Bouns amount of this month is 30000");
        }

        public double CalculatePayroll(Staff staff)
        {
            //တစ်ရက်စာ amout ရှာ .ရုံးတက်ရက်နဲ့ ပြန် *
            int workingday = 31;
            int attendancedays = 31;
            double totalAmout = (staff.BaseSalary / workingday) * attendancedays;
            Console.WriteLine($"Total Pay amount of this Month is {totalAmout}");
            return totalAmout;
        }
    }
}
