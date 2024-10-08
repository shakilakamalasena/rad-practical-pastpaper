using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{
    internal class AllowanceDecorator : SalaryDecorator
    {
        private double _allowanceRate;
        private double _basicSalary;

        public AllowanceDecorator(ISalaryComponent salaryComponent, double allowanceRate, double basicSalary) : base(salaryComponent) 
        {
            _allowanceRate = allowanceRate;
            _basicSalary = basicSalary;
        }

        public override double CalculateSalary()
        {
            double baseSalary = base.CalculateSalary();
            return baseSalary + (_basicSalary * _allowanceRate);
        }
    }
}
