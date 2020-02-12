using System;
using System.Collections.Generic;

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
        }
    }

    public static class StringExtensions
    {
        /// <summary>
        /// Converts a valid string that contains a double to data of type Double
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static double ToDouble(this string data)
        {
            double result = double.Parse(data);

            return result;
        }
    }
}
