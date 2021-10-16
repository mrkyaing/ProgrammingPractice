using System;
class ReturnDemo
{
    static void Main(){
       bool value=true;
       Console.WriteLine("Program start");
       if(value){
            Console.WriteLine("come from before return statement");
           return;
       }
       //this print line don't execute because return statement is already executed .
       Console.WriteLine("This don't execute.");
    }
}