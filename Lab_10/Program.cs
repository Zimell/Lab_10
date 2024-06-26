using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] N = new int[12, 12];
            for (int i = 0; i < 12; i++)
                for (int j = 0; j < 12; j++)
                    N[i, j] = 0;

            for (int i = 0; i <= 11; i++)
                for (int j = 11 - i; j <= i; j++)
                    N[j, 11 - i] = 1;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.ForegroundColor = (N[i, j] == 1) ? ConsoleColor.Red :
                   ConsoleColor.White;
                    Console.Write($"{N[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
                for (int j = 0; j < 12; j++)
                    N[i, j] = rnd.Next(-5, 15);

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.Write($"{N[i, j]} \t");
                }
                Console.WriteLine();
            }

            int arif = 0;
            for (int i = 0; i <= 11; i++) 
            {
                for (int j = 11 - i; j <= i; j++)
                {
                        arif += N[j, 11 - i];
                }
            }

            Console.WriteLine($"Среднее арифметическое: {arif / 42}");

            int total = 0;
            for (int i = 0; i <= 11; i++)
            {
                for (int j = 11 - i; j <= i; j++)
                {
                    if (N[j, 11 - i] < 7)
                    {
                        total++;
                    }
                }
            }

            int[] W = new int[total];
            int count = 0;
            for (int i = 0; i <= 11; i++)
            {
                for (int j = 11 - i; j <= i; j++)
                {
                    if (N[j, 11 - i] < 7)
                    {
                        W[count] = N[j, 11 - i];
                        count++;
                    }
                }
            }
            Console.WriteLine($"W={string.Join(",", W)}");

            int[] A = new int[12];
            int countt = 0;
            for (int i = 0; i <= 11; i++) // Третие задание
            {
                countt = 0;
                for (int j = 11 - i; j <= i; j++)
                {
                    if (N[j, 11 - i] < 0)
                    {
                        countt++;
                        A[] = countt;
                    }
                }

            }
            Console.WriteLine($"A={string.Join(",", A)}");

            int Min = N[0, 0];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (N[i, j] < Min)
                    {
                        Min = N[i, j];
                    }
                }
            }

            int Min_count = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (N[i, j] == Min)
                    {
                        Min_count++;
                    }
                }
            }
            Console.WriteLine($"Количество элементов в левой половине: {Min_count}\nМинимальный элемент всей матрицы: {Min}");
        }
    }
}