/* Практическое задание 2.
   Задача 13: Напишите программу, которая выводит третью цифру
   заданного числа или сообщает, что третьей цифры нет. */

int numberGet() {
   Console.Write("Input a number: ");
   return Convert.ToInt32(Console.ReadLine());
}

int thirdDigit(int number) {
   if (number < 0) number = -number;

   int third_digit = -1;
   while (number >= 1000) number /= 10;
   if (number >= 100) third_digit = number % 10;

   return third_digit;
}

void answerOut(int answer) {
   if (answer == -1) Console.WriteLine("There isn't third digit");
   else Console.WriteLine($"Third digit = {answer}");
}

int number = numberGet();
int third_digit = thirdDigit(number);
answerOut(third_digit);