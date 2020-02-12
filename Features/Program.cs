using System;
using System.Collections.Generic;
using System.Linq;

namespace Features
{
    public class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> square = x => x * x;
            Func<double, double, double> percent = (n, m) => ((n / 100) * m);

            Action<string> display = x => Console.WriteLine(x);

            display($"Square 12 = {square(12)}");
            Console.WriteLine($"10% of 50,000 = {percent(10, 50000)}");

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


            foreach (var person in developers.Where(e => e.Name.Length > 5).OrderBy(e => e.Name))
            {
                Console.WriteLine($"\tID: {person.Id,2}\t Name: {person.Name,2}");
            }






            //

            //            string containsDouble = "152.05";
            //            double converted = containsDouble.ToDouble();
            //
            //            Console.WriteLine(converted);
            //
            //            Console.WriteLine(developers.Count());
            //


            List<string> cities = new List<string>() { "Lagos", "Abuja", "Madrid", "Namibia", "Seychelles", "London", "Luisiana", "Las Vagas", "Ladi" };

            var filteredCities =
                from city in cities
                where city.StartsWith("L") && city.Length > 5
                orderby city
                select city;

            foreach (var city in filteredCities)
            {
                Console.WriteLine(city);
            }


            //            IEnumerable<string> filteredList = cities.Where(startsWithLetter);
            //
            //            //            bool startsWithLetter(string name)
            //            //            {
            //            //                return name.StartsWith("M");
            //            //            }
            //
            //
            //            //            IEnumerable<string> filteredList = cities.Where(delegate (string S) { return S.StartsWith("L"); });
            //
            //            IEnumerable<string> filteredList = cities.Where(s => s.StartsWith("L"));
            //
            //            foreach (var city in filteredList)
            //            {
            //                Console.WriteLine(city);
            //            }
            //
            //            foreach (var person in developers.Where(e => e.Name.StartsWith("B")))
            //            {
            //                Console.WriteLine(person.Name);
            //            }

        }
    }
}
