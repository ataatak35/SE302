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
    public partial class Form3 : Form
    {
        public List<Person> PersonList { get; set; }
        public Person currentPerson;
        public Form3(List<Person> personList)
        {
            currentPerson = new Person();
            PersonList = personList;
            InitializeComponent();
        }
        public Form3()
        {
            currentPerson = new Person();
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = PersonList;
            //dataGridView1.Rows[this]
            dataGridView1.Columns["PersonDictionary"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows[0].Selected)
            {
                currentPerson = dataGridView1.SelectedRows[0].DataBoundItem as Person;
                

            }
            else
            {
                MessageBox.Show("Please select the object");
            }
            
        }
    }
}
