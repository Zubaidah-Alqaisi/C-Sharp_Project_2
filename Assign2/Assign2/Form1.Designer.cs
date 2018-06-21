namespace Assign2
{
    partial class assign2
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
            this.Submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.changeNum = new System.Windows.Forms.RadioButton();
            this.quit = new System.Windows.Forms.RadioButton();
            this.searchAnOfficeNum = new System.Windows.Forms.RadioButton();
            this.searchForTeleNum = new System.Windows.Forms.RadioButton();
            this.sortTheListName = new System.Windows.Forms.RadioButton();
            this.searchForName = new System.Windows.Forms.RadioButton();
            this.printTheList = new System.Windows.Forms.RadioButton();
            this.addAnEntry = new System.Windows.Forms.RadioButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.officeNumTextBox = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teleNumTextBox = new System.Windows.Forms.TextBox();
            this.ClearAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.AutoSize = true;
            this.Submit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(427, 613);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(109, 34);
            this.Submit.TabIndex = 11;
            this.Submit.Text = "Submit ";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.changeNum);
            this.groupBox1.Controls.Add(this.quit);
            this.groupBox1.Controls.Add(this.searchAnOfficeNum);
            this.groupBox1.Controls.Add(this.searchForTeleNum);
            this.groupBox1.Controls.Add(this.sortTheListName);
            this.groupBox1.Controls.Add(this.searchForName);
            this.groupBox1.Controls.Add(this.printTheList);
            this.groupBox1.Controls.Add(this.addAnEntry);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options:";
            // 
            // changeNum
            // 
            this.changeNum.AutoSize = true;
            this.changeNum.Location = new System.Drawing.Point(283, 62);
            this.changeNum.Name = "changeNum";
            this.changeNum.Size = new System.Drawing.Size(181, 23);
            this.changeNum.TabIndex = 5;
            this.changeNum.TabStop = true;
            this.changeNum.Text = "Change an office number ";
            this.changeNum.UseVisualStyleBackColor = true;
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Location = new System.Drawing.Point(283, 128);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(57, 23);
            this.quit.TabIndex = 7;
            this.quit.TabStop = true;
            this.quit.Text = "Quit ";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // searchAnOfficeNum
            // 
            this.searchAnOfficeNum.AutoSize = true;
            this.searchAnOfficeNum.Location = new System.Drawing.Point(18, 128);
            this.searchAnOfficeNum.Name = "searchAnOfficeNum";
            this.searchAnOfficeNum.Size = new System.Drawing.Size(198, 23);
            this.searchAnOfficeNum.TabIndex = 3;
            this.searchAnOfficeNum.TabStop = true;
            this.searchAnOfficeNum.Text = "Search for an office number ";
            this.searchAnOfficeNum.UseVisualStyleBackColor = true;
            this.searchAnOfficeNum.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // searchForTeleNum
            // 
            this.searchForTeleNum.AutoSize = true;
            this.searchForTeleNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForTeleNum.Location = new System.Drawing.Point(283, 24);
            this.searchForTeleNum.Name = "searchForTeleNum";
            this.searchForTeleNum.Size = new System.Drawing.Size(216, 23);
            this.searchForTeleNum.TabIndex = 4;
            this.searchForTeleNum.TabStop = true;
            this.searchForTeleNum.Text = "Search for a telephone number ";
            this.searchForTeleNum.UseVisualStyleBackColor = true;
            this.searchForTeleNum.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // sortTheListName
            // 
            this.sortTheListName.AutoSize = true;
            this.sortTheListName.Location = new System.Drawing.Point(283, 95);
            this.sortTheListName.Name = "sortTheListName";
            this.sortTheListName.Size = new System.Drawing.Size(154, 23);
            this.sortTheListName.TabIndex = 6;
            this.sortTheListName.TabStop = true;
            this.sortTheListName.Text = "Sort the list by name ";
            this.sortTheListName.UseVisualStyleBackColor = true;
            this.sortTheListName.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // searchForName
            // 
            this.searchForName.AutoSize = true;
            this.searchForName.Location = new System.Drawing.Point(18, 95);
            this.searchForName.Name = "searchForName";
            this.searchForName.Size = new System.Drawing.Size(126, 23);
            this.searchForName.TabIndex = 2;
            this.searchForName.TabStop = true;
            this.searchForName.Text = "Search for name";
            this.searchForName.UseVisualStyleBackColor = true;
            this.searchForName.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // printTheList
            // 
            this.printTheList.AutoSize = true;
            this.printTheList.Location = new System.Drawing.Point(18, 30);
            this.printTheList.Name = "printTheList";
            this.printTheList.Size = new System.Drawing.Size(97, 23);
            this.printTheList.TabIndex = 0;
            this.printTheList.TabStop = true;
            this.printTheList.Text = "Print the list";
            this.printTheList.UseVisualStyleBackColor = true;
            this.printTheList.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // addAnEntry
            // 
            this.addAnEntry.AutoSize = true;
            this.addAnEntry.Location = new System.Drawing.Point(18, 62);
            this.addAnEntry.Name = "addAnEntry";
            this.addAnEntry.Size = new System.Drawing.Size(106, 23);
            this.addAnEntry.TabIndex = 1;
            this.addAnEntry.TabStop = true;
            this.addAnEntry.Text = "Add an entry";
            this.addAnEntry.UseVisualStyleBackColor = true;
            this.addAnEntry.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(31, 563);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(170, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // officeNumTextBox
            // 
            this.officeNumTextBox.Location = new System.Drawing.Point(229, 563);
            this.officeNumTextBox.Name = "officeNumTextBox";
            this.officeNumTextBox.Size = new System.Drawing.Size(128, 20);
            this.officeNumTextBox.TabIndex = 8;
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.FormattingEnabled = true;
            this.output.HorizontalScrollbar = true;
            this.output.ItemHeight = 16;
            this.output.Location = new System.Drawing.Point(31, 29);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(505, 292);
            this.output.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Office Number ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telephone Number";
            // 
            // teleNumTextBox
            // 
            this.teleNumTextBox.Location = new System.Drawing.Point(390, 563);
            this.teleNumTextBox.Name = "teleNumTextBox";
            this.teleNumTextBox.Size = new System.Drawing.Size(146, 20);
            this.teleNumTextBox.TabIndex = 9;
            // 
            // ClearAll
            // 
            this.ClearAll.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll.Location = new System.Drawing.Point(31, 614);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(106, 33);
            this.ClearAll.TabIndex = 10;
            this.ClearAll.Text = "Clear All";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // assign2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 659);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.teleNumTextBox);
            this.Controls.Add(this.officeNumTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Submit);
            this.Name = "assign2";
            this.Text = "Assign 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton addAnEntry;
        private System.Windows.Forms.RadioButton searchForName;
        private System.Windows.Forms.RadioButton printTheList;
        private System.Windows.Forms.RadioButton quit;
        private System.Windows.Forms.RadioButton searchAnOfficeNum;
        private System.Windows.Forms.RadioButton searchForTeleNum;
      //  private System.Windows.Forms.RadioButton ChangeOfficeNum;
        private System.Windows.Forms.RadioButton sortTheListName;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox officeNumTextBox;
        private System.Windows.Forms.ListBox output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teleNumTextBox;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.RadioButton changeNum;
    }
}

