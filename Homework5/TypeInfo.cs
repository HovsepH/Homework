using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class TypeInfo
    {
        public static void DisplayTypeInformation<T>()
        {
            Type type = typeof(T);

            Console.WriteLine("Type is: " + type + "\n");

            Console.WriteLine("Properties:\n");

            foreach (var item in type.GetProperties())
            {
                Console.WriteLine($"- {item.Name}: {item.PropertyType.Name}");
            }

            Console.WriteLine("\nMethods:\n");

            foreach (var item in type.GetMethods())
            {
                Console.WriteLine($"- {item.Name}");
            }
        }
    }
}
