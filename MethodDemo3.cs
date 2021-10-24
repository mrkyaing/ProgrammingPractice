using System;
class MethodDemo3{
    static void Main(){
        Console.Write("Please a number 1:");
        int num1=int.Parse(Console.ReadLine());//1
        Console.Write("Please a number 2:");
        int num2=int.Parse(Console.ReadLine());//3
        int finalresult=Add(num1,num2);//call Add Method 
        //same output like that 
        Console.WriteLine("{0} + {1} is {2}",num1,num2,finalresult);//1 + 2 is 3 .
        int substractResult=Substract(num1,num2);//call Substract method and store value 
        Console.WriteLine("{0} - {1} is {2}",num1,num2,substractResult);
        bool isEvenResult=IsEven(num1);//call IsEven Method 
        Console.WriteLine("{0} is even? {1}",num1,isEvenResult);

        Console.WriteLine("press any key to close this window");
        Console.ReadKey();
    }//end of main method 
    //adding two numbers 
  static int Add(int n1,int n2){
            int result=0;
                result=n1+n2;
            return result;
   }//end of add method 
static int Substract(int n1,int n2){
       int result=0;
        result=n1-n2;
       return result;
   }//end of substract method 
   static bool IsEven(int n1){
       bool flag=false;
        if(n1%2 ==0){
            flag=true;
        }
       return flag;
   }
}//end of class 