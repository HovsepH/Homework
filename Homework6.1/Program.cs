using System.IO;

namespace Homework6._1;
class Program
{
    static async Task Main(string[] args)
    {
        string? filePath = null;

        while (true)
        {
            Console.WriteLine("1. Input path of text file");
            Console.WriteLine("2. Display file content");
            Console.WriteLine("3. Edit file content");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the path of the text file: ");
                    filePath = Console.ReadLine();
                    break;
                case "2":
                    if (File.Exists(filePath))
                        await AsyncTextFileEditor.DisplayFileContent(filePath);
                    else
                        Console.WriteLine("File does not exist.");
                    break;
                case "3":
                    if (File.Exists(filePath))
                        await AsyncTextFileEditor.EditFileContent(filePath);
                    else
                        Console.WriteLine("File does not exist.");
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

}
