using System;

namespace classgradeavg
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
            static int ValidQuizValue(int lowQuiz, int highQuiz) //runs program to ensure user inputs values between the range stated
            {
                int quizValue;
                do
                {
                    Console.WriteLine("Between " + lowQuiz + " and " + highQuiz);
                    quizValue=Convert.ToInt32(Console.ReadLine());  //quizValue has to be declared outside of this "do" block of code
                    
                    if (quizValue > highQuiz || quizValue < lowQuiz)
                            {
                                Console.WriteLine("Sorry, invalid value.");
                            }
                }
                while (quizValue > highQuiz || quizValue < lowQuiz);
                return quizValue;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Please enter total number of students: ");
                    int qtyTotal=ValidQuizValue(1,1000);

                //start loop to do following code for every student
                    for (int currentStudentNumber = 0; currentStudentNumber < qtyTotal; currentStudentNumber++) 

                        {
                                Console.WriteLine("Please provide first & last name of student " + (currentStudentNumber+1));
                                string? fullName = Console.ReadLine();

                                double avgHw = 0;
                                double avgQuiz = 0;
                                double avgExam = 0;


                            //chunk of code for hw avg
                                for (double newHw = 0; newHw < 5 ; newHw++)
                                    {
                                    Console.WriteLine("Please enter homework score " + (newHw+1));
                                    double hwScore = ValidQuizValue(0,100);

                                    avgHw = avgHw+hwScore;
                                    }
                                
                                avgHw = avgHw/5.0;
                                Console.WriteLine("The average homework score is " +(avgHw));

                            //chunk of code for quiz avg
                                for (double newQuiz = 0; newQuiz < 3 ; newQuiz++)
                                    {
                                    Console.WriteLine("Please enter quiz score " + (newQuiz+1));
                                    double quizScore = ValidQuizValue(0,100);

                                    avgQuiz = avgQuiz+quizScore;
                                    }
                                
                                avgQuiz = avgQuiz/3.0;
                                Console.WriteLine("The average quiz score is " +(avgQuiz));
                                
                            //chunk of code for exam avg
                                for (double newExam = 0; newExam < 2 ; newExam++)
                                    {
                                    Console.WriteLine("Please enter exam score " + (newExam+1));
                                    double examScore = ValidQuizValue(0,100);

                                    avgExam = avgExam+examScore;
                                    }
                                
                                avgExam = avgExam/2.0;
                                Console.WriteLine("The average exam score is " +(avgExam));

                            //calculate weighted average

                                double gradeAvg = (avgHw*.5)+(avgQuiz*.3)+(avgExam*.2);
                                Console.WriteLine(gradeAvg);
                                
                                
                            // if statement to determine letter grade 
                                    if (gradeAvg >= 90)
                                    {
                                        Console.WriteLine ("Your final grade is an A.");
                                    }
                                        else if (gradeAvg >= 80)
                                        {
                                            Console.WriteLine ("Your final grade is a B.");
                                        }
                                        else if (gradeAvg >= 70)
                                        {
                                            Console.WriteLine ("Your final grade is a C.");
                                        }
                                        else if (gradeAvg >= 60)
                                        {    
                                            Console.WriteLine ("Your final grade is a D.");
                                        }    
                                    else
                                    {
                                        Console.WriteLine ("Your final grade is an F.");
                                    }              
                    }            

            }
    }
}