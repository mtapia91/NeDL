using System;

namespace abstraction4_1
{
    class HourlyEmployee : Employee
    {
        public double hourlyRate
            { get; set; }

        public HourlyEmployee() : base ()
        {
            hourlyRate = 0.0;
        }

    public HourlyEmployee (string newFirstName, string newLastName, string newEmployeeType, double newHourlyRate) : base (newFirstName, newLastName, newEmployeeType)
    {
        hourlyRate = newHourlyRate;
    }
        public override double GetBonus()
        {
            return hourlyRate * 80;
        }
    }
}