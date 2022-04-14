using System;

namespace WhichIsGreater
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("To determine which number is greater, please enter first number (1-24): ");
      int a = Convert.ToInt32(Console.ReadLine()); //Prompts user to enter 1st number
      Console.WriteLine("Please enter second number (1-24): ");
      int b = Convert.ToInt32(Console.ReadLine()); //Prompts users to enter 2nd number

        if (a > b)
        {   //First was greater. Output 1
            Console.WriteLine("Your first number was greater than your second number. (1)");
        }
        else if (a == b)
        {   //Same number. Output 0
            Console.WriteLine("Your numbers were the same.");
        }
        else 
        {   //Second was greater. Output 0
            Console.WriteLine("Your second number was greater than your first number.");
        }      
    }
  }
}