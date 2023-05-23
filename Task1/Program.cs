// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

class Program {
    static void Main() {
       
        int[,] arr = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };

        
        Console.WriteLine("Исходный массив:");
        PrintArray(arr);

        
        for (int i = 0; i < arr.GetLength(0); i++) {
            for (int j = 0; j < arr.GetLength(1) - 1; j++) {
                for (int k = j + 1; k < arr.GetLength(1); k++) {
                    if (arr[i, k] > arr[i, j]) {
                        int temp = arr[i, j];
                        arr[i, j] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
            }
        }

        
        Console.WriteLine("Отсортированный массив:");
        PrintArray(arr);

        Console.ReadLine();
    }

    
    static void PrintArray(int[,] arr) {
        for (int i = 0; i < arr.GetLength(0); i++) {
            for (int j = 0; j < arr.GetLength(1); j++) {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}