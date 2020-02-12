using System.Collections.Generic;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Kent"},
                new Employee {Id = 2, Name = "Willis"},
                new Employee {Id = 3, Name = "Burrows"}
            };

            List<Employee> sales = new List<Employee>()
            {
                new Employee{Id = 1, Name = "Walrus"},
                new Employee{Id = 2,Name = "Tony"}
            };



        }
    }
}
