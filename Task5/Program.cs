// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

class Program
{
    static void Main()
    {
        int[,] arr = new int[4, 4];
        int num = 1, rowStart = 0, colStart = 0, rowEnd = 4 - 1, colEnd = 4 - 1;

        
        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            
            for (int i = colStart; i <= colEnd; i++)
            {
                arr[rowStart, i] = num++;
            }
            rowStart++;
            
            for (int i = rowStart; i <= rowEnd; i++)
            {
                arr[i, colEnd] = num++;
            }
            colEnd--;
            
            for (int i = colEnd; i >= colStart; i--)
            {
                arr[rowEnd, i] = num++;
            }
            rowEnd--;
            
            for (int i = rowEnd; i >= rowStart; i--)
            {
                arr[i, colStart] = num++;
            }
            colStart++;
        }
        
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}