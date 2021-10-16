using System;
class BreakDemo
{
    static void Main(){
        int i=100;
   while(i>0){     
       if(i==10){
           break;
       }//end of if 
        Console.Write(i+" ");//100 99 98 .....10
       i--;
   }//end of while loop
   //>> will do execute this line when break statement work
    }//end of main
}//end of class 