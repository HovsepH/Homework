using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [SalaryValidationAttribute(5, 10)]
        public double Salary { get; set; }

    }
}
