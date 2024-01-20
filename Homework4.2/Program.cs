using System.Runtime.CompilerServices;
namespace Homework4_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Matrix matrix = new Matrix(5, 5);

            Console.WriteLine(matrix[2,4]);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}