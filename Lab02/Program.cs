using System;
using System.Collections.Generic;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>();

            var emp1 = new SalariedEmployee("1010", "Celia", "Cruz", 3500000);
            employees.Add(emp1);
            var emp2 = new SalariedEmployee("2020", "Hector", "Lavoe", 4500000);
            employees.Add(emp2);
            var emp3 = new CommissionEmployee("3030", "Natalia", "Paris", .02, 250000000);
            employees.Add(emp3);
            var emp4 = new CommissionEmployee("4040", "Tatiana", "De Los Rios", .018, 180000000);
            employees.Add(emp4);
            var emp5 = new HourlyEmployee("5050", "Jhon", "Secada", 123, 13500);
            employees.Add(emp5);
            var emp6 = new HourlyEmployee("6060", "Bob", "Marley", 101, 15600);
            employees.Add(emp6);
            var emp7 = new CommissionBaseEmployee("7070", "Laura", "Gil", .005, 23000000, 780000);
            employees.Add(emp7);


            decimal paysheet = 0;
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
                paysheet += employee.GetSalary();
            }

            Console.WriteLine("                                ==================");
            Console.WriteLine("Paysheet......................: {0,18:C2}", paysheet);
            Console.WriteLine("Press any key to finish...");
            Console.ReadKey();
            Console.WriteLine("Hasta la vista baby");
        }
    }
}
