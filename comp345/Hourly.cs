using System;

namespace comp345
{
    public class Hourly
    {
        char emptype;
        float rate;

    public Hourly (char emptype, float rate) //Constructor of the class
    {
        this.emptype = emptype;
        this.rate = rate;
    }
    public char GetEmpType() //prop 1
    {
        return emptype;
    }
    public float GetRate() //prop 2
    {
        return rate;
    }
    public override String ToString() //override ToString so an obj can be printed out with writeline
    {
        return (this.GetEmpType() + ", " + this.GetRate() + ".");
    }
    }
}