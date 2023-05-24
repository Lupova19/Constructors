using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsClassPerson
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
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person()
        {
            name = "No name";
            age = 1;
        }
        public Person(int age)
        {
            name = "No name";
            this.age = age;
        }

        public void PrintMe()
        {
            Console.WriteLine($"Name:{this.Name},Age:{this.Age}");
        }
    }
}
