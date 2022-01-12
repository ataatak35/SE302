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
        public Dictionary<string, object> PersonDictionary { get; set; }
        public List<Person> childList;
        public List<Person> siblingList;
        public Person Partner { get; set; }

        public Person()
        {
            FullName = "unknown";
            Age = "0";
            Gender = "unknown";
            BirthDate = "unknown";
            PersonDictionary = new Dictionary<string, object>()
            {
                {"Children", childList  },
                {"Sibling", siblingList }
            };
            id++;
        }

        

        public Person(string fullName, string age, string gender, string birthDate, string memberType)
        {
            FullName = fullName;
            Age = age;
            Gender = gender;
            BirthDate = birthDate;
            MemberType = memberType;
            PersonDictionary = new Dictionary<string, object>()
            {
                {"Children", childList },
                {"Sibling", siblingList }
            };
            id++;
        }
        public void addFather(Person father)
        {
            this.PersonDictionary.Add("Father", father);
            father.childList.Add(this);
            
        }

        public void addMother(Person mother)
        {
            this.PersonDictionary.Add("Mother", mother);
            mother.childList.Add(this);
        }

        public void addChildren(List<Person> childrenList)
        {
            this.PersonDictionary.Add("Children", childrenList);
            for(int i=0; i<childrenList.Count; i++)
            {

            }
        }

        public void addPartner(Person partner)
        {
            this.PersonDictionary.Add("Partner", partner);
            partner.PersonDictionary.Add("Partner", this);
            var tempChildList = this.PersonDictionary["Children"] as List<Person>;

            if(tempChildList.Count != 0)
            {
                partner.PersonDictionary["Children"] = this.PersonDictionary["Children"];
            }
            else
            {
                this.PersonDictionary["Childre"] = partner.PersonDictionary["Children"]; 

            }
        }

        public void addSibling(Person sibling)
        {
            this.siblingList.Add(sibling);
            if(this.PersonDictionary["Fater"] != null)
            {

            };

        }
    }

}
