using System;
using System.Linq;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] Matrix = new int[22, 6];

            //заполняем случайными числами от -100 до 100
            Random random = new Random();
            int rand;
            for (int i = 0; i < 22; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    rand = random.Next(-100, 100);
                    Matrix[i, j] = rand;
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int max;
            for (int i = 0; i < 22; i++)
            {
                max = -100;
                for (int j = 0; j < 6; j++)
                {
                    if (Matrix[i, j] > max) max = Matrix[i, j];
                }
                Console.WriteLine($"Max: {max} Строка: {i}");
            }
            Console.ReadKey();
        }
    }
}
