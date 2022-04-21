using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myNumbers = new int[10];
            for(int i=0; i < 10; i++)
            {
                Console.WriteLine("enter number {0}: ", (i+1));
                myNumbers [i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i < 10; i++)
            {
                Console.WriteLine("the number " + i+ ": " + myNumbers[i]);
            }

        //max 
            int max = myNumbers[0];
            foreach(int num in myNumbers)
            {
                Console.Write(num +" ");
            }
            Console.WriteLine();
            for (int i=0;i<myNumbers.Length;i++)
                {
                    if(myNumbers[i]>max)
                        {
                            max=myNumbers[i];
                        }
                }
            Console.WriteLine("The max in this array is " +max);

        //min 
            int min = myNumbers[0];
            foreach(int num in myNumbers)
            {
                Console.Write(num +" ");
            }
            Console.WriteLine();
            for (int i=0;i<myNumbers.Length;i++)
                {
                    if(myNumbers[i]<min)
                        {
                            min=myNumbers[i];
                        }
                }
            Console.WriteLine("The min in this array is " +min);

        //sum
            int numSum = 0;
            for (int i=0;i<myNumbers.Length;i++)
            {
                numSum += myNumbers[i];
            }
            Console.WriteLine("the sum in this array is " +numSum);
            
        //average
            double avg = numSum/myNumbers.Length;
            Console.WriteLine("the average of the array is: " +(avg));
        
        //numbers above average
             if (myNumbers[0] > avg)
            {
                Console.WriteLine("the numbers above average in your array are: {0}");
            }

        //numbers below average

        }//main
    }//end program
}//end namespace