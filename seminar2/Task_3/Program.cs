/* Семинар 2.
   Задача 3: Напишите программу, которая будет принимать на вход два числа
   и выводить, является ли второе число кратным первому. */

bool isMultiple(int number1, int number2) {
    if (number2 % number1 == 0) return true;
    else return false;
}

Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool is_multiple = isMultiple(number1, number2);
Console.WriteLine(is_multiple);
