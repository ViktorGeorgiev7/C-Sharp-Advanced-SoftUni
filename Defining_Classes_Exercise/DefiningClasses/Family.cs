using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> _familyMembers;

        public Family()
        {
            FamilyMembers = new List<Person>();
        }
        public List<Person> FamilyMembers
        {
            get
            {
                return _familyMembers;
            }
            set
            {
                _familyMembers = value;
            }
        }

        public void AddMember(Person member)
        {
            FamilyMembers.Add(member);
        }

        public List<Person> GetOldestMember()
        {
            FamilyMembers = FamilyMembers.Where(x => x.Age > 30).ToList();
            FamilyMembers = FamilyMembers.OrderBy(x => x.Name).ToList();
            return FamilyMembers;
        }
    }
}
