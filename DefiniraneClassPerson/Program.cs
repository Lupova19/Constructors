using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneClassPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            BankAccount account1 = new BankAccount();

            account1.Deposit(39);
            person.Accounts.Add(account1);

            Console.Write("Vavedi ime: ");
            person.Name = Console.ReadLine();
            Console.Write("Vavedi godini: ");
            person.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Ime:{person.Name},godini: {person.Age}, balance:{person.GetBalance()}");
        }
    }
}
