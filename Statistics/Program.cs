using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи брой хора: ");
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                people.Add(person);
            }

            var peopleAgeOver30 = people
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Name);

            foreach (Person item in peopleAgeOver30)
            {
                Console.WriteLine($"Name - {item.Name}, Age - {item.Age}");
            }
        }
    }
}
