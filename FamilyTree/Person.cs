using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    public class Person
    {
        public int id = 0;
        public string FullName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string MemberType { get; set; }
        public Dictionary<string, Person> PersonDictionary { get; set; }

        public Person()
        {
            FullName = "unknown";
            Age = "0";
            Gender = "unknown";
            BirthDate = "unknown";
            PersonDictionary = new Dictionary<string, Person>()
            {
                {"Father", null },
                {"Mother", null },
                {"Sibling", null },
                {"Child", null },
                {"Partner", null },
            };
            id++;
        }

        public Person(int id, string fullName, string age, string gender, string birthDate, string memberType)
        {
            FullName = fullName;
            Age = age;
            Gender = gender;
            BirthDate = birthDate;
            MemberType = memberType;
            id++;
        }

        public Person(int id, string fullName, string age, string gender, string birthDate, string memberType, Dictionary<string, Person> personDictionary)
        {
            FullName = fullName;
            Age = age;
            Gender = gender;
            BirthDate = birthDate;
            MemberType = memberType;
            PersonDictionary = personDictionary;
            id++;
        }
        public void addFather(int id, string fullName, string age, string gender, string birthDate, string memberType)
        {
            Person father = new Person(id, fullName, age, gender, birthDate, memberType);
            PersonDictionary.Add("Father", father);
            
        }

        public void addMother(int id, string fullName, string age, string gender, string birthDate, string memberType)
        {
            Person mother = new Person(id, fullName, age, gender, birthDate, memberType);
            PersonDictionary.Add("Mother", mother);
        }
    }

}
