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
    public partial class Form4 : Form
    {
        public Person currentPerson;
        public List<TreeNode> treeView;


        public Form4(List<Person> personList)
        {
            InitializeComponent();
            dataGridView1.DataSource = personList;
            dataGridView1.Columns["PersonDictionary"].Visible = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addNodeButton_Click(object sender, EventArgs e)
        {

            
            if (dataGridView1.SelectedRows[0].Selected)
            {
                currentPerson = dataGridView1.SelectedRows[0].DataBoundItem as Person;
                TreeNode node = new TreeNode(currentPerson.FullName);
                treeView1.Nodes.Add(node);

            }
            else
            {
                MessageBox.Show("Please select the person or node");
            }
        }

        private void addSubnodeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Selected && treeView1.SelectedNode != null)
            {
                currentPerson = dataGridView1.SelectedRows[0].DataBoundItem as Person;
                TreeNode node = new TreeNode(currentPerson.FullName);
                treeView1.SelectedNode.Nodes.Add(node);
                treeView1.ExpandAll();

            }
            else
            {
                MessageBox.Show("Please select the person or node");
            }
        }

        private void removeNodeButton_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Remove();

            }
            else
            {
                MessageBox.Show("Please select the node");
            }
            
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            treeView = treeView1.Nodes.Cast<TreeNode>().ToList();
        }
    }
}
