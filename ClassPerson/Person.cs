using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person()
        {


        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void PrintMe()
        {
            Console.WriteLine($"Name:{this.Name},Age:{this.Age}");
        }
    }
}
