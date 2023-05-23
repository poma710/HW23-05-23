// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


class Program
{
    static void Main()
    {
        
        int[,] array = new int[,]
        {
            { 1, 2, 3 },
            { 1, 1, 1 },
            { 7, 8, 9 },
            { 10, 11, 12 }
        };

        
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        
        int minSum = int.MaxValue;
        int minIndex = -1;

        
        for (int i = 0; i < rows; i++)
        {
            
            int sum = 0;
            for (int j = 0; j < cols; j++)
            {
                sum += array[i, j];
            }

            
            if (sum < minSum)
            {
                minSum = sum;
                minIndex = i;
            }
        }

        
        Console.WriteLine("Строка с наименьшей суммой элементов: " + minIndex);
    }
}