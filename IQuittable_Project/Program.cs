using System;

namespace IQuittable_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.firstName = "Stephanie";
            employee.lastName = "Simms";

            employee.SayName(employee.firstName, employee.lastName);

            Console.ReadLine();
        }
    }
}
