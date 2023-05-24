using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneClassPerson
{
    internal class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;
        private double balance;
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
        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Person()
        {
            this.Name = name;
            this.Age = 0;
            accounts = new List<BankAccount>();
        }
        public double GetBalance()
        {
            return this.Accounts.Sum(a => a.Balance);
        }
    }
}
