/* Практическое задание 1.
   Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. */

Console.Write("Input the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double max = 0;
double min = 0;
if (num1 > num2) {
   max = num1;
   min = num2;
} else {
   max = num2;
   min = num1;
}

Console.WriteLine($"max = {max}\nmin = {min}");