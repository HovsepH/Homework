using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Homework4
{
    public class FileReader
    {
        public static List<int> ReadFromFile(string filePath)
        {
            List<int> list = new List<int>();

            ConsoleColor current = Console.ForegroundColor;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        list.Add(int.Parse(reader.ReadLine()));
                    }
                }

                return list;

            }

            catch (FileNotFoundException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("File not found: " + filePath);

                Console.WriteLine(ex.Message);

                ErrorWriter.WriteTo_error_log(ex.Message);

                Console.ForegroundColor = current;

                return null;
            }

            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("The file contains non-numeric data");

                Console.WriteLine(ex.Message);

                ErrorWriter.WriteTo_error_log(ex.Message);

                Console.ForegroundColor = current;

                return null;
            }

            catch (IOException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Some generic I/O exception during a file operation.");

                Console.WriteLine(ex.Message);

                ErrorWriter.WriteTo_error_log(ex.Message);

                Console.ForegroundColor = current;

                return null;
            }

            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
