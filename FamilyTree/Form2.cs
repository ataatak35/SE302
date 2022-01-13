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
    public partial class Form2 : Form
    {
        public Person person;
        public PersonView personView;
        
        public Form2()
        {
            InitializeComponent();
            person = new Person();
           
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            person.FullName = fullNameTextBox.Text;
        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            person.Age = ageTextBox.Text;
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            person.BirthDate = dateTimePicker1.Text;
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            person.Gender = genderComboBox.Text;
        }

        public void createPersonView()
        {
            personView = new PersonView(person);
            
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            createPersonView();
        }
    }
}
