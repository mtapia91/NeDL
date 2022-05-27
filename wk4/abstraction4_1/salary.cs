using System;

namespace abstraction4_1
{
    class SalaryEmployee : Employee
    {
    public double salaryRate
        { get; set; }

    public SalaryEmployee() : base ()
    {
        salaryRate = 0.0;
    }

    public SalaryEmployee (string newFirstName, string newLastName, string newEmployeeType, double newSalaryRate) : base (newFirstName, newLastName, newEmployeeType)
    {
        salaryRate = Math.Round(newSalaryRate, 2);
    }
        public override double GetBonus()
        {
            return Math.Round((salaryRate * .1), 2);
        }
        public override string ToString()
        {
            return base.ToString()+ "\nAnnual salary: $" + salaryRate + "\nBonus amount: $" + GetBonus() + "\n";
        }
    }
}