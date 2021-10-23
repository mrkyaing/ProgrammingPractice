using System;
class MethodDemo{
    static void Main(){
        Console.WriteLine("Program start.");
            PrintStarPattern();//call or invoke 
            PrintStarPattern();//call or invoke 
            PrintStarPattern();//call or invoke 
        Console.WriteLine("Program finished.");
    }//end of main method 

    //define a Method Named PrintStarPattern
   static void PrintStarPattern(){//this method will print * pattern >>no return type and no paremeters
    for(int i=1;i<=4;i++){
            for(int j=1;j<=i;j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }//end of PrintStarPattern method 

}//end of class 