using System;
using System.Collections.Generic;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            var debs = new List<IPay>();

            debs.Add(new Invoice
            {
                Description = "Coke",
                Id = "1010",
                Price = 1.32M,
                Quantity = 48,
            });

            debs.Add(new Invoice
            {
                Description = "Milk",
                Id = "2020",
                Price = 1.22M,
                Quantity = 12,
            });

            debs.Add(new SalariedEmployee
            {
                FirstName = "Juan",
                Id = "1393336",
                LastName = "Zuluaga",
                Salary = 1200000,
            });

            decimal total = 0;
            foreach (var item in debs)
            {
                Console.WriteLine(item);
                total += item.GetValueToPay();
            }

            Console.WriteLine("                                 ==================");
            Console.WriteLine("TOTAL..........................: {0,18:C2}", total);
            Console.WriteLine("Press any key to finish...");
            Console.ReadKey();
            Console.WriteLine("Hasta la vista baby");
        }
    }
}
