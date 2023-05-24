using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldestFamilyMember
{
    internal class Family
    {
        private List<Person> members;

        public Family()
        {
            members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            members.Add(member);
        }
        public Person OldestMember()
        {
            Person oldestMember = members
                .OrderByDescending(x => x.Age)
                .FirstOrDefault();
            return oldestMember;
        }
    }
}
