namespace Answer
{
    partial class Add_Employee
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
            label1 = new Label();
            text_name = new TextBox();
            text_position = new TextBox();
            label2 = new Label();
            text_basicSalary = new TextBox();
            label3 = new Label();
            label4 = new Label();
            text_rate = new TextBox();
            label5 = new Label();
            check_use = new CheckBox();
            check_dontuse = new CheckBox();
            button1 = new Button();
            btn_addEmployee = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 70);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee Name";
            // 
            // text_name
            // 
            text_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_name.Location = new Point(314, 67);
            text_name.Name = "text_name";
            text_name.Size = new Size(312, 34);
            text_name.TabIndex = 1;
            // 
            // text_position
            // 
            text_position.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_position.Location = new Point(314, 127);
            text_position.Name = "text_position";
            text_position.Size = new Size(312, 34);
            text_position.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 130);
            label2.Name = "label2";
            label2.Size = new Size(190, 28);
            label2.TabIndex = 2;
            label2.Text = "Destination/Position";
            // 
            // text_basicSalary
            // 
            text_basicSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_basicSalary.Location = new Point(314, 193);
            text_basicSalary.Name = "text_basicSalary";
            text_basicSalary.Size = new Size(312, 34);
            text_basicSalary.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 196);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(113, 28);
            label3.TabIndex = 4;
            label3.Text = "Basic Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 272);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 6;
            label4.Text = "Staff Transport";
            // 
            // text_rate
            // 
            text_rate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_rate.Location = new Point(314, 342);
            text_rate.Name = "text_rate";
            text_rate.Size = new Size(312, 34);
            text_rate.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 345);
            label5.Name = "label5";
            label5.Size = new Size(145, 28);
            label5.TabIndex = 8;
            label5.Text = "Allowance Rate";
            // 
            // check_use
            // 
            check_use.AutoSize = true;
            check_use.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_use.Location = new Point(314, 271);
            check_use.Name = "check_use";
            check_use.Size = new Size(63, 32);
            check_use.TabIndex = 10;
            check_use.Text = "use";
            check_use.UseVisualStyleBackColor = true;
            // 
            // check_dontuse
            // 
            check_dontuse.AutoSize = true;
            check_dontuse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_dontuse.Location = new Point(418, 271);
            check_dontuse.Name = "check_dontuse";
            check_dontuse.Size = new Size(127, 32);
            check_dontuse.TabIndex = 11;
            check_dontuse.Text = "do not use";
            check_dontuse.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(470, 569);
            button1.Name = "button1";
            button1.Size = new Size(156, 63);
            button1.TabIndex = 12;
            button1.Text = "Back to Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_addEmployee
            // 
            btn_addEmployee.Location = new Point(258, 569);
            btn_addEmployee.Name = "btn_addEmployee";
            btn_addEmployee.Size = new Size(156, 63);
            btn_addEmployee.TabIndex = 13;
            btn_addEmployee.Text = "Add Employee";
            btn_addEmployee.UseVisualStyleBackColor = true;
            btn_addEmployee.Click += btn_addEmployee_Click;
            // 
            // Add_Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 670);
            Controls.Add(btn_addEmployee);
            Controls.Add(button1);
            Controls.Add(check_dontuse);
            Controls.Add(check_use);
            Controls.Add(text_rate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(text_basicSalary);
            Controls.Add(label3);
            Controls.Add(text_position);
            Controls.Add(label2);
            Controls.Add(text_name);
            Controls.Add(label1);
            Name = "Add_Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox text_name;
        private TextBox text_position;
        private Label label2;
        private TextBox text_basicSalary;
        private Label label3;
        private Label label4;
        private TextBox text_rate;
        private Label label5;
        private CheckBox check_use;
        private CheckBox check_dontuse;
        private Button button1;
        private Button btn_addEmployee;
    }
}