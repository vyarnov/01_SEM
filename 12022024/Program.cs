// // Homework
// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// Console.Clear();
// char[,] array = new char[,] { { 'P', 'R', 'I' }, { 'V', 'E', 'T' }, { 'V', 'A', 'M' } };
// string result = "";

// for (int i = 0; i < array.GetLength(0); i++) // строки
// {

//     for (int j = 0; j < array.GetLength(1); j++) // столбцы
//     {
//         result += array[i, j];
//     }

// }

// Console.Write(result);

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Console.Write("Введите строку, содержащую латинские буквы в обоих регистрах:");
// string line = Console.ReadLine();
// line = line.ToLower();
// Console.Write(line);


// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
// Console.Clear();
// Console.Write("Введите строку из латинских букв:");
// string line = Console.ReadLine();
// char[] array = line.ToCharArray();
// bool change = false;
// for (int i = 0; i < array.Length; i++)
// {

//     if (array[i] != array[(array.Length) - 1 - i])
//     {
//         Console.Write("Строка не палиндром");
//         change = false;
//         break;
//     }
//     change = true;
// }
// if (change == true)
// {
//     Console.WriteLine("Строка палиндром");
// }


// Console.Write(array[array.Length-1]);








// Console.Clear();
// int[,] array = new int[,] {
//     {1, 2, 3},
//     {1, 10, 0},
//     {7, 8, 2},
//     {9, 10, 11}
// };

// int[] SumRows(int[,] array)
// {
//     int[] arr = new int[


//     ];
//     for (int i = 0; i < array.GetLength(0); i++) // строки
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++) // столбцы
//         {
//             sum += array[i, j];
//         }
//         arr[i] = sum;
//     }
//     return arr;
// }

// int MinIndex(int[] array)
// {
//     int mindex = 0;
//     for (int i = 0; i < array.Length; i++) // строки
//         if (array[i] < array[mindex])
//         {
//             mindex = i;
//         }
//     return mindex;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) // стр
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // столбцы
//         {
//             Console.Write($"{array[i, j]}\t"); // "\t" = 4 пробела 
//         } // Закончили обход 0 строки, идем в 1
//         Console.WriteLine(); // Перенос на новую строчку
//     }
// }


// int[] ter = SumRows(array);
// // Console.WriteLine($"Массив: [ {string.Join("; ", ter)} ]");
// PrintArray(array);
// int mindx = MinIndex(ter);
// Console.WriteLine("Индекс строки массива с минимальной суммой элементов: " + mindx);





// // Задайте массив символов (тип char []). 
// // Создайте строку из символов этого массива. 

// // [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// // string GetStringFromCharArray (char[] array)
// // {
// //     // array = [‘a’, ‘b’, ‘c’, ‘d’] 
// //     string result = string.Empty; // ""
// //     foreach (char symbol in array)
// //     // symbol = 'a', symbol = 'b', symbol = 'c', symbol = 'd'
// //     {
// //         result += symbol; // result = result + symbol
// //         // result = "" + "a"; result = "a"
// //         // result = "a" +"b"; result = "ab"
// //         // result = "ab" + "c"; result = "abc"
// //         // result = "abc" + "d"; result = "abcd"
// //     }
// //     return result;
// // }
// // // '1' - char, "3rr2" - string
// // char[] chars = {'1', 'd', '!', '2', 'f'};
// // Console.WriteLine($"Массив: [{string.Join("; ", chars)}]");
// // string res = GetStringFromCharArray(chars);
// // Console.WriteLine(res);

// // На основе символов строки (тип string) сформировать массив
// // символов (тип char[]). Вывести массив на экран.

// // “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// // char[] ConvertStringToCharArray (string str)
// // {
// //     char[] chars = new char[str.Length]; 
// //     // "hi" => [,], str.Length = 2, массив на 2 элемента
// //     for (int i = 0; i < str.Length; i++)
// //     {
// //         chars[i] = str[i]; 
// //         //chars[0] = str[0], chars[0]=h
// //         //chars[1] = str[1], chars[1]=i
// //         // chars = ['h', 'i']
// //     }
// //     return chars;
// //     // str = "hi" => [h,i]
// //     // "hi" => [str[0], str[1]]
// // }
// // // “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]
// // string str = "Hello world";
// // Console.WriteLine($"Строчка исходная: {str}");
// // char[] chars = ConvertStringToCharArray(str);
// // Console.WriteLine($"Массив: [{string.Join("; ", chars)}]");

// // Считать строку с консоли, состоящую из латинских
// // букв в нижнем регистре. Выяснить, сколько среди
// // введённых букв гласных.
// // Пример
// // “hello” => 2
// // “world” => 1

// int GetVovelsCount (string str)
// {
//     // str = "hello", 'h' - 1 символ, char
//     string vovels = "aoueyi"; // Гласные буквы в англ. алфавите
//     int vovelsCount = 0; // Количество гласных 
//     foreach (char symbol in str) // Получает каждый символ введенной строчки
//     {
//         // 'a' == a, o, u, e, y, i
//         foreach (char vovel in vovels) // Получаем гласные
//         {
//             if (symbol == vovel) // Нашли гласную букву
//             {
//                 vovelsCount++; // vovelsCount = vovelsCount + 1
//                 break; // Если нашли гласную, переходим к след.букве
//             }
//         }
//     }
//     return vovelsCount;
// }


// Console.Write("Введите строчку: ");
// string inputString = Console.ReadLine();
// inputString = inputString.ToLower(); // нижний регистр, "HI" -> "hi"
// // ToUpper() - верхний ("hi" => "HI")
// Console.WriteLine($"В строчке: {inputString} в нижн. регистре : {GetVovelsCount(inputString)} гласных");