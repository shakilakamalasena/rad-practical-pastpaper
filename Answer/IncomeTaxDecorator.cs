using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{
    internal class IncomeTaxDecorator : SalaryDecorator
    {
        private double _basicSalary;

        public IncomeTaxDecorator(ISalaryComponent salaryComponent, double basicSalary) : base(salaryComponent) 
        {
            _basicSalary = basicSalary;
        }

        public override double CalculateSalary()
        {
            double basicSalary = base.CalculateSalary();

            if (_basicSalary > 10000)
            {
                return basicSalary - (_basicSalary * 0.10);
            }

            return basicSalary;
        }
    }
}
