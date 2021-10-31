using System;
class Factorial
{
static void Main()
{
   try{
        Console.Write("Enter a Number:");
    int num=Convert.ToInt32(Console.ReadLine());//4!=1*2*3*4
    int result=1;
    int i=1;
    while(i<=num)//4<3
    {
     result*=i;//1*1,1 >>2*1,2 >>>>>>>>>3*2=6 
    i++;
    }
    Console.WriteLine("The Facorial of "+num +" is "+result);
   }
   catch(Exception e){
       Console.WriteLine("Humm......Sorry we cannot calculate your input value!!");
   }
}
}