using System.Reflection;

namespace Homework5
{
    class ValidateSalary
    {
        public static void ValidateSalaryAttribute<T>()
        {
            Type type = typeof(T);

            var salaryProperty = type.GetProperty("Salary");

            if (salaryProperty != null)
            {
                var validationAttribute =
                    (SalaryValidationAttribute)salaryProperty.GetCustomAttribute(typeof(SalaryValidationAttribute));

                if (validationAttribute != null)
                {
                    double currentSalary = 7;

                    if (validationAttribute.IsValid(currentSalary))
                    {
                        Console.WriteLine("Salary is within the specified range.");
                    }
                    else
                    {
                        Console.WriteLine("Salary is outside the specified range.");
                    }
                }
                else
                {
                    Console.WriteLine("SalaryValidationAttribute is not applied to Salary property.");
                }
            }
        }
    }
}
