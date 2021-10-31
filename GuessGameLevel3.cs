using System;
class GuessGameLevel3{
    static void Main(){
        try {
            char doNext='y';
            do{    
            Console.WriteLine ("Guess Game(0 to 20) Started!!!!");
            Random randomObj = new Random (); //create Random Object 
            int hiddenvalue = randomObj.Next (20); //Generate Hideen value by the Random Object 
            Console.WriteLine(hiddenvalue);
            Console.Write ("Guess my number:");
            int inputvalue = Convert.ToInt32 (Console.ReadLine ()); //get user's input from the keyboard 
            bool IsNext = true;
            int attemps=0;
            while (IsNext) {
                attemps++;
                //out of range 
                if(inputvalue<0 || inputvalue>20){
                Console.WriteLine ("Read Game Info it is between 0 to 20 . Idiot");
                Console.WriteLine ("No!! You got it wrong!! ");
                Console.Write ("Guess again:");
                inputvalue = Convert.ToInt32 (Console.ReadLine ()); // get 
                }
                //correct 
               else  if (inputvalue == hiddenvalue) //condition check hidden value and input value is equal to
                {
                    string showvalue;
                     switch(attemps){
                        case 1:showvalue=attemps+"st time."; break;
                        case 2:showvalue=attemps+"nd times."; break;
                        case 3:showvalue=attemps+"rd times."; break;
                        default:showvalue=attemps+"th times."; break;
                    }
                    Console.WriteLine ("wow!!! You got it right at "+showvalue);
                   
                    Console.WriteLine ("Game End.");
                    IsNext = false;
                } 
                //too close 
                else if(hiddenvalue-inputvalue<=2 && hiddenvalue-inputvalue>0){
                Console.WriteLine ("your input value is close  with hidden value");
                Console.WriteLine ("No!! You got it wrong!! ");
                Console.Write ("Guess again:");
                inputvalue = Convert.ToInt32 (Console.ReadLine ()); // get 
                }
                //too far
                else{
                Console.WriteLine ("your input value is  far with hidden value");
                Console.WriteLine ("No!! You got it wrong!! ");
                Console.Write ("Guess again:");
                inputvalue = Convert.ToInt32 (Console.ReadLine ()); // get 
                }
            } //end of while loop 
            Console.Write("Wanna try again y/n?: ");
            doNext=Convert.ToChar(Console.ReadLine());//y 
            }while(doNext=='y');
            Console.WriteLine ("Game End.");

        }//end of try   
        catch (Exception e) {
            Console.WriteLine ("Hummm........Sorry our program cannot handle input. try again.");
        }      
    }
}