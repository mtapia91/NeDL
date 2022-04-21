using System;

namespace comp345
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Frank", "Lisa", 'S');  //testing employee class || it worked
            Console.WriteLine(emp1.ToString());
        }
    }
}