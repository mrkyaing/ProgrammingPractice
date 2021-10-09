using System;
class StarLoopDemo
{
    static void Main()
    {
    for(int row=1;row<=5;row++){
            for(int col=1;col<=row;col++){
                Console.Write("*");//print out *
            }//end of inner loop 
            Console.WriteLine();//new line
        }//end of outter loop
    }
}