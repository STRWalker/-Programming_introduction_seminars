/* Практическое задание 4.
   Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. */

int numberGet() {
    Console.Write("Input a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 0) number = -number;

    return number;
}

int findSum(int number) {
    int sum = 0;
    while (number > 0) {
        sum += number % 10;
        number = number / 10;
    }

    return sum;
}

int number = numberGet();
int answer = findSum(number);
Console.WriteLine($"The sum of digits of the number is {answer}");
