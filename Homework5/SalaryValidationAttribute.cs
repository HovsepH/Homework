using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public class SalaryValidationAttribute : Attribute
    {
        private double _minimumSalary;

        private double _maximumSalary;

        public SalaryValidationAttribute(double minimumSalary, double maximumSalary)
        {
            _minimumSalary = minimumSalary;

            _maximumSalary = maximumSalary;
        }

        public bool IsValid(double salary)
        {
            if (salary >= _minimumSalary && salary <= _maximumSalary)
                return true;

            return false;
        }

    }
}
