/* Практическое задание 1.
   Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. */

Console.Write("Input the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the third number: ");
double num3 = Convert.ToDouble(Console.ReadLine());

double max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine($"max = {max}");