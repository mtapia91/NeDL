using System;

namespace basepower2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string goAgain;
            do
            {
                Console.WriteLine("What is your base number?");
                double baseValue = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What are the exponents?");
                double exponentValue = Convert.ToInt32(Console.ReadLine());
                double currentTotal = 1;
                    for (int value = 0; value < exponentValue; value++)
                        {
                        currentTotal = currentTotal * baseValue;
                        }
                Console.WriteLine(currentTotal);
                Console.WriteLine("Would you like to try again? Yes or No?");
                goAgain=Console.ReadLine();
            }
            while (goAgain == "Yes");
        }
    }
}