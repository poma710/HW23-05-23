// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

class Program
{
    static void Main()
    {
        int[,,] arr = new int[2, 2, 2];

            int num = 10;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    arr[i, j, k] = num++;
                }
            }
        }
       
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.WriteLine($"arr[{i},{j},{k}] = {arr[i, j, k]}");
                }
            }
        }
    }
}