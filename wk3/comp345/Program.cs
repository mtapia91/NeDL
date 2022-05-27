using System;

namespace comp345
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;     
            bool found;
            bool userInput;
            string[] employeeBonusArray=new String[25];  // array declared & instantiated
            
            //TODO get a first name        
            Console.WriteLine("Please provide first name.");
            string addFirstName = Console.ReadLine();

            //TODO get a last name
            Console.WriteLine("Please provide last name.");
            string addLastName = Console.ReadLine();
               
            //TODO get employee type S/H
            Console.WriteLine("Please enter 'S' if employee is salaried, or 'H' if employee is hourly.");
            char addEmployeeType = Convert.ToChar(Console.ReadLine());
            userInput = (addEmployeeType == 'S' || addEmployeeType == 's' ||
                         addEmployeeType == 'H' || addEmployeeType == 'h' );

                        // TODO add a hourly obj to empbonusarray
                if (userInput = (addEmployeeType == 'S'|| addEmployeeType == 's'))
                {
                    Console.WriteLine("Please provide salary amount.");
                    double addSalaryPay = Convert.ToDouble(Console.ReadLine());
                }
                    
                        // TODO add a hourly obj to empbonusarray
                else if (userInput = (addEmployeeType == 'H' || addEmployeeType == 'h'))
                {
                    Console.WriteLine("Please provide hourly rate.");
                    double addHourlyPay = Convert.ToDouble(Console.ReadLine());   
                }

                for (index = 0; index < employeeBonusArray.Length; index++)
                {
                   if (!(employeeBonusArray[index]==null))
                        {
                            Console.WriteLine(employeeBonusArray[index]);
                        }
                }

        } //end main
    } //end program 
} //end namespace                
                    /* for (index = 0; index < employeeBonusArray.Length; index++) //start of Read option
                    {
                        if (!(employeeBonusArray[index]==null))
                        {
                            Console.WriteLine(employeeBonusArray[index]);
                        }
                    }  */



            
/*            
            Employee[] employeeBonusArray=new Employee[50];  // array of employee objs are declared and instantiated
            HourlyEmployee emp1 = new HourlyEmployee("Joe", "Frank", 's', 50.employeeBonusArray.Length);

            SalaryEmployee emp2 = new SalaryEmployee("Lisa", "Frank", 'h', 83654.20);
            
            employeeBonusArray[1] = emp1;
            employeeBonusArray[3] = emp2;           
            
            vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
            
            HourlyEmployee emp1 = new HourlyEmployee("Joe", "Frank", "h", 50.employeeBonusArray.Length); //testing hourly class

            SalaryEmployee emp2 = new SalaryEmployee("Lisa", "Frank", "s", 83654);
           
            vvvvvvvvv      INFO TO MANUALLY TEST     vvvvvvv
            Employee emp1 = new Employee("Frank", "Lisa", "salary");  //testing employee class || it worked
            Console.WriteLine(emp1);
            
            HourlyEmployee emp2 = new HourlyEmployee("Joe", "Frank", "s", 50.employeeBonusArray.Length); //testing hourly class
            Console.WriteLine(emp2); 

            SalaryEmployee emp3 = new SalaryEmployee("Lisa", "Frank", "h", 83654);
            Console.WriteLine(emp3);
            
            
            vvvvvvvvv       ARRAY TESTING       vvvvvvvvvvv
            employeeBonusArray[1] = emp3;
            employeeBonusArray[3] = emp2;           
            
            

            vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
            
            HourlyEmployee emp1 = new HourlyEmployee("Joe", "Frank", "h", 50.employeeBonusArray.Length); //testing hourly class

            SalaryEmployee emp2 = new SalaryEmployee("Lisa", "Frank", "s", 83654);
            
            */