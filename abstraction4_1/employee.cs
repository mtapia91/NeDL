using System;

namespace abstraction4_1
{
    abstract class Employee  
    {

        public string firstName //first name property
            {get; set;}
        public string lastName  //last name property
            {get; set;}
        public string employeeType  //employee type property
            {get; set;}

        public Employee () // setting default constructor w/ no parameters passing through
        {
            firstName = "";
            lastName = "";
            employeeType = "";
        }
        public Employee (string newFirstName, string newLastName, string newEmployeeType) // different version of constructor
        {
            firstName = newFirstName;
            lastName = newLastName;
            employeeType = newEmployeeType;
        }
        public abstract double GetBonus();
        
        public override String ToString() 
    {
        return ("\nEmployee name: " + firstName +" "+ lastName + " \nHourly/Salary?: " + " " + employeeType);
    }
    }
}