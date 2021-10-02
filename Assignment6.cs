using System;
class Assignment6
{
    static void Main()
    {
        string l1="C# is a strongly typed object-oriented programming language. \n";
        string l2="C# is open source, simple, modern, flexible, and versatile. \n";
        string l3="C# is a programming language developed and launched by Microsoft in 2001.\n";
        string l4="C# is a simple, modern, and object-oriented language that provides modern day developers flexibility and features to build software that will not only work today but will be applicable for years in the future.";
       string msg=l1+l2+l3+l4;
       Console.WriteLine(msg);
       Console.WriteLine("Length of msg is "+msg.Length);
       Console.WriteLine("ALL CAPITAL LETTER  of msg is "+msg.ToUpper());
       Console.WriteLine("Check C# text in string is "+msg.Contains("C#"));//output will be True
       Console.WriteLine("Check $ text in string is "+msg.Contains("$"));//output will be False
       Console.WriteLine("Check Programming text in string is "+msg.Contains("Programming"));//output will be False 
    }
}