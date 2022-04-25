using System;

namespace comp345
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            bool userChoice;            
            string userChoiceString;
            userChoice = false;

            Employee[] employeeBonusArray=new Employee[50];  // array of employee objs are declared and instantiated
           
            for (int index = 0; index < employeeBonusArray.Length; index++) //start to Read command
            {
                if (!(employeeBonusArray[index]==null))
                {
                    Console.WriteLine (employeeBonusArray[index]);
                }
            }
            do
            {
                //  TODO: Get a valid input
                do
                {
                    //  TODO: Provide the user a menu of options

                    Console.WriteLine("Choose your poison: ");
                    Console.WriteLine("L: Load the data file into an array. ");
                    Console.WriteLine("S: Store the array to your data file. ");
                    Console.WriteLine("C: Add a name to the array. ");
                    Console.WriteLine("R: Read a name from the array. ");
                    Console.WriteLine("U: Update a name in the array. ");
                    Console.WriteLine("D: Delete a name from the array. ");
                    Console.WriteLine("Q: Quit the program. ");

                //  TODO: Get a user option (valid means its on the menu)

                    userChoiceString = Console.ReadLine();

                    userChoice = (userChoiceString=="L" || userChoiceString=="l" ||
                                    userChoiceString=="S" || userChoiceString=="s" ||
                                    userChoiceString=="C" || userChoiceString=="c" ||
                                    userChoiceString=="R" || userChoiceString=="r" ||
                                    userChoiceString=="U" || userChoiceString=="u" ||
                                    userChoiceString=="D" || userChoiceString=="d" ||
                                    userChoiceString=="Q" || userChoiceString=="q");

                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }
                } 
                while (!userChoice);
                
                //  If the option is L or l then load the text file (employeedata.txt) into the array (employeeBonusArray)
                if (userChoiceString=="L" || userChoiceString=="l")
                {
                    int index = 0;  //index for my array
                    using (StreamReader sr = File.OpenText("employeedata.txt"))
                    {
                        string space = "";
                        Console.WriteLine(" Here is a list of all employees: ");
                        while ((space = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(space);
                                employeeBonusArray[index] = null;
                                index++;
                            }
                            Console.WriteLine("");
                    }
                }
                 //  TODO: Else if the option is an S or s then store the array of strings into the text file

                else if (userChoiceString=="S" || userChoiceString=="s")
                {
                    if (File.Exists("employeedata.txt"))
                    {
                        File.Delete("employeedata.txt");
                    }
                    Console.Write("Changes to your array have been updated to your text file. ");
                    
                    using (StreamWriter fileStr = File.CreateText("employeedata.txt"))
                    {              
                        int index = 0;
                        fileStr.WriteLine(employeeBonusArray[index]);
                        
                    }
                    using (StreamReader sr = File.OpenText("employeedata.txt"))
                    {
                        string s = "";
                        int index = 0;
                        while ((s = sr.ReadLine()) != null)
                            {
                                employeeBonusArray[index]= s;
                                index++;
                            }
                    }             
                }
                 //  TODO: Else if the option is an R or r then read a name from the array (if it's there)

                else if (userChoiceString=="R" || userChoiceString=="r")
                {
                    for (int index = 0; index < 10; index++)
                    {
                        Console.WriteLine(employeeBonusArray[index]);
                    }
                }
            } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));
        }
    }
}



/*          vvvvvvvvv      INFO TO MANUALLY TEST CLASSES     vvvvvvv
            Employee emp1 = new Employee("Frank", "Lisa", "salary");  //testing employee class || it worked
            Console.WriteLine(emp1);
            
            HourlyEmployee emp2 = new HourlyEmployee("Joe", "Frank", "s", 50.25); //testing hourly class
            Console.WriteLine(emp2); 

            SalaryEmployee emp3 = new SalaryEmployee("Lisa", "Frank", "h", 83654);
            Console.WriteLine(emp3);
            
            
            vvvvvvvvv       ARRAY TESTING       vvvvvvvvvvv
            employeeBonusArray[1] = emp3;
            employeeBonusArray[3] = emp2;           
            
            

            vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
            
            HourlyEmployee emp1 = new HourlyEmployee("Joe", "Frank", "h", 50.25); //testing hourly class

            SalaryEmployee emp2 = new SalaryEmployee("Lisa", "Frank", "s", 83654);
            
            */