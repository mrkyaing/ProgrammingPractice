using System;
class tryDemo
{
    static void Main(){
       Console.WriteLine("Hello,world");
            Console.Write("Please Type two numbers:");
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine("{0}/{1}={2}", n1, n2, result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero.please try again");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Not a valid Numbers.please try again");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Not a valid Format Numbers.please try again");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Operations.please try again");
            }
            finally
            {
                Console.WriteLine("Program stopped.");
            }
    }
}