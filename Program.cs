﻿// Напишите программу, которая на вход 
// принимает два целых числа и проверяет, 
// является ли первое число квадратом второго.
// a = 25, b = 5 => да 
// a = 2, b = 10 => нет 
// a = 9, b = -3 => да 
// a = -3, b = 9 => нет

// Console.WriteLine("Введите первое число: ");
// // string num1str = Console.ReadLine();
// int num1 = Convert.ToInt32(Console.ReadLine()); // конвертировали тип "string" в 32-битное число, переменная int занимает в памяти 32 бита(4байта, в каждом байте 8бит=32бита)(диапозон типа данных int 2^32)

// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2 * num2)
// {
//     Console.WriteLine("Первое число является квадратом втрого числа");
// }
// else
// {
//     Console.WriteLine("Первое число не является квадратом второго");
// }
//---------------------------------------------------------//
// Напишите программу, которая на вход принимает 
// целое число N, а на выходе показывает все целые 
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

Console.WriteLine("Введите целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0) // Провека на положительность чиисла (число > 0)
{
    int count = -n; // Счетчик

    while (count <= n)
    {
        Console.Write(count + " "); // Write выведет все в одну строку, а WriteLine выведет все в один ряд(т.е. после каждого вывода будет переходить на новую строку)
        count = count + 1;
    }
}
else
{
    Console.WriteLine("Введено некорректное число. Читай внимательней условие задачи!");
}
//----------------------------------------------------------//
// Напишите программу, которая принимает на вход 
// трёхзначное целое число и на выходе показывает сумму 
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num >= 100 && num <= 999) || (num >= -999 && num <= -100)) // && - "и", || - "или"(проверка на трехзначность числа (диапазон))
{
    int firstDigit = num / 100; // Первое целое число
    int lastDigit = num % 10; // %10 - остаток от деления на 10(получаем третье число)
    int sum = firstDigit + lastDigit;
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Некорректное число!");
}