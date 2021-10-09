using System;
class NestedLoopDemo
{
    static void Main()
    {
        for(int row=0;row<3;row++)
        {
            for(int col=0;col<5;col++){
                Console.Write("*");//print out * 
            }//end of inner loop 
            Console.WriteLine();//new Line 
        }//end of outter loop 
    }//end of Main
}//end of class 