/*  Практическое задание 9.
    Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. */

int[] inputNumbersGet() {
    int[] input_numbers = new int[2];
    Console.Write("Input the first number: ");
    input_numbers[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the second number: ");
    input_numbers[1] = Convert.ToInt32(Console.ReadLine());

    return input_numbers;
}

int calculateSumFromTo(int first_num, int second_num) {
    if (first_num < second_num) return first_num + calculateSumFromTo(first_num + 1, second_num);
    else if (first_num > second_num) return first_num + calculateSumFromTo(first_num - 1, second_num);
    else return first_num;
}

int[] input_numbers = inputNumbersGet();
int answer = calculateSumFromTo(input_numbers[0], input_numbers[1]);

Console.WriteLine($"The sum of numbers from {input_numbers[0]} to {input_numbers[1]} is {answer}");
