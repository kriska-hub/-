using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_1_исрп
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Random rnd = new Random();
            Console.WriteLine("Введите цисло строк");
            bool f = int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine("Введите цисло столбцов");
            bool d = int.TryParse(Console.ReadLine(), out int m);
            if ((f && d) && (n > 0) && (m > 0))
            {
                int[,] matrix = new int[n, m];
                m = matrix.GetLength(0);
                n = matrix.GetLength(1);
                bool[] mas = new bool[n];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = rnd.Next(-50, 50);
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 0)
                        {

                            mas[j]= true;
                        }
                    }

                }

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (mas[j])
                    {
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            sum += matrix[i, j];
                        }
                    }
                }
                Console.WriteLine("Сумма: " + sum);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            
            Console.ReadKey();
        }
    }
}
