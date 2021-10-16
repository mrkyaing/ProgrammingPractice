using System;
class UserInputDemo2
{
    static void Main()
    {
        Console.Write("Enter your name:");
        string userName=Console.ReadLine();
        Console.Write("Enter your age:");
        int age=Convert.ToInt32(Console.ReadLine());
        if(age>40)
        {
            Console.WriteLine("Hi,"+userName);
            Console.WriteLine("You are mature.");
        }
        else{
            Console.WriteLine("Hi,"+userName);
            Console.WriteLine("You are not mature.");
        }
    }
}