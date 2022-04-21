using System;

namespace comp345
{
    public class Employee
    {
        string lname;
        string fname;
        char emptype;

    public Employee (string lname, string fname, char emptype) //Constructor of the class
    {
        this.lname = lname;
        this.fname = fname;
        this.emptype = emptype;
    }
    public String GetLName() //prop 1
    {
        return lname;
    }

    public String GetFName() //prop 2
    {
        return fname;
    }

    public char GetEmpType() //prop 3
    {
        return emptype;
    }

    public override String ToString() //override ToString so an obj can be printed out with writeline
    {
        return (this.GetLName() + ", " + this.GetFName() + " is paid " + this.GetEmpType() + ".");
    }
    }
}