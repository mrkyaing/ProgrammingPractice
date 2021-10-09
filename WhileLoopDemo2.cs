using System;
class WhileLoopDemo2{
    static void Main(){
        int i=1,result=0;
        while(i<=10){
         result+=i;// result=0+1;
         i++;//increment i 
        }
        Console.WriteLine("Sum Value of From 1 to 10 is "+result);
    }
}