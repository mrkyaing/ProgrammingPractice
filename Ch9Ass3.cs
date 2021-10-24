using System;
class Ch9Ass3
{
  static void Main()
  {
    Console.WriteLine("Enter a name");
    string name = Console.ReadLine();//programming is funny and it is a tool.
    int len = name.Length;//to know lenght of input string 
    int vowels = 0;
    for (int i = 0; i < len; i++)
    {
      if (name[i] == 'a' || name[i] == 'i' || name[i] == 'u' || name[i] == 'e' || name[i] == 'o')
      {
        vowels++;
      }
    }
    Console.WriteLine("Vowel count in entered name is " + vowels);
  }
}