using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class ErrorWriter
    {
        public static string filePath;
       
        public static void WriteTo_error_log(string content)
        {
            ConsoleColor current = Console.ForegroundColor;

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(content);
                }
            }

            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("The file path is empty, contains only white spaces, or contains invalid characters");

                Console.WriteLine(ex.Message);

                Console.ForegroundColor = current;
            }

            catch (IOException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Some generic I/O exception during a file operation.");

                Console.WriteLine(ex.Message);

                Console.ForegroundColor = current;

            }

            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
