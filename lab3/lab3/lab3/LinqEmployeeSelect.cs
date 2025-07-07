using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3Examples
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }

    class LinqEmployeeSelect
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Ram", Salary = 60000, Address = "Kathmandu" },
                new Employee { Id = 2, Name = "Shyam", Salary = 45000, Address = "Pokhara" },
                new Employee { Id = 3, Name = "Hari", Salary = 70000, Address = "Kathmandu" },
                new Employee { Id = 4, Name = "Sita", Salary = 52000, Address = "Lalitpur" }
            };

            var selected = employees
                .Where(e => e.Salary > 50000 && e.Address == "Kathmandu");

            foreach (var emp in selected)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}, Address: {emp.Address}");
            }
        }
    }
}