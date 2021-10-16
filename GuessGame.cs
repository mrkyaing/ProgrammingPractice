using System;
class GuessGame{
    static void Main(){
        Console.WriteLine("Guess Game(0 to 20) Started!!!!");
        Random randomObj=new Random();//create Random Object 
        Console.Write("Guess my number:");
        int inputvalue=Convert.ToInt32(Console.ReadLine());//get user's input from the keyboard 
        int hiddenvalue=randomObj.Next(20);//Generate Hideen value by the Random Object 
        bool IsNext=true;
        while(IsNext){
            if(inputvalue==hiddenvalue)//condition check hidden value and input value is equal to
            {
                Console.WriteLine("wow!!! You got it right.");
                Console.WriteLine("Game End.");
                IsNext=false;
            }
            else{
                Console.WriteLine("No!! You got it wrong!! ");
                Console.Write("Guess again:");
                inputvalue=Convert.ToInt32(Console.ReadLine());// get user's input from the keyboard agian .
            }
        }//end of while loop 
    }//end of main
}//end of class 