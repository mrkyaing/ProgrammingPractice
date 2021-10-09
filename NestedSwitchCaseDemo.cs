using System;

     class NestedSwitchCaseDemo
    {
         static void Main()
        {
        int value1 = 20;
        switch (value1)
        {
            case 20:
                {
                    int i = value1 % 2;
                    Console.WriteLine("value is 20");
                    switch (i)
                    {
                        case 0: Console.WriteLine("Even Number"); break;
                    }//innner switch case statement
                }
                break;
            case 30:Console.WriteLine("vlaue is 30");break;
            default:Console.WriteLine("invalid"); break;
        }//end of outter  switch case statement
        }//end of Main Method
    }//end of class 

