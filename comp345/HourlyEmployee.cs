using System;

namespace comp345
{
    public class HourlyEmployee : Employee
    {

    private double hourlyRate;

    public HourlyEmployee (string newFirstName, string newLastName, string newEmployeeType, double newHourlyRate) : base (newFirstName, newLastName, newEmployeeType) //constructor for class
    {
        hourlyRate = newHourlyRate; 
    }

    public double getHourlyRate() //prop 1 get:set
    {
        return hourlyRate;
    }
    public void setHourlyRate(double newHourlyRate)
    {
        hourlyRate = newHourlyRate;
    }
    public override string ToString()
    {
        return (hourlyRate + " \nSo, their bonus will be: $" + (hourlyRate * 80));
    }

    }
}
/*
//read employees from file
var employees = new[] {new Employees}
//loop through every employee
//check if they're hourly or salary
...*/