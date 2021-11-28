using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerOfAllAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartTimeStaff partTimeStaff = new PartTimeStaff()
            {
                Id = "s001",
                Name = "Su Su",
                Address = "Ygn",
                Age = 20,
                WorkingHours = 15
            };
            partTimeStaff.DisplayInfo();
            partTimeStaff.CalcualtePayroll();//105,000

            FullTimeStaff fullTimeStaff = new FullTimeStaff()
            {
                Id = "s002",
                Name = "Min Min",
                Age = 20,
                Address = "Mdy",
                BasicPay = 200000,
                AttendanceDays = 15,
                TransportationAllowance = 15000
            };
            fullTimeStaff.DisplayInfo();
            fullTimeStaff.CalcualtePayroll();

            Circle c = new Circle()
            {
                Color="Red",
                IsFilled=true,
                Radius=20
            };
            c.DisplayInfo();
            c.CalculateArea();
            c.CalculatePerimeter();

            Square square = new Square()
            {
                Color ="blue",
                IsFilled =true,
                Width=10,
                Height=40
            };
            square.DisplayInfo();
            square.CalculateArea();
            square.CalculatePerimeter();

            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
