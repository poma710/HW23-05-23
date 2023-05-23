// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


class Program
{
    static void Main()
    {
        int[,] matrix1 = new int[,] { { 2, 4 }, { 3, 2 } };
        int[,] matrix2 = new int[,] { { 3, 4 }, { 3, 3 } };
        int[,] result = new int[2, 2];
    
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
      
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}