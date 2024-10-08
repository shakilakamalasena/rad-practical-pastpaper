using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Answer
{
    public partial class View_Salary : Form
    {
        public View_Salary()
        {
            InitializeComponent();
            LoadSalaries();
        }

        public void LoadSalaries()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Name");
            dt.Columns.Add("Position");
            dt.Columns.Add("Net Salary");

            foreach (var emp in Employee_List.EmployeeList)
            {
                ISalaryComponent salaryComponent = emp;

                salaryComponent = new AllowanceDecorator(salaryComponent, emp.AllowanceRate, emp.BasicSalary);
                salaryComponent = new TransportAllowanceDecorator(salaryComponent, emp.TransportUsed);
                salaryComponent = new EPFDecorator(salaryComponent, emp.BasicSalary);
                salaryComponent = new IncomeTaxDecorator(salaryComponent, emp.BasicSalary);

                double netSalary = salaryComponent.CalculateSalary();

                dt.Rows.Add(emp.Name, emp.Position, netSalary);
            }

            dgvSalaries.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
