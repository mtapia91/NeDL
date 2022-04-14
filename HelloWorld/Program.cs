using System;

namespace helloworld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("How many pennies do you have?:"); //User will enter the total amount of pennies
      int pennies = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("How many nickels do you have?:"); //User will enter the total amount of nickels
      int nickels = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("How many dimes do you have?:"); //User will enter the total amount of dimes
      int dimes = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("How many quarters do you have?:"); //User will enter the total amount of quarters
      int quarters = Convert.ToInt32(Console.ReadLine());
      
      int penniesTotal = pennies;
      int nickelsTotal = nickels * 5;
      int dimesTotal = dimes * 10;
      int quartersTotal = quarters * 25;
      double totalMoney = (penniesTotal + nickelsTotal + dimesTotal + quartersTotal) / 100.00;

      Console.WriteLine("The total amount in your piggy bank is " + "$" + totalMoney);
    }
  }
}