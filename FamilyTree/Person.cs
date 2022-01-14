using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    [Serializable]
    public class Person
    {
        public string FullName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public Dictionary<string, object> PersonDictionary { get; set; }
        public List<Person> childrenList;
        public List<Person> siblingList;

        public Person()
        {
            FullName = "unknown";
            Age = "0";
            Gender = "unknown";
            BirthDate = "unknown";
            PersonDictionary = new Dictionary<string, object>()
            {
                {"Children", childrenList  },
                {"Sibling", siblingList }
            };   
        }

        

        public Person(string fullName, string age, string gender, string birthDate)
        {
            FullName = fullName;
            Age = age;
            Gender = gender;
            BirthDate = birthDate;
            PersonDictionary = new Dictionary<string, object>()
            {
                {"Children", childrenList },
                {"Sibling", siblingList }
            };
        }
    }
}
