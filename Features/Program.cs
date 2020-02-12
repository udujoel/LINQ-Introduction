using System;
using System.Collections.Generic;
using System.Linq;

namespace Features
{
    public class Program
    {
        static void Main(string[] args)
        {

            var developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Kent"},
                new Employee {Id = 2, Name = "Willis"},
                new Employee {Id = 3, Name = "Burrows"}
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee{Id = 1, Name = "Walrus"},
                new Employee{Id = 2,Name = "Tony"}
            };


            foreach (var person in developers)
            {
                Console.WriteLine($"\tID: {person.Id,2}\t Name: {person.Name,2}");
            }

            string containsDouble = "152.05";
            double converted = containsDouble.ToDouble();

            Console.WriteLine(converted);

            Console.WriteLine(developers.Count());

            List<string> cities = new List<string>() { "Lagos", "Abuja", "Madrid", "Namibia", "Seychelles", "London", "Luisiana" };

            IEnumerable<string> filteredList = cities.Where(startsWithLetter);

            bool startsWithLetter(string name)
            {
                return name.StartsWith("M");
            }

            foreach (var city in filteredList)
            {
                Console.WriteLine(city);
            }
        }
    }
}
