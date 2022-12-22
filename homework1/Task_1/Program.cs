/* Практическое задание 1.
   Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. */

Console.Write("Input the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2) Console.WriteLine($"max = {num1}\nmin = {num2}");
else Console.WriteLine($"max = {num2}\nmin = {num1}");