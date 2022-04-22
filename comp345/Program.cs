using System;

namespace comp345
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employeeBonusArray=new Employee[50];  // array of employee objs are declared and instantiated

            /* Employee emp1 = new Employee("Frank", "Lisa", "salary");  //testing employee class || it worked
            Console.WriteLine(emp1); */
            
            HourlyEmployee emp2 = new HourlyEmployee("Joe", "Frank", "h", 50.25); //testing hourly class
/*             Console.WriteLine(emp2);  */

            SalaryEmployee emp3 = new SalaryEmployee("Lisa", "Frank", "s", 83654);
/*             Console.WriteLine(emp3); */

            employeeBonusArray[1] = emp3;
            employeeBonusArray[3] = emp2;

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


/*          vvvvvvvvv      INFO TO MANUALLY TEST CLASSES     vvvvvvv
            Employee emp1 = new Employee("Frank", "Lisa", "salary");  //testing employee class || it worked
            Console.WriteLine(emp1);
            
            HourlyEmployee emp2 = new HourlyEmployee("Joe", "Frank", "s", 50.25); //testing hourly class
            Console.WriteLine(emp2); 

            SalaryEmployee emp3 = new SalaryEmployee("Lisa", "Frank", "h", 83654);
            Console.WriteLine(emp3);
            */