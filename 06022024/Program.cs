//Homework
// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

Console.Write("Введите целое число: ");
int text = Convert.ToInt32(Console.ReadLine());
Console.Write(text);




// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)














// while (true) // true == true
// {
// Console.Write("Введите текст: ");
// string text = Console.ReadLine();
// if (text == "q")
// {
// break;
// }
// int number; // 0, если есть символы ИЛИ само число
// if (int.TryParse(text, out number)) // true, строка состоит только из цифр
// {
// // 42: 2 + 4 = 6
// ...
// int sum = 0;
// if (sum % 2 == 0)
// {
// break;
// }
// }

// }
// // // тип_метода ИмяМетода (пар1, пар2, ... парN)
// // // a, b - 2 числа, sign - знак арифм. операции
// // int Calculate(int a, int b, string sign)
// // {
// //     if (sign == "+")
// //     {
// //         return a + b; // Cумма чисел
// //     }
// //     else if (sign == "-")
// //     {
// //         return a - b; // Разность чисел
// //     }
// //     else if (sign == "*")
// //     {
// //         return a * b; // Произ-е чисел
// //     }
// //     else
// //     {
// //         Console.WriteLine("Введен неизвестный знак арифм. операции");
// //         return 0;
// //     }
// // }

// // // Вызов метода 
// // Console.WriteLine(Calculate(2, 2, "+")); // 5
// // Console.WriteLine(Calculate(2, 2, "-")); // 0
// // Console.WriteLine(Calculate(20, 3, "*")); // 60
// // Console.WriteLine(Calculate(20, 3, ".")); // 60


// // Задайте массив из N случайных целых чисел (N вводится с
// // клавиатуры).
// // Найдите количество чисел, которые оканчиваются на 1 и
// // делятся нацело на 7.
// // Пример
// // [1 5 11 21 81 4 0 91 2 3]
// // => 2
// // int[] CreateArray(int size)
// // {
// //     int[] array = new int[size]; // Массив на size элементов
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         array[i] = new Random().Next(1, 101);
// //         // [1, 101) или [1,100]
// //     }
// //     return array;
// // }

// // int GetCount(int[] arr)
// // {
// //     int count = 0; 
// //     for (int i = 0; i < arr.Length; i++)
// //     {
// //         // "&&" - "И": апельсины И яблоки
// //         if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
// //         {
// //             count++; // count = count + 1
// //             // Число нашли
// //         }
// //     }
// //     return count;
// // }


// // // Вызов метода
// // Console.Write("Введите число: ");
// // int N = Convert.ToInt32(Console.ReadLine());
// // int[] res = CreateArray(N); // Создали массив на N элементов
// // Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
// // Console.WriteLine($"Результат: {GetCount(res)}");

// // Заполните массив на N (вводится с консоли, не более 8)
// // случайных целых чисел от 0 до 9.
// // Сформируйте целое число, которое будет состоять из цифр из
// // массива. Старший разряд числа находится на 0-м индексе,
// // младший – на последнем
// // [2, 3, 1] => 231

// int[] CreateArray(int size)
// {
//     int[] array = new int[size]; // Массив на size элементов
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(10); // [0, 9]
//     }
//     return array;
// }

// int ConvertArrayToInteger(int[] array)
// {
//     int result = 0;
//     for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
//     {
//         result = result + array[i] * (int)Math.Pow(10, j);
//         // 10 - число, j - степень
//     }
//     return result;
// }

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] res = CreateArray(N); // Создали массив на N элементов
// Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
// Console.WriteLine($"Результат: {ConvertArrayToInteger(res)}");