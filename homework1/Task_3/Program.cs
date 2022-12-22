/* Практическое задание 1.
   Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
   является ли число чётным (делится ли оно на два без остатка). */

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine("Yes!");
else Console.WriteLine("No!");