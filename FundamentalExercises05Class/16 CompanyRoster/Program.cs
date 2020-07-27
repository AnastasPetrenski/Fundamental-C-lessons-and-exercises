using System;
using System.Collections.Generic;
using System.Linq;

namespace _16_CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                List<string> person = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                employees.Add(Employee.AddPerson(person));
            }

            List<string> departments = employees.Select(x => x.Department).Distinct().ToList();
            decimal maxAvg = decimal.MinValue;
            string maxDepartment = string.Empty;
            foreach (var item in departments)
            {
                decimal avg = employees.Where(x => x.Department == item).Select(x => x.Salary).Average();
                if (avg > maxAvg)
                {
                    maxAvg = avg;
                    maxDepartment = item;
                }
            }

            Console.WriteLine($"Highest Average Salary: {maxDepartment}");
            foreach (var employee in employees.Where(x => x.Department == maxDepartment).OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }

            foreach (var employee in employees.OrderByDescending(x=>x.Salary).Where(x=>x.Department == maxDepartment))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }

            //employees = employees.OrderBy(x => x.Department == maxDepartment).ThenByDescending(x => x.Salary).ToList();
            //foreach (var item in employees)
            //{
            //    if (item.Department == maxDepartment)
            //    {
            //        Console.WriteLine($"{item.Name} {item.Salary:f2}");
            //    }
            //}
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public Employee()
        {

        }

        public static Employee AddPerson(List<string> person)
        {
            Employee employee = new Employee();
            employee.Name = person[0];
            employee.Salary = decimal.Parse(person[1]);
            employee.Department = person[2];
            return employee;
        }
    }
}
