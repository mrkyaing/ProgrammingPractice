using System;
class MathIntoDemo
{
 static void Main()
 {
     for(int row=1;row<=5;row++){
         for(int col=1;col<=12;col++){
             Console.Write(row*col + " ");//1*1
         }
         Console.WriteLine();
     }
 }
}