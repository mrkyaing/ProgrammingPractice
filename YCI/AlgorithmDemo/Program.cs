using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int pass = 0;
            int fail = 0;
            int student = 1;
            while (student <= 10)
            {
                Console.Write($"Enter exam mark of student {student}:");
                int mark=Convert.ToInt32(Console.ReadLine());
                if (mark >= 40)
                {
                    pass++;
                }
                else
                {
                    fail++;
                }
                student++;
            }
            Console.WriteLine($"Number of passed student {pass}");
            Console.WriteLine($"Number of failed student {fail}");
            if (pass >= 8)
            {
                Console.WriteLine($"raise tution grade");
            }

            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
