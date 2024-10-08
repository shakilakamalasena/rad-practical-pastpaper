using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{
    internal class EPFDecorator : SalaryDecorator
    {
        private double _basicSalary;

        public EPFDecorator(ISalaryComponent component, double basicSalary) : base(component) 
        {
            _basicSalary = basicSalary;
        }

        public override double CalculateSalary()
        {
            double baseSalary = base.CalculateSalary();

            return baseSalary - (_basicSalary * 0.05);
        }
    }
}
