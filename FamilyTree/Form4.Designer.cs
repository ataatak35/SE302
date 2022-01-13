
namespace FamilyTree
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.removeNodeButton = new System.Windows.Forms.Button();
            this.addSubnodeButton = new System.Windows.Forms.Button();
            this.addNodeButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.acceptButton);
            this.splitContainer1.Panel2.Controls.Add(this.addNodeButton);
            this.splitContainer1.Panel2.Controls.Add(this.addSubnodeButton);
            this.splitContainer1.Panel2.Controls.Add(this.removeNodeButton);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(266, 450);
            this.treeView1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(525, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // removeNodeButton
            // 
            this.removeNodeButton.Location = new System.Drawing.Point(226, 355);
            this.removeNodeButton.Name = "removeNodeButton";
            this.removeNodeButton.Size = new System.Drawing.Size(116, 23);
            this.removeNodeButton.TabIndex = 1;
            this.removeNodeButton.Text = "Remove Node";
            this.removeNodeButton.UseVisualStyleBackColor = true;
            this.removeNodeButton.Click += new System.EventHandler(this.removeNodeButton_Click);
            // 
            // addSubnodeButton
            // 
            this.addSubnodeButton.Location = new System.Drawing.Point(226, 326);
            this.addSubnodeButton.Name = "addSubnodeButton";
            this.addSubnodeButton.Size = new System.Drawing.Size(116, 23);
            this.addSubnodeButton.TabIndex = 2;
            this.addSubnodeButton.Text = "Add Subnode";
            this.addSubnodeButton.UseVisualStyleBackColor = true;
            this.addSubnodeButton.Click += new System.EventHandler(this.addSubnodeButton_Click);
            // 
            // addNodeButton
            // 
            this.addNodeButton.Location = new System.Drawing.Point(226, 297);
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Size = new System.Drawing.Size(116, 23);
            this.addNodeButton.TabIndex = 3;
            this.addNodeButton.Text = "Add Node";
            this.addNodeButton.UseVisualStyleBackColor = true;
            this.addNodeButton.Click += new System.EventHandler(this.addNodeButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(397, 398);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(121, 40);
            this.acceptButton.TabIndex = 11;
            this.acceptButton.Text = "ACCEPT";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addNodeButton;
        private System.Windows.Forms.Button addSubnodeButton;
        private System.Windows.Forms.Button removeNodeButton;
        private System.Windows.Forms.Button acceptButton;
    }
}