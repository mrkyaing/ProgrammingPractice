using System;
class WhileVsDoWhileDemo{
    static void Main(){
        int i=100;
        while(i<1){
            Console.WriteLine("Hello,I am coming In");
            i++;
        }//end of while loop
        do{
            Console.WriteLine("Hello,I am coming In");
            i++;
        }while(i<1);//end of do while loop 
    }//end of main method

}//end of class 