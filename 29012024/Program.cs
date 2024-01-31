﻿// Домашняя работа

// Задача 1
{
    Console.WriteLine("Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.");
}
int numberHW1 = 75;
int first = 7;
int second = 23;

if (numberHW1 % first == 0 && numberHW1 % second == 0)
{
    Console.WriteLine("Число" + " " + numberHW1 + " " + "кратно" + " " + first + " " + "и" + " " + second);
    Console.WriteLine($"Число {numberHW1} кратно {first} и {second}"); 
}
else
{
    Console.WriteLine($"Число {numberHW1} НЕ кратно {first} и {second}"); 
}
{
    Console.WriteLine("");
}
// Задача 2

{
    Console.WriteLine("Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.");
}
int xCoordinate = 1;
int yCoordinate = -2;
if (xCoordinate >= 1 && yCoordinate >= 1)
{
    Console.WriteLine($"X={xCoordinate} и Y={yCoordinate} находятся в 1 координатной четверти");
}
else if (xCoordinate <= -1 && yCoordinate >= 1)
{
    Console.WriteLine($"X={xCoordinate} и Y={yCoordinate} находятся во 2 координатной четверти");
}
else if (xCoordinate <= -1 && yCoordinate <= -1)
{
    Console.WriteLine($"X={xCoordinate} и Y={yCoordinate} находятся в 3 координатной четверти");
}
else if (xCoordinate >= 1 && yCoordinate <= -1)
{
    Console.WriteLine($"X={xCoordinate} и Y={yCoordinate} находятся в 4 координатной четверти");
}
else
{
    Console.WriteLine("X или Y не может быть 0");
}
{
    Console.WriteLine("");
}

// Задача 3
{
    Console.WriteLine("Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.");
}
int numberHW3 = 87;
int firstHW3 = numberHW3 / 10;
int secondHW3 = numberHW3 % 10;
if (firstHW3 > secondHW3)
{
    Console.WriteLine($"В числе {numberHW3} наибольшая цифра {firstHW3}");
}
else
{
    Console.WriteLine($"В числе {numberHW3} наибольшая цифра {secondHW3}");
    //$"Текст {result} текст {a+100} текст {a - 500}"
}
{
    Console.WriteLine("");
}

// Задача 4
{
    Console.WriteLine("Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.");
}
int numberHW4 = 6197;
int resualtHW4 = numberHW4;
{
    Console.WriteLine($"Натуральное число {numberHW4} состоит из цифр:");
}
 while (numberHW4 > 0)
{
resualtHW4 = numberHW4 % 10; //- получаешь самую правую цифру числа
Console.Write(resualtHW4 + ",");
numberHW4 = numberHW4 / 10; // удаляешь самую правую цифру из числа num.
//Console.WriteLine(numberHW4);
}



//$"Текст {result} текст {a+100} текст {a - 500}"



// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// int number = 947;
// int firstDigit = number / 100; // 453 / 100 = 4
// int thirdDigit = number % 10; // 453 % 10 = 3
// int result = firstDigit * 10 + thirdDigit; // 4 * 10 + 3 = 43
// // $"Текст {result} текст {a+100} текст {a - 500}"
// Console.WriteLine($"В числе {number} => {result}");

// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1
// int number = 925;
// int seсondDigit = number / 10 % 10; // 947 / 10 % 10 = 94 % 10 = 4 
// int thirdDigit = number % 10; // 947 % 10 = 7
// // Math.Pow(5, 2) => 5^2 = 5*5=25
// int result = (int)Math.Pow(seсondDigit, thirdDigit);
// // Результат переводится в (int)
// Console.WriteLine($"{seсondDigit} ^ {thirdDigit} = {result}");
// 4 ^ 7 = 16384

// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

// int number = 12345678;
// if (number >= 100) // Число минимум трехзначное
// // От 100 до + бесконечности  
// {
//     int thirdDigitFromEnd = (number / 100) % 10;
//     Console.WriteLine($"Третья цифра от {number} с конца: {thirdDigitFromEnd}");
// }
// else // В числе нет 3 цифры
// {
//     Console.WriteLine("Третьей цифры нет");
// }