using static System.Net.Mime.MediaTypeNames;

namespace Homework4
{
    public class Progtam
    {
        public static int Main(string[] args)
        {
            List<int> ints = new List<int>();

            double average = 0;

            ErrorWriter.filePath = @"C:\Users\ACER\source\repos\Homework\Homework4\error_log";

            string filePath = @"C:\Users\ACER\source\repos\Homework\Homework4\input.txt";

            ConsoleColor current = Console.ForegroundColor;

            try
            {
                ints = FileReader.ReadFromFile(filePath);

                average = Calculate.CalculateAverage(ints);

                foreach (var item in ints)
                {
                    Console.Write(item+" ");
                }

                Console.WriteLine();

                Console.WriteLine($"Average is: {average}");

                filePath = @"C:\Users\ACER\source\repos\Homework\Homework4\output.txt";

                FileWriter.WriteToFile(filePath, average.ToString());


            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.BackgroundColor = ConsoleColor.Blue;

                ErrorWriter.WriteTo_error_log(ex.StackTrace);

                Console.WriteLine(ex.Message);

                Console.ForegroundColor = current;
            }
           


            return 0;
        }
    }
}