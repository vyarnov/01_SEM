﻿// Homework
Console.Clear();
int[,] array = new int[,] {
    {1, 2, 3},
    {1, 10, 0},
    {7, 8, 2},
    {9, 10, 11}
};

int[] SumRows(int[,] array)
{
    int[] arr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++) // строки
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {
            sum += array[i, j];
        }
        arr[i] = sum;
    }
    return arr;
}

int MinIndex(int[] array)
{
    int mindex = 0;
    for (int i = 0; i < array.Length; i++) // строки
        if (array[i] < array[mindex])
        {
            mindex = i;
        }
    return mindex;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // стр
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {
            Console.Write($"{array[i, j]}\t"); // "\t" = 4 пробела 
        } // Закончили обход 0 строки, идем в 1
        Console.WriteLine(); // Перенос на новую строчку
    }
}


int[] ter = SumRows(array);
// Console.WriteLine($"Массив: [ {string.Join("; ", ter)} ]");
PrintArray(array);
int mindx = MinIndex(ter);
Console.WriteLine("Индекс строки массива с минимальной суммой элементов: " + mindx);

//  for (int i = 0; i < array.GetLength(0); i++)
//        {
//         if (i + 1 == x)
//           {
//             for (int j = 0; j < array.GetLength(1); j++)
//              {
//              if (j + 1 == y)
//               result = array [i,j]; 
//              }
//           }






// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// int[,] CreateMatrix(int rows, int columns)
// {
//     int[,] matr = new int[rows, columns]; // [стр, столбцы]
//     Random rnd = new Random();
//     for (int i = 0; i < rows; i++) // rows = matr.GetLength(0)
//     {
//         // j, m, k
//         for (int j = 0; j < columns; j++) // columns = matr.GetLength(1)
//         {
//             matr[i, j] = rnd.Next(101); // [0,100], (0, 101)
//         }
//     }
//     return matr;
// }

// void PrintMatrix(int[,] matr)
// {
// int[] arr = [];
// for (int i = 0; i < array.GetLength(0); i++) // строки
// {
//     int sum = 0;
//     for (int j = 0; j < array.GetLength(1); i++) // строки
//     {
//         sum += array[i, j]
//         }
//     arr[i] = sum;
// }

// return arr;

// }

// void SquareElements(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // стр
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // столбцы
//         {
//             if (i % 2 == 0 && j % 2 == 0) // номер стр И номер стл - четными
//             {
//                 matr[i, j] *= matr[i, j];// matr[i, j] = matr[i, j] * matr[i, j];
//             } // a = a * 5; a *= 5
//         }
//     }
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = CreateMatrix(rows, cols); // Матрица rows на cols
// PrintMatrix(matrix);
// Console.WriteLine("Результат:");
// SquareElements(matrix); // Изменяем матрицу 
// PrintMatrix(matrix);

// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.


// int[,] CreateMatrix(int rows, int columns)
// {
//     int[,] matr = new int[rows, columns]; // [стр, столбцы]
//     Random rnd = new Random();
//     for (int i = 0; i < rows; i++) // rows = matr.GetLength(0)
//     {
//         // j, m, k
//         for (int j = 0; j < columns; j++) // columns = matr.GetLength(1)
//         {
//             matr[i, j] = rnd.Next(101); // [0,100], (0, 101)
//         }
//     }
//     return matr;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // стр
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // столбцы
//         {
//             Console.Write($"{matr[i, j]}\t"); // "\t" = 4 пробела 
//         } // Закончили обход 0 строки, идем в 1
//         Console.WriteLine(); // Перенос на новую строчку
//     }
// }

// int GetMainDiagonalSum(int[,] matr)
// {
//     int sum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++) // стр
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // столбцы
//         {
//             if (i == j)
//             {
//                 sum += matr[i, j];// sum = sum + matr[i, j];
//             }
//         }
//     }
//     return sum;
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = CreateMatrix(rows, cols); // Матрица rows на cols
// PrintMatrix(matrix);
// Console.WriteLine($"Результат: {GetMainDiagonalSum(matrix)}");

// int[,] CreateMatrix(int rows, int columns)
// {
//     int[,] matr = new int[rows, columns]; // [стр, столбцы]
//     Random rnd = new Random();
//     for (int i = 0; i < rows; i++) // rows = matr.GetLength(0)
//     {
//         // j, m, k
//         for (int j = 0; j < columns; j++) // columns = matr.GetLength(1)
//         {
//             matr[i, j] = rnd.Next(101); // [0,100], (0, 101)
//         }
//     }
//     return matr;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // стр
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // столбцы
//         {
//             Console.Write($"{matr[i, j]}\t"); // "\t" = 4 пробела 
//         } // Закончили обход 0 строки, идем в 1
//         Console.WriteLine(); // Перенос на новую строчку
//     }
// }

// double[] GetArrayWithMeans(int[,] matrix)
// {
//     double[] means = new double[matrix.GetLength(0)];
//     // 1 2     means = [1.5, 0]
//     // 3 4
//     for (int i = 0; i < matrix.GetLength(0); i++) // стр
//     {
//         double currentSum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
//         {
//             currentSum += matrix[i, j]; // currentSum = currentSum + matrix[i,j] ]
//         }
//         double currentMean = Math.Round(currentSum / matrix.GetLength(1), 2);
//         means[i] = currentMean;
//     }
//     return means;
// }
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = CreateMatrix(rows, cols); // Матрица rows на cols
// PrintMatrix(matrix);
// double[] res = GetArrayWithMeans(matrix);
// Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");