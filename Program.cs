﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int number2 = (number - number%10)/10;
Console.WriteLine("Вторая цифра в числе " + number + " - " + number2%10);
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
string number2 = Convert.ToString(number); //для подсчёта кол-ва цифр
if (number2.Length > 2) //если длина string больше двух
{
    Console.WriteLine("Третья цифра числа " + number + " - " + number % 10);
}
else Console.WriteLine("Третьей цифры нет.");
*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите число от 1 до 7: ");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day == 7){
    Console.WriteLine(day + "й день - выходной");
}
if (day > 7){
    Console.WriteLine("Неверная цифра.");
}
else Console.WriteLine(day + " - будний");
