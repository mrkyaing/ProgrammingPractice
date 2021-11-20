using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class Calculator
    {

        //same method name with different parameter or type 
        //that is called method overloading (compile time polymorphism)
        public void Add(int n1,int n2)
        {
            int result=n1 + n2;
            Console.WriteLine($"two int value adding result is{result}");
        }
        public void Add(int n1, int n2, int n3)
        {
            int result = n1 + n2 + n3;
            Console.WriteLine($"three int value adding result is{result}");
        }
        public void Add(double n1,double n2)
        {
            double result = n1 + n2;
            Console.WriteLine($"two double value adding result is{result}");
        }
        public void Add(double n1, int n2)
        {
            double result = n1 + n2;
            Console.WriteLine($"two double value adding result is{result}");
        }
    }
}
