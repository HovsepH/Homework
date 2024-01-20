using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class FileWriter
    {
        public static void WriteToFile(string filePath, string content)
        {
            ConsoleColor current = Console.ForegroundColor;

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(content);
                }
            }

            catch(ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("The file path is empty, contains only white spaces, or contains invalid characters");

                Console.WriteLine(ex.Message);

                ErrorWriter.WriteTo_error_log(ex.Message);

                Console.ForegroundColor = current;
            }

            catch (IOException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Some generic I/O exception during a file operation.");

                Console.WriteLine(ex.Message);

                ErrorWriter.WriteTo_error_log(ex.Message);

                Console.ForegroundColor = current;

            }

            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
