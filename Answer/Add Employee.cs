using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Answer
{
    public partial class Add_Employee : Form
    {
        private List<Employee> employeeList;

        public Add_Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            string name = text_name.Text;
            string position = text_position.Text;
            double basicSalary = double.Parse(text_basicSalary.Text);
            double allowanceRate = double.Parse(text_rate.Text);
            bool transportUsed;
            if (check_use.Checked == true)
            {
                transportUsed = true;
            } else if (check_use.Checked == false)
            {
                transportUsed = false;
            } else if (check_dontuse.Checked == true)
            {
                transportUsed = false;
            } else if (check_dontuse.Checked == false)
            {
                transportUsed = true;
            } else
            {
                return;
            }

            Employee employee = new Employee(name, position, basicSalary, allowanceRate, transportUsed);

            Employee_List.EmployeeList.Add(employee);

            MessageBox.Show("Employee Addded Successfully!");

            ClearForm();

            void ClearForm()
            {
                text_name.Clear();
                text_position.Clear();
                text_basicSalary.Clear();
                text_rate.Clear();
                check_dontuse.Checked = false;
                check_use.Checked = false;
            }

        }
    }
}
