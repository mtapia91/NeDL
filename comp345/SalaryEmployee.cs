using System;

namespace comp345
{
    public class SalaryEmployee : Employee  //salary class
    {

    private double salaryRate;

    public SalaryEmployee (string newFirstName, string newLastName, char newEmployeeType, double newSalaryRate) : base (newFirstName, newLastName, newEmployeeType)//constructor for class
    {
        salaryRate = newSalaryRate; 
    }
    public double setSalaryRate() //prop 1
    {
        return salaryRate;
    }
    public void setSalaryRate(double newSalaryRate)
    {
        salaryRate = newSalaryRate;
    }
    public override string ToString() 
    {
        return (salaryRate + ". \nMaking their bonus: $" + (salaryRate * .1));
    }

    }
}