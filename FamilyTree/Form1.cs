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
    public partial class Form1 : Form
    {
        public List<PersonView> personViewList;
        public static List<Person> personList;
        public Form1()
        {
            InitializeComponent();
            personList = new List<Person>();
            personViewList = new List<PersonView>();
        }

        private void personView2_Load(object sender, EventArgs e)
        {

        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if(form2.ShowDialog() == DialogResult.OK)
            {
                personViewList.Add(form2.personView);
                flowLayoutPanel1.Controls.Add(form2.personView);
            }
        }

        private void familyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            familyName.Text = familyNameTextBox.Text;
        }

        private void aboutUsButton_Click(object sender, EventArgs e)
        {

        }

        private void howToUseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
