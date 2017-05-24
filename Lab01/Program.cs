using System;
using System.Collections.Generic;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee("Juan", "Zuluaga", new Date(1974, 9, 23), new Date(2017, 5, 9));
            var employee2 = new Employee("Celia", "Cruz", new Date(1956, 13, 45), new Date(2016, 2, 29));
            var employee3 = new Employee("Fredy", "Mercury", new Date(1986, 12, 21), new Date(2001, 2, 29));

            var employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.ReadKey();
            Console.WriteLine("Hasta la vista baby...");
        }
    }
}
