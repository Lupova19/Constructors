using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldestFamilyMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            Console.Write("Въведи брой членове: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                family.AddMember(new Person(name, age));
            }
            Person oldestMember = family.OldestMember();

            Console.WriteLine($"The oldest member: {oldestMember.Name}, {oldestMember.Age} years old!!!");
        }
    }
}
