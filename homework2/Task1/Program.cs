/* Практическое задание 2.
   Задача 10: Напишите программу, которая принимает на вход трёхзначное число
   и на выходе показывает вторую цифру этого числа. */

int numberGet() {
   Console.Write("Input a three-digit number: ");
   int number = Convert.ToInt32(Console.ReadLine());

   if (number < 0) number = -number;
   if (number/100 == 0 || number/1000 != 0) return numberGet();

   //Console.WriteLine($"(debug) number = {number}");
   return number;
}

int secondDigit(int number) {
   return number/10 %10;
}

int number = numberGet();
int second_digit = secondDigit(number);
Console.WriteLine($"Second digit = {second_digit}");
