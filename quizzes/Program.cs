using System;

namespace Quizzes
{
    class Program
    {
        static int MyMin(int x, int y)  //generic min method
        {
            if (x < y)
            {
                return (x);
            }
            else
            {
                return (y);
            }
        }
        static int MyMax(int x, int y)  //generic max method
        {
            if (x > y)
            {
                return (x);
            }
            else
            {
                return (y);
            }
        }
         static int ValidValue(int lowVal, int highVal) //runs program to ensure user inputs values between the range stated
         {
            int aValue;
            do 
            {
                Console.WriteLine("Between " + lowVal + " and " + highVal);
                aValue=Convert.ToInt32(Console.ReadLine());  //aValue has to be declared outside of this "do" block of code
                
                if (aValue > highVal || aValue < lowVal)
                        {
                            Console.WriteLine("Sorry, invalid value.");
                        }
            }            
            while (aValue > highVal || aValue < lowVal); //
            return aValue;
         } 

        static void Main(string[] args)
        {
            Console.WriteLine("How many quizzes do you have?"); 
            //Establish total number of quizzes
            int quizQty = ValidValue(1,500);

            //intialize minimum & maximum quiz & average quiz
            int minQuiz = 101;
            int maxQuiz = 0;
            double avgQuiz = 0;
        
            //the for loop is being used to determine min & max quiz value

            for (int newQuiz = 0; newQuiz < quizQty; newQuiz++)
            {
                Console.WriteLine("Please enter quiz score " + (newQuiz+1));
                int quizScore = ValidValue(0,100);

                minQuiz = MyMin(quizScore, minQuiz);

                maxQuiz = MyMax(quizScore, maxQuiz);

                avgQuiz = avgQuiz+quizScore;
            }
               Console.WriteLine("The minimum score is " +minQuiz);
               Console.WriteLine("The maximum score is " +maxQuiz);
               Console.WriteLine("The average score is " +(avgQuiz/quizQty));
        }
    }
}



/*	V. Create a GetValidInt with the signature
		static int GetValidInt (int lowRangeValue, int highRangeValue)
		
		Example call:

            do
                prompt
                obtain value
                if the value is invalid give error message
            while value is invalid
		
int numberValues = GetValidInt(1,100);*/