using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    [Serializable]
    public class Family
    {

        public int id = 0;
        public string Name { get; set; }
        
        public  List<Person> PersonList { get; set; }
        
        public Family()
        {
            id =+ 1;
            Name = "Unknown";
            PersonList = null;
        }

        public Family( List<Person> personList, string name) {
            id =+ 1;
            Name = name;     
            PersonList = personList;
        }
        //kişi sayısına personview datalar içine dolacak

    }
}
