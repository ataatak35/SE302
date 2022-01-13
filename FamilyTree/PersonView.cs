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
    [Serializable]
    public partial class PersonView : UserControl
    {
        public Person Person { get; set; }
        public List<Person> personList;
        public PersonView()
        {
            InitializeComponent();
            
        }

        public PersonView(Person person)
        {
            InitializeComponent();
            Person = person;
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
            String imageLocation = "";

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG files(.*png)|*.png| jpg files(.*jpg)|*.jpg| All Files(*.*)|*.*";
            
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName;
                pictureBox1.ImageLocation = imageLocation;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(personList);

            if (form3.ShowDialog() == DialogResult.OK)
            {
                Label label = new Label();
                label.Text = form3.currentPerson.FullName;
                childrenFlowLayoutPanel2.Controls.Add(label);

            }
        }

        private void addFatherButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(filterMale());
            
            if(form3.ShowDialog() == DialogResult.OK)
            {
                fatherPlaceholderLabel.Text = form3.currentPerson.FullName;
                if(Person.PersonDictionary.ContainsKey("Father") == false) 
                {
                    Person.PersonDictionary.Add("Father", form3.currentPerson);
                }
                else
                {
                    Person.PersonDictionary["Father"] = form3.currentPerson;
                }
                
                
            }
        }

        private void addMotherButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(filterFemale());

            if (form3.ShowDialog() == DialogResult.OK)
            {
                motherPlaceholderLabel.Text = form3.currentPerson.FullName;
                if (Person.PersonDictionary.ContainsKey("Mother") == false)
                {
                    Person.PersonDictionary.Add("Mother", form3.currentPerson);
                }
                else
                {
                    Person.PersonDictionary["Mother"] = form3.currentPerson;
                }
                

            }
        }

        private void addSiblingButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(personList);

            if (form3.ShowDialog() == DialogResult.OK)
            {
                Label label = new Label();
                label.Text = form3.currentPerson.FullName;
                siblingFlowLayoutPanel1.Controls.Add(label);
                             
            }
        }

        private void addPartnerButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(personList);

            if (form3.ShowDialog() == DialogResult.OK)
            {
                partnerPlaceholderLabel.Text = form3.currentPerson.FullName;
                if (Person.PersonDictionary.ContainsKey("Partner") == false)
                {
                    Person.PersonDictionary.Add("Partner", form3.currentPerson);
                }
                else
                {
                    Person.PersonDictionary["Partner"] = form3.currentPerson;
                }
                

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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }

}
