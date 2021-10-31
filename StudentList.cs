using System;
class StudentList{
    static void Main(){
         Console.Write("Enter number of values     :");
        int numberOfValue=Convert.ToInt32(Console.ReadLine());
        string []names=new string[numberOfValue];  
        for (int i = 0; i < numberOfValue; i++)
        {
            Console.Write("Enter student "+(i+1)+" Name   :");
            names[i]=Console.ReadLine();
        }
        Console.WriteLine("No   Name ");
        Console.WriteLine("==   =====");
        for (int i = 0; i <numberOfValue; i++)
        {
            Console.Write((i+1)+"  "+names[i]+"\n");
        }
    }
}