/* Практическое задание 1.
   Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. */

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 2;
while (current <= number) {
   Console.Write(current + " ");
   current += 2;
}