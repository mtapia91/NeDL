using System;

namespace comp345
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employeeBonusArray=new String[25];  // array declared & instantiated
                      
            //TODO get a first name
            bool userInput;
            int indexArray = 0;     
            bool found = false;       
            Console.WriteLine("Please provide first name.");
            string addFirstName = Console.ReadLine();
            for (indexArray = 0; indexArray < 25; indexArray++)
                {
                    if(((employeeBonusArray[indexArray]) == "") && (found == false))  //if a blank spot is found
                    {
                        employeeBonusArray[indexArray] = addFirstName; //adding name at blank spot found
                        Console.WriteLine(employeeBonusArray[indexArray]);
                    }
                }

            //TODO get a last name
            Console.WriteLine("Please provide last name.");
            string addLastName = Console.ReadLine();
            for (indexArray = 0; indexArray < 25; indexArray++)
                {
                    if(((employeeBonusArray[indexArray]) == "") && (found == false))  //if a blank spot is found
                    {
                        employeeBonusArray[indexArray] = addLastName; //adding name at blank spot found
                        Console.WriteLine(employeeBonusArray[indexArray]);
                    }
                }    
            //TODO get employee type S/H
            do
            {
                Console.WriteLine("Please enter 'S' if employee is salaried, or 'H' if employee is hourly.");
                string addEmployeeType = Console.ReadLine();
                userInput = false;
                        userInput = (addEmployeeType == "S" || addEmployeeType == "s" ||
                                    addEmployeeType == "H" || addEmployeeType == "h");
                        if (!userInput)
                        {
                            Console.WriteLine("Please enter 'S' for salary or 'H' for hourly. ");
                        }
                for (indexArray = 0; indexArray < 25; indexArray++)
                    {   
                        if(((employeeBonusArray[indexArray]) == "") && (found == false))  //if a blank spot is found
                        {
                            employeeBonusArray[indexArray] = addEmployeeType; //adding name at blank spot found
                            Console.WriteLine(employeeBonusArray[indexArray]);
                        }
                    }
            }
            while (!userInput);
            //TODO get salary or hourly amount

            //TODO if salary emp
            //      TODO add a salary obj to empbonusarray
            //else
            //      TODO add a hourly obj to empbonusarray



            for (int index = 0; index < employeeBonusArray.Length; index++) 
            {
                if (!(employeeBonusArray[index]==null))
                {
                    Console.WriteLine (employeeBonusArray[index]);
                }
            } 
       } 
    }
}
            
/*            HourlyEmployee emp1 = new HourlyEmployee("Joe", "Frank", 's', 50.25);

            SalaryEmployee emp2 = new SalaryEmployee("Lisa", "Frank", 'h', 83654.20);
            
            employeeBonusArray[1] = emp1;
            employeeBonusArray[3] = emp2;           
            
            //vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
            
           // HourlyEmployee emp1 = new HourlyEmployee("Joe", "Frank", "h", 50.25); //testing hourly class

            //SalaryEmployee emp2 = new SalaryEmployee("Lisa", "Frank", "s", 83654);
            
            /* //declaring variables
            bool userChoice;            
            string userChoiceString;
            userChoice = false;

            Employee[] employeeBonusArray=new Employee[50];  // array of employee objs are declared and instantiated
            
            do
            {
                //  TODO: Get a valid input
                do
                {
                    //  TODO: Provide the user a menu of options

                    Console.WriteLine("Please select an option listed below: ");
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
    /*              NEED TO WORK ON "S" OPTION AFTER "C" OPTION STARTS WORKING
        //  TODO: Else if the option is an S or s then store the array of strings into the text file
                else if (userChoiceString=="S" || userChoiceString=="s")
                {
                    if (File.Exists("employeedata.txt"))
                    {
                        File.Delete("employeedata.txt");
                    }
                    Console.Write("Changes have been applied to your file. ");
                    
                    using (StreamWriter fileStr = File.CreateText("employeedata.txt"))
                    {              
                        int index = 0;
                        fileStr.WriteLine(employeeBonusArray[index]);
                        
                    }
                    using (StreamReader sr = File.OpenText("employeedata.txt"))
                    {
                        string s = "";  //
                        int index = 0;  //initializing array index
                        while ((s = sr.ReadLine()) != null)
                            {
                                employeeBonusArray[index] = s;
                                index++;
                            }
                    }               
                } */
        //  TODO: Else if the option is a C  or c then add a name to the array (if there's room)

/* else if (userChoiceString=="C" || userChoiceString=="c")
{
int index = 0;
string newName = Console.ReadLine();
bool found = false;
Console.WriteLine("What name do you want to add?");
Console.WriteLine("");
for (index = 0; index <10; index++)
{
    if(((employeeBonusArray[index]) == "") && (found == false))  
    {
        employeeBonusArray[index] = newName; 
        found = true; 

        Console.WriteLine(employeeBonusArray[index]);
    }
}              
} 

        //  TODO: Else if the option is an R or r then read a name from the array (if it's there)

                else if (userChoiceString=="R" || userChoiceString=="r")
                {
                    for (int index = 0; index < employeeBonusArray.Length; index++) //start to Read command
                        {
                            if (!(employeeBonusArray[index]==null))
                            {
                                Console.WriteLine (employeeBonusArray[index]);
                            }
                        }
                }
        //  TODO: Else if the option is a U or u then update a name in the array (if it's there)

                else if (userChoiceString=="U" || userChoiceString=="u")
                {
                    Console.WriteLine("In the U/u area");
                }

        //  TODO: Else if the option is a D or d then delete the name in the array (if it's there)

                else if (userChoiceString=="D" || userChoiceString=="d")
                {
                    Console.WriteLine("In the D/d area");
                }

        // TODO: Else is a Q or q then the program ends

            else
            {
                Console.WriteLine("Good-bye!");
            }
            }
            while (!(userChoiceString=="Q") && !(userChoiceString=="q"));     */          



/*          vvvvvvvvv      INFO TO MANUALLY TEST     vvvvvvv
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