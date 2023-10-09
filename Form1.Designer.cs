namespace OrganizationProfile
{
    partial class frmRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtFirstName = new TextBox();
            label9 = new Label();
            txtMiddleInitial = new TextBox();
            txtContactNo = new TextBox();
            cbPrograms = new ComboBox();
            cbGender = new ComboBox();
            datePickerBirthday = new DateTimePicker();
            btnRegister = new Button();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 68);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Student No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 101);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 138);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 177);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Birthday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 68);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Program";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 101);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "First Name.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(301, 138);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 6;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(325, 177);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 7;
            label8.Text = "Contact No.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(114, 65);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(120, 23);
            txtStudentNo.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(114, 98);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(120, 23);
            txtLastName.TabIndex = 9;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(114, 138);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(73, 23);
            txtAge.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(374, 98);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(480, 101);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 12;
            label9.Text = "M.I.";
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(513, 98);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(47, 23);
            txtMiddleInitial.TabIndex = 13;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(402, 174);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(144, 23);
            txtContactNo.TabIndex = 14;
            // 
            // cbPrograms
            // 
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(369, 65);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(191, 23);
            cbPrograms.TabIndex = 15;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(369, 135);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(84, 23);
            cbGender.TabIndex = 16;
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(114, 174);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(200, 23);
            datePickerBirthday.TabIndex = 17;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(255, 128, 128);
            btnRegister.Location = new Point(246, 232);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(108, 39);
            btnRegister.TabIndex = 18;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(212, 19);
            label10.Name = "label10";
            label10.Size = new Size(182, 28);
            label10.TabIndex = 19;
            label10.Text = "Registration Form";
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(582, 283);
            Controls.Add(label10);
            Controls.Add(btnRegister);
            Controls.Add(datePickerBirthday);
            Controls.Add(cbGender);
            Controls.Add(cbPrograms);
            Controls.Add(txtContactNo);
            Controls.Add(txtMiddleInitial);
            Controls.Add(label9);
            Controls.Add(txtFirstName);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegistration";
            Text = "Organization Profile";
            Load += frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private Label label9;
        private TextBox txtMiddleInitial;
        private TextBox txtContactNo;
        private ComboBox cbPrograms;
        private ComboBox cbGender;
        private DateTimePicker datePickerBirthday;
        private Button btnRegister;
        private Label label10;
    }
}