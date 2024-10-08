using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{
    internal class TransportAllowanceDecorator : SalaryDecorator
    {
        private bool _transportUsed;

        public TransportAllowanceDecorator(ISalaryComponent salaryComponent, bool transportUsed) : base(salaryComponent)
        {
            _transportUsed = transportUsed;
        }

        public override double CalculateSalary()
        {
            double baseSalary = base.CalculateSalary();
            if (!_transportUsed)
            {
                return baseSalary + 10000;
            }

            return baseSalary;
        }
    }
}
