using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

namespace FamilyTree
{
    public partial class MainScreenForm : Form
    {
        public List<PersonView> personViewList;
        public static List<Person> personList;
        public string name;
        public List<Person> loadedPersonList;
        public Family family;
        
        public MainScreenForm()
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
            MemberDataForm form2 = new MemberDataForm();
            if(form2.ShowDialog() == DialogResult.OK)
            {
                personViewList.Add(form2.personView);
                flowLayoutPanel1.Controls.Add(form2.personView);
            }
        }

        private void familyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            familyNameLabel2.Text = familyNameTextBox.Text;
            name = familyNameLabel2.Text;
        }

        private void howToUseButton_Click(object sender, EventArgs e)
        {
            HowToUseForm form6 = new HowToUseForm();
            form6.Show();
        }

        private void treeViewButton_Click(object sender, EventArgs e)
        {
            TreeViewForm form4 = new TreeViewForm(personList);
            form4.Show();
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(familyNameTextBox.Text != "")
            {
                family = new Family(personList, name);
                IFormatter f = new BinaryFormatter();
                Stream str = new FileStream(family.Name + ".txt", FileMode.Create, FileAccess.Write);
                f.Serialize(str, family);
                str.Close();
            }
            else
            {
                MessageBox.Show("Enter the name");
            }
            
        }

        private void loadButton_Click(object sender, EventArgs e)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory;
            OpenFileDialog dialog = new OpenFileDialog()
            {
                FileName = "Select a family file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file",
                InitialDirectory = "C:\\Program Files(x86)\\Team4\\Gondor's Family Tree"
            };
            IFormatter f = new BinaryFormatter();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String filePath = dialog.FileName;
                Stream str = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                family = (Family)f.Deserialize(str);
                loadedPersonList = family.PersonList;
                familyNameLabel2.Text = family.Name;
                familyNameTextBox.Text = family.Name;
                personViewList.Clear();
                foreach (Person person in loadedPersonList)
                {
                    
                    PersonView personView = new PersonView(person);
                    flowLayoutPanel1.Controls.Add(personView);
                }
                str.Close();
            }  

        }

        
     
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            personViewList.Clear();
            personList.Clear();
            flowLayoutPanel1.Controls.Clear();
            familyNameLabel2.Text = "";
            familyNameTextBox.Text = "";
        }
    }
}
