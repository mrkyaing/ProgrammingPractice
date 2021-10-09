using System;
class StarLoopDemo2
{
    static void Main()
    {
        for(int row=5;row>=1;row--)
        {
            for(int col=1;col<=row;col++){
                Console.Write("*");//*****
            }
            Console.WriteLine();
        }
    }
}