using System;
using System.Collections.Generic;

namespace abstraction4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TEST create hourly emp list
            List<HourlyEmployee> hourlyEmployeeList = new List<HourlyEmployee>();
            //TEST create salary emp list
            List<SalaryEmployee> salaryEmployeeList = new List<SalaryEmployee>();

            //TEST manual data to add to hourly emp list
            hourlyEmployeeList.Add(new HourlyEmployee("Susana", "T", "H", 65.32));
            hourlyEmployeeList.Add(new HourlyEmployee("Juliana", "V-T", "H", 55.45));

            //TEST manual data to add to salary emp list
            salaryEmployeeList.Add(new SalaryEmployee("Jaydin", "V-T", "S", 65112));
            salaryEmployeeList.Add(new SalaryEmployee("Juillet", "V-T", "S", 57659));


            //TEST print hourly emp list
            foreach (HourlyEmployee hourEmp in hourlyEmployeeList)
            {
                Console.WriteLine(hourEmp);
            }

            //TEST print salary emp list
            foreach (SalaryEmployee salEmp in salaryEmployeeList)
            {
                Console.WriteLine(salEmp);
            }
        }
    }
}