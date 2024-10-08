using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{
    abstract class SalaryDecorator : ISalaryComponent
    {
        private ISalaryComponent _component;

        public SalaryDecorator(ISalaryComponent component)
        {
            _component = component;
        }

        public virtual double CalculateSalary()
        {
            return _component.CalculateSalary();
        }
    }
}
