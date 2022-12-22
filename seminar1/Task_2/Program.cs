/* Семинар 1.
   Задача 2. Напишите программу, которая на вход принимает одно число (N),
   а на выходе показывает все целые числа в промежутке от -N до N. */

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;

int current = -number;
while (current <= number) {
    Console.Write(current + " ");
    current++;
}