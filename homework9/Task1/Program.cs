/*  Практическое задание 9.
    Задача 64: Задайте значение N. Напишите программу, которая выведет
    все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    (Переделка из Задайте значения M и N. Напишите программу, которая выведет
    все натуральные числа в промежутке от M до N.) */

/*
int[] inputNumbersGet() {
    int[] input_numbers = new int[2];
    Console.Write("Input the first number: ");
    input_numbers[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the second number: ");
    input_numbers[1] = Convert.ToInt32(Console.ReadLine());

    return input_numbers;
}

void showNumbers(int first_num, int second_num) {
    Console.Write($"{first_num} ");
    if (first_num < second_num) showNumbers(first_num + 1, second_num);
    if (first_num > second_num) showNumbers(first_num - 1, second_num);
}

int[] input_numbers = inputNumbersGet();

showNumbers(input_numbers[0], input_numbers[1]);
Console.WriteLine();
*/

int inputNumbersGet() {
    Console.Write("Input the number: ");
    int input_number = Convert.ToInt32(Console.ReadLine());
    if (input_number < 1) {
        Console.WriteLine("Wrong input. The number cannot be less than 1.");
        return inputNumbersGet();
    }

    return input_number;
}

void showNumbers(int number) {
    Console.Write($"{number} ");
    if (number != 1) showNumbers(number - 1);
}

int input_number = inputNumbersGet();

showNumbers(input_number);
Console.WriteLine();
