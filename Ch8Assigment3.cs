using System;
class Ch8Assigment3
{
  static void Main()
  {
    Console.Write("Enter the step that you want to loop");
    int step = Convert.ToInt32(Console.ReadLine());


    Console.Write("Enter the step height");
    int stepHeight = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter each step width");
    int eachWidthHeight = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= step; i++)
    {
      for (int j = 1; j <= stepHeight; j++)
      {
        for (int k = 1; k <= eachWidthHeight * i; k++)
        {
          if (j == 1 || j == step)
          {
            Console.Write("*");
          }
          else
          {
            Console.Write(" ");
          } //end of if loop
          if (k == 1 || k == i)
          {
            Console.Write("*");
          }
          else
          {
            Console.Write("");
          }

        }
        Console.WriteLine();
      }
    }
  }
}