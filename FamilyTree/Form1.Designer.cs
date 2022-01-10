
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.howToUseButton = new System.Windows.Forms.Button();
            this.aboutUsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.familyNameTextBox = new System.Windows.Forms.TextBox();
            this.familyNameLabel = new System.Windows.Forms.Label();
            this.familyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.familyNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.familyNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.addMemberButton);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.familyName);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1382, 629);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.howToUseButton);
            this.panel2.Controls.Add(this.aboutUsButton);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.loadButton);
            this.panel2.Location = new System.Drawing.Point(3, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 180);
            this.panel2.TabIndex = 6;
            // 
            // howToUseButton
            // 
            this.howToUseButton.Location = new System.Drawing.Point(36, 57);
            this.howToUseButton.Name = "howToUseButton";
            this.howToUseButton.Size = new System.Drawing.Size(111, 36);
            this.howToUseButton.TabIndex = 8;
            this.howToUseButton.Text = "How to Use";
            this.howToUseButton.UseVisualStyleBackColor = true;
            this.howToUseButton.Click += new System.EventHandler(this.howToUseButton_Click);
            // 
            // aboutUsButton
            // 
            this.aboutUsButton.Location = new System.Drawing.Point(35, 15);
            this.aboutUsButton.Name = "aboutUsButton";
            this.aboutUsButton.Size = new System.Drawing.Size(111, 36);
            this.aboutUsButton.TabIndex = 7;
            this.aboutUsButton.Text = "About Us";
            this.aboutUsButton.UseVisualStyleBackColor = true;
            this.aboutUsButton.Click += new System.EventHandler(this.aboutUsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(9, 126);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(65, 36);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(105, 126);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 36);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1180, 590);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // familyNameTextBox
            // 
            this.familyNameTextBox.Location = new System.Drawing.Point(30, 84);
            this.familyNameTextBox.Name = "familyNameTextBox";
            this.familyNameTextBox.Size = new System.Drawing.Size(129, 22);
            this.familyNameTextBox.TabIndex = 9;
            this.familyNameTextBox.TextChanged += new System.EventHandler(this.familyNameTextBox_TextChanged);
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
            // familyName
            // 
            this.familyName.AutoSize = true;
            this.familyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.familyName.Location = new System.Drawing.Point(546, 9);
            this.familyName.Name = "familyName";
            this.familyName.Size = new System.Drawing.Size(0, 20);
            this.familyName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 629);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button howToUseButton;
        private System.Windows.Forms.Button aboutUsButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label familyNameLabel;
        private System.Windows.Forms.TextBox familyNameTextBox;
        private System.Windows.Forms.Label familyName;
    }
}

