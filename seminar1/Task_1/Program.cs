// Семинар 1.
// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2*num2;
if (num1 == quad2) Console.WriteLine("Yes!");
else Console.WriteLine("No!");