/* Практическое задание 2.
   Задача 15: Напишите программу, которая принимает на вход цифру,
   обозначающую день недели, и проверяет, является ли этот день выходным. */

int numberGet() {
   Console.Write("Input a number: ");
   return Convert.ToInt32(Console.ReadLine());
}

bool isWeekend(int day) {
   if (day == 6 || day == 7) return true;
   else return false;
}

void answerOut(bool answer) {
   if (answer) Console.WriteLine("Yes, it's weekend!");
   else Console.WriteLine("Unfortunately no...");
}

int number = numberGet();
bool is_weekend = isWeekend(number);
answerOut(is_weekend);
