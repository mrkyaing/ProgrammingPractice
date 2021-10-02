using System;
class Day6Demo{
    static void Main(){
        int FirstNumber=10;//declare the variable and assignment value 10 
        int SecondNumber=20;
        int ThirdNumber=0;
        ThirdNumber++;//1>>++ is called increment operator 
        ThirdNumber++;//2
        int Reuslt=FirstNumber+SecondNumber+ThirdNumber;
        Console.WriteLine("The Final Result is "+Reuslt);//32
        Reuslt--;
        Console.WriteLine("Result after -- decrement Operator apply on it "+Reuslt);//31
        int x=10;
        int y=2;
        x+=11;// x= x+11 >>10+11
        Console.WriteLine("x values is "+x);//21
        y+=x;// y=y+x >>2+21 
        Console.WriteLine("y value is "+y);//23
        int value1=3;
            value1*=3;// value1=value1*3 ; 
        Console.WriteLine("final value of value1 is "+value1);//9
    }//end of Main Method 
}//end of class 