using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи брой служители: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string department = input[3];
                string email = "n/a";
                int age = -1;

                employees.Add(new Employee(name, salary, position, department, email, age));
            }
            var highestSalary = employees.GroupBy(e => e.Department)
            .Select(x => new { Department = x.Key, AverageSalary = x.Average(y => y.Salary) })
            .OrderByDescending(x => x.AverageSalary)
            .First();

            Console.WriteLine($"Highest salary: {highestSalary.Department}");
            //!!!
        }
    }
}
