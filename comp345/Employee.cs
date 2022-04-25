namespace comp345
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private char employeeType; //must remain a Char type 

    public Employee (string newFirstName, string newLastName, char newEmployeeType) //Constructor of the class
    {
        firstName = newFirstName;
        lastName = newLastName;
        employeeType = newEmployeeType;
    }
    
    public String getFirstName() //prop 1 get:set
    {
        return firstName;
    }
    public void setFirstName (string newFirstName)
    {
        firstName = newFirstName;
    }


    public String getLastName() //prop 2 get:set
    {
        return lastName;
    }
    public void setLastName (string newLastName)
    {
        lastName = newLastName;
    }


    public char getEmployeeType() //prop 3 get:setEmployeeType
    {
        return employeeType;
    }
    public void setEmployeeType (char newEmployeeType)
    {
        employeeType = newEmployeeType;
    }


    public override String ToString() //override ToString so an obj can be printed out with writeline
    {
        return (firstName +" "+ lastName + " is paid a/an " + employeeType + " rate of");
    }
    }
}