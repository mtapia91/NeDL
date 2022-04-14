using System;

namespace TwoSumKattisProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Per-Magnus, please enter your first integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Per-Magnus, please enter your second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b; 
            
            Console.WriteLine("Per-Magnus, your total is: " sum);
        }
    }
}
