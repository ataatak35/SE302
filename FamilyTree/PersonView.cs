using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyTree
{
    public partial class PersonView : UserControl
    {
        public Person Person { get; set; }
        public Image Image{ get; set; }
        public List<Person> personList;
        public PersonView()
        {
            InitializeComponent();
            
        }

        public PersonView(Person person, Image image)
        {
            InitializeComponent();
            Person = person;
            Image = image;
            personList = Form1.personList;
            personList.Add(person);
            namePlaceholder.Text = person.FullName;
            agePlaceholderLabel.Text = person.Age;
            genderPlaceholderLabel.Text = person.Gender;
            birthDatePlaceholderLabel.Text = person.BirthDate;
            if (person.Gender == "Female")
            {
                this.BackColor = Color.Pink;
            }
            else if (person.Gender == "Male")
            {
                this.BackColor = Color.LightSkyBlue;
            }
        }

        

        private void PersonView_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void addFatherButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(filterMale());
            
            if(form3.ShowDialog() == DialogResult.OK)
            {
                fatherPlaceholderLabel.Text = form3.currentPerson.FullName;
            }
        }

        public List<Person> filterMale() {
            List<Person> tempList = new List<Person>();
            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].Gender == "Male")
                {
                    tempList.Add(personList[i]);
                }
            }

            if(tempList == null)
            {
                tempList.Add(new Person { });
            }

            return tempList;
        }

        public List<Person> filterFemale()
        {
            List<Person> tempList = new List<Person>();
            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].Gender == "Female")
                {
                    tempList.Add(personList[i]);
                }
            }

            if (tempList == null)
            {
                tempList.Add(new Person { });
            }

            return tempList;
        }
    }

}
