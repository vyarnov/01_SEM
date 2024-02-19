// HomeWork

// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// void PrintValues(int M, int N)
// {
//     if (M <= N)
//     {
//         if (M == N)
//         {
//             Console.WriteLine(M);
//             return;
//         }
//         Console.WriteLine(M);
//         PrintValues(M + 1, N);
//     }
//     if (M >= N)
//     {
//         if (M == N)
//         {
//             Console.WriteLine(N);
//             return;
//         }
//         Console.WriteLine(M);
//         PrintValues(M - 1, N);
//     }
// }

// int CheckNaturNumb(int A)
// {

//     if (A <= 0)
//     {
//         PrintErrorNaturNumb();
//     }

//     return A;
// }

// void PrintErrorNaturNumb()
// {
//     Console.WriteLine("Вы ввели не натуральныое число");
//     Console.WriteLine("Программа завершена");
//     Environment.Exit(-1);
// }


// Console.WriteLine("Программа выведет все натуральные числа в промежутке от M до N:");
// Console.WriteLine();


// Console.Write("Введите начальное значение: ");
// int valueM = Convert.ToInt32(Console.ReadLine());
// valueM = CheckNaturNumb(valueM);

// Console.Write("Введите конечное значение: ");
// int valueN = Convert.ToInt32(Console.ReadLine());
// valueN = CheckNaturNumb(valueN);

// PrintValues(valueM, valueN);




// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


// int CheckNegNumb(int A)
// {

//     if (A < 0)
//     {
//         PrintErrorNegNumb();
//     }

//     return A;
// }

// void PrintErrorNegNumb()
// {
//     Console.WriteLine("Вы ввели отрицательное число");
//     Console.WriteLine("Программа завершена");
//     Environment.Exit(-1);
// }

// int GetAkkerman(int M, int N)
// {
//     if (M == 0) return N + 1;

//     else if (M > 0 && N == 0) return GetAkkerman(M - 1, 1);
//     else return GetAkkerman(M - 1, GetAkkerman(M, N - 1));
// }

// Console.WriteLine("Программа вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M до N:");
// Console.WriteLine();

// Console.Write("Введите значение M: ");
// int valueM = Convert.ToInt32(Console.ReadLine());
// valueM = CheckNegNumb(valueM);

// Console.Write("Введите значение N: ");
// int valueN = Convert.ToInt32(Console.ReadLine());
// valueN = CheckNegNumb(valueN);


// Console.Write($"Функция Аккермана равна: {GetAkkerman(valueM, valueN)}");



// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// void PrintInvertedArray(char[] array, int J)
// {

//     if (J == 0)
//     {
//         // Базовый случай - случай остановки рекурсии
//         Console.Write($"{array[J]}");
//         return;
//     }
//     Console.Write($"{array[J]}");
//     PrintInvertedArray(array, J - 1);
// }

// Console.WriteLine("Программа отображает введенные элементы массива с конца с помощью рекурсии.");
// Console.WriteLine();

// Console.Write("Введите элементы массива:");
// string line = Console.ReadLine();
// char[] array = line.ToCharArray();
// int J = array.Length - 1;
// PrintInvertedArray(array, J);