using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack=new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(55);
            stack.Push(5);
            stack.Push(66);
            stack.Push(99);
            stack.Display();//
            stack.Pop();//99
            stack.Pop();//5
            stack.Pop();//55
            MyStack<string> stack2 = new MyStack<string>();
            stack2.Push("hi");
            stack2.Push("Hello");
            stack2.Display();
            
            MyStack<User> stack3=new MyStack<User>();
            User user1 = new User()
            {
                Name="mgmg",Email="mgmg@gmail.com",Id=1
            };
            User user2 = new User()
            {
                Name = "susu",
                Email = "susu@gmail.com",
                Id = 2
            };
            stack3.Push(user1);
            stack3.Push(user2);
            stack3.Display();

            Point<int> p1=new Point<int>(10,10);
            Console.WriteLine(p1.ToString());//[10,10]
            p1.ReSet();
            Console.WriteLine(p1.ToString());
            Point<string> p2 = new Point<string>("hi", "hello");
            Console.WriteLine(p2.ToString());
            p2.ReSet();
            Console.WriteLine(p2.ToString());

            TwoTypePamameter<int, string> twotype1 = new TwoTypePamameter<int, string>();
            twotype1.TFirsetObject = 10;
            twotype1.VSecondObject = "Hi";
            Console.WriteLine(twotype1.ToString());//int ,string 
            Console.WriteLine(twotype1.TFirsetObject);//10
            Console.WriteLine(twotype1.VSecondObject);//hi

            Console.ReadKey();

        }
    }
}
