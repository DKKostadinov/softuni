namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Family
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

        public Person GetOldestMember()
        {
            Person oldestMember = members.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestMember;
        }

        public List<Person> GetListOfOlderMembers()
        {
            List<Person> olderMembers = new List<Person>();
            foreach (var member in members)
            {
                if (member.Age > 30) olderMembers.Add(member);
            }
            return olderMembers.OrderBy(n => n.Name).ToList();
        }
    }
}
