using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_2
{
    public class AsyncTextFileEditor
    {
        static SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);

        public static async Task DisplayFileContent(string filePath)
        {
            await semaphore.WaitAsync();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string content = await reader.ReadToEndAsync();
                    Console.WriteLine("content: ");
                    Console.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                semaphore.Release();
            }

        }

        public static async Task EditFileContent(string filePath)
        {
            await semaphore.WaitAsync();
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    Console.WriteLine("Write the content: ");
                    string? content = Console.ReadLine();
                    await writer.WriteAsync(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                semaphore.Release();
            }
        }
    }

}
