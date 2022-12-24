/* Семинар 2.
   Задача 4: Напишите программу, которая принимает на вход два числа
   и проверяет, является ли одно число квадратом другого. */

bool isSquare(int number1, int number2) {
    if (number1*number1 == number2 || number2*number2 == number1) return true;
    else return false;
}

Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool is_square = isSquare(number1, number2);
Console.WriteLine(is_square);
