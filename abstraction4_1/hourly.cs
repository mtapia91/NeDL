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
            return Math.Round(hourlyRate * 80, 2); //rounds to second decimal
        }
        public override string ToString()
        {
            return base.ToString() + " \nHourly rate: $" + hourlyRate + "\nBonus: $" + GetBonus() + "\n";
        }
    }
}