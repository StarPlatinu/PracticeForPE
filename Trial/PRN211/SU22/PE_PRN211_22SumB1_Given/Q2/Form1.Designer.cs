
namespace Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.courtesy = new System.Windows.Forms.ComboBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInsertAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(427, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(651, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(158, 25);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(190, 27);
            this.firstName.TabIndex = 1;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(158, 87);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(190, 27);
            this.lastName.TabIndex = 2;
            // 
            // courtesy
            // 
            this.courtesy.FormattingEnabled = true;
            this.courtesy.Items.AddRange(new object[] {
            "Dr.",
            "Mr.",
            "Mrs.",
            "Ms."});
            this.courtesy.Location = new System.Drawing.Point(158, 169);
            this.courtesy.Name = "courtesy";
            this.courtesy.Size = new System.Drawing.Size(144, 28);
            this.courtesy.TabIndex = 3;
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(158, 267);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(190, 28);
            this.department.TabIndex = 4;
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(158, 343);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(250, 27);
            this.birthDate.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(158, 409);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInsertAll
            // 
            this.btnInsertAll.Location = new System.Drawing.Point(845, 409);
            this.btnInsertAll.Name = "btnInsertAll";
            this.btnInsertAll.Size = new System.Drawing.Size(233, 29);
            this.btnInsertAll.TabIndex = 7;
            this.btnInsertAll.Text = "Insert all into database";
            this.btnInsertAll.UseVisualStyleBackColor = true;
            this.btnInsertAll.Click += new System.EventHandler(this.btnInsertAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Title Of Courtesy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "BirthDate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.department);
            this.Controls.Add(this.courtesy);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Add Employees";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.ComboBox courtesy;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInsertAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

