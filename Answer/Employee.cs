using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{

    // CONCRETE EMPLOYEE CLASS

    public class Employee : ISalaryComponent
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public double BasicSalary { get; set; }
        public double AllowanceRate { get; set; }
        public bool TransportUsed { get; set; }

        public Employee(string name, string position, double basicSalary, double allowanceRate, bool transportUsed)
        {
            Name = name;
            Position = position;
            BasicSalary = basicSalary;
            AllowanceRate = allowanceRate;
            TransportUsed = transportUsed;
        }

        public double CalculateSalary()
        {
            return BasicSalary;
        }
    }
}
