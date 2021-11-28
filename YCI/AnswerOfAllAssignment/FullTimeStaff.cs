using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerOfAllAssignment
{
    public class FullTimeStaff : Staff
    {
        public float TransportationAllowance { get; set; }
        public float AttendanceDays { get; set; }

        public float BasicPay { get; set; }
        public override void CalcualtePayroll()
        {
            //(((basicPay/workingDays)*attendanceDays)+benefit)-ded
            int workingDays = 30;
            float benefit = TransportationAllowance;
            float deduction = 500;
            float result=(BasicPay/workingDays)*AttendanceDays+benefit-deduction;
            Console.WriteLine($"Payroll of this month:{result}");
        }
         
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Basic Pay:{BasicPay}");
            Console.WriteLine($"Attendance Days:{BasicPay}");
            Console.WriteLine($"Benefit:{TransportationAllowance}");
        }
    }
}
