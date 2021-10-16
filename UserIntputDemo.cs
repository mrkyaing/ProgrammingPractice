using System;
class UserInputDemo
{
    static void Main()
    {
        Console.WriteLine("Program start");
        Console.Write("Please type your name:");
        string userName=Console.ReadLine();//get the keyboard' input 
        Console.Write("Please type your address:");
        string userAddress=Console.ReadLine();//get user input from the keyboard 
        Console.WriteLine("Hi,"+userName+" Nice to See you");
        Console.WriteLine("you live in "+userAddress);
    }
}