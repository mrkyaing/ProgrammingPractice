using System;
class  IfElseDemo
{
    static void Main(){
        Console.WriteLine("Start Program.");
        string name="U Kaung";
        bool isNation=false;
        int age=50;
        if(age>18 && isNation==true){
            Console.WriteLine("Hello,"+name);
            Console.WriteLine("You can vote in election.");
        }//end of if block 
        else{
             Console.WriteLine("Hello,"+name);
             Console.WriteLine("You can not vote in election.");
             //Console.WriteLine("But you can vote after "+(18-age)+" year(s)");
        }//end of else block 
        Console.WriteLine("Stop Program.");
    }//end of Main Method
}//end of class 