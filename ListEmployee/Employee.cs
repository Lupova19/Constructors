using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEmployee
{
    internal class Employee
    {
        private string name;
        private int age;
        private decimal salary;
        private string email;
        private string position;
        private string department;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public Employee(string name, decimal salary, string position, string department, string email, int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = email;
            this.Age = age;
        }

        public void Print()
        {
            Console.WriteLine($"{this.Name}, {this.Salary:F2}, {this.Email}, {this.Age}");
        }
    }
}
