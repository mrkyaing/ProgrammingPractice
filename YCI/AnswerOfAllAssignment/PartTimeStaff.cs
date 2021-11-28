using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerOfAllAssignment
{
    public class PartTimeStaff : Staff
    {
        public float WorkingHours { get; set; }
        public override void CalcualtePayroll()
        {
            //(((basicPay/workingDays)*attendanceDays)+benefit)-ded
            float workingHourRate = 7000;
            float benefit = 0;
            float deduction = 0;
            float result = (workingHourRate*WorkingHours) + benefit - deduction;
            Console.WriteLine($"Payroll of this month:{result}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Working Hour(s){WorkingHours}");
        }
    }
}
