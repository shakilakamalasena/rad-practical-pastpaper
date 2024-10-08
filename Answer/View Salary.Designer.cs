namespace Answer
{
    partial class View_Salary
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
            dgvSalaries = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSalaries).BeginInit();
            SuspendLayout();
            // 
            // dgvSalaries
            // 
            dgvSalaries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalaries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalaries.Location = new Point(0, 0);
            dgvSalaries.Name = "dgvSalaries";
            dgvSalaries.RowHeadersWidth = 51;
            dgvSalaries.Size = new Size(679, 549);
            dgvSalaries.TabIndex = 0;
            dgvSalaries.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(490, 580);
            button1.Name = "button1";
            button1.Size = new Size(154, 54);
            button1.TabIndex = 1;
            button1.Text = "Back to Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // View_Salary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 660);
            Controls.Add(button1);
            Controls.Add(dgvSalaries);
            Name = "View_Salary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Salary";
            ((System.ComponentModel.ISupportInitialize)dgvSalaries).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSalaries;
        private Button button1;
    }
}