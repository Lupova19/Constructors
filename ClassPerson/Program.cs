using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            person1.Name = "Pesho";
            person1.Age = 20;
            person2.Name = "Gosho";
            person2.Age = 18;
            person3.Name = "Stamat";
            person3.Age = 43;

            person1.PrintMe();
            person2.PrintMe();
            person3.PrintMe();
        }
    }
}
