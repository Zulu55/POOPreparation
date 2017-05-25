using System;
using System.Collections.Generic;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>();

            employees.Add(new Employee
            {
                BornDate = new Date(1974, 9, 23),
                FirstName = "Juan",
                HireDate = new Date(2017, 5, 9),
                LastName = "Zuluaga",
            });

            employees.Add(new Employee
            {
                BornDate = new Date(1954, 13, 43),
                FirstName = "Celia",
                HireDate = new Date(2000, 2, 29),
                LastName = "Cruz",
            });

            employees.Add(new Employee
            {
                BornDate = new Date(1984, 12, 12),
                FirstName = "Freddy",
                HireDate = new Date(2001, 2, 29),
                LastName = "Mercury",
            });

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("Press any key to finish...");
            Console.ReadKey();
            Console.WriteLine("Hasta la vista baby");
        }
    }
}
