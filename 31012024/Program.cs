﻿// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// тип_данных[] имяМассива = 
// int[] array = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
// int numberForSearch = 100;
// bool isFound = false; // Число не найдено
// // точка старта; условие; увеличение счетчика
// for (int i = 0; i < array.Length; i++) // array.Length ищет кол-во эл
// {
//     if (numberForSearch == array[i])
//     {
//         isFound = true; // Ура, число найдено :)
//         break; // Ломает цикл
//     }
// }
// if (isFound) // isFound == true
// {
//     Console.WriteLine("Да");
// }
// else // isFound == false
// {
//     Console.WriteLine("Нет");
// }


// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// int[] array = { -1, -2, -3, -4, -5, 0, 1, 2, 3, 4 };
// Console.WriteLine($"Массив ДО: [ {string.Join("; ", array)} ]");
// for (int i = 0; i < array.Length; i++)
// {
//    array[i] *= -1; // array[i] = array[i] * -1;
//    // a = a + 40 (a += 40), b = b - 150 (b -= 150)
// }
// Console.WriteLine($"Массив ПОСЛЕ: [ {string.Join("; ", array)} ]"); //Int32[]);

// int[] array = { 10, 2, 3, 4, 5, 7, 8, 11, 9 }; // 9
// int[] result = new int[array.Length / 2]; // 9 / 2 = 4
// for (int i = 0, j = array.Length - 1; i < result.Length; i++, j--)
// // i - индекс первого элемента , i = 0
// // j - индекс последнего элемента, j = array.Length - 1 (8)
// {
//     result[i] = array[i] * array[j];
// }
// Console.WriteLine($"Результат: [ {string.Join("; ", result)} ]"); 