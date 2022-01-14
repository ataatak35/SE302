
namespace FamilyTree
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clearButton = new System.Windows.Forms.Button();
            this.familyNameLabel = new System.Windows.Forms.Label();
            this.familyNameTextBox = new System.Windows.Forms.TextBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.howToUseButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.familyNameLabel2 = new System.Windows.Forms.Label();
            this.treeViewButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.process1 = new System.Diagnostics.Process();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitContainer1.Panel1.Controls.Add(this.clearButton);
            this.splitContainer1.Panel1.Controls.Add(this.familyNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.familyNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.addMemberButton);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.familyNameLabel2);
            this.splitContainer1.Panel2.Controls.Add(this.treeViewButton);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1382, 653);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 0;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(39, 192);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(111, 36);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // familyNameLabel
            // 
            this.familyNameLabel.AutoSize = true;
            this.familyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.familyNameLabel.Location = new System.Drawing.Point(30, 49);
            this.familyNameLabel.Name = "familyNameLabel";
            this.familyNameLabel.Size = new System.Drawing.Size(126, 25);
            this.familyNameLabel.TabIndex = 10;
            this.familyNameLabel.Text = "Family Name";
            // 
            // familyNameTextBox
            // 
            this.familyNameTextBox.Location = new System.Drawing.Point(30, 84);
            this.familyNameTextBox.Name = "familyNameTextBox";
            this.familyNameTextBox.Size = new System.Drawing.Size(129, 22);
            this.familyNameTextBox.TabIndex = 9;
            this.familyNameTextBox.TextChanged += new System.EventHandler(this.familyNameTextBox_TextChanged);
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(39, 134);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(111, 36);
            this.addMemberButton.TabIndex = 8;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.howToUseButton);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.loadButton);
            this.panel2.Location = new System.Drawing.Point(3, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 180);
            this.panel2.TabIndex = 6;
            // 
            // howToUseButton
            // 
            this.howToUseButton.Location = new System.Drawing.Point(29, 66);
            this.howToUseButton.Name = "howToUseButton";
            this.howToUseButton.Size = new System.Drawing.Size(120, 40);
            this.howToUseButton.TabIndex = 8;
            this.howToUseButton.Text = "How to Use";
            this.howToUseButton.UseVisualStyleBackColor = true;
            this.howToUseButton.Click += new System.EventHandler(this.howToUseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(7, 137);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(65, 36);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(103, 137);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 36);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // familyNameLabel2
            // 
            this.familyNameLabel2.AutoSize = true;
            this.familyNameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.familyNameLabel2.Location = new System.Drawing.Point(505, 9);
            this.familyNameLabel2.Name = "familyNameLabel2";
            this.familyNameLabel2.Size = new System.Drawing.Size(0, 25);
            this.familyNameLabel2.TabIndex = 11;
            // 
            // treeViewButton
            // 
            this.treeViewButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.treeViewButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.treeViewButton.Location = new System.Drawing.Point(1051, 605);
            this.treeViewButton.Name = "treeViewButton";
            this.treeViewButton.Size = new System.Drawing.Size(132, 45);
            this.treeViewButton.TabIndex = 10;
            this.treeViewButton.Text = "Tree View";
            this.treeViewButton.UseVisualStyleBackColor = false;
            this.treeViewButton.Click += new System.EventHandler(this.treeViewButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(970, 611);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(979, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1400, 700);
            this.MinimumSize = new System.Drawing.Size(1400, 700);
            this.Name = "Form1";
            this.Text = "Gondor\'s Family Tree";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button howToUseButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label familyNameLabel;
        private System.Windows.Forms.TextBox familyNameTextBox;
        private System.Windows.Forms.Label familyName;
        private System.Windows.Forms.Button treeViewButton;
        private System.Windows.Forms.Label familyNameLabel2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

