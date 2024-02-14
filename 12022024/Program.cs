// Homework
Console.Clear();
int[,] array = new int[,] {
    {1, 2, 3},
    {1, 10, 0},
    {7, 8, 2},
    {9, 10, 11}
};

int[] SumRows(int[,] array)
{
    int[] arr = new int[
        
        
    ];
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