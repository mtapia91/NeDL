using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter number of Feet");
            int numFeet = Convert.ToInt32(Console.ReadLine());
            
            while (numFeet < 0)
            {
                Console.WriteLine("Enter number of Feet.  Positive numbers only.");
                numFeet = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.WriteLine(numFeet + " feet equals " + numFeet*12 + " inches");


        }
    }
}
