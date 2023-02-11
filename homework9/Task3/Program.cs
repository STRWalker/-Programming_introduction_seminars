/*  Практическое задание 9.
    Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. */

int[] inputNumbersGet() {
    int[] input_numbers = new int[2];
    Console.Write("Input the first number: ");
    input_numbers[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the second number: ");
    input_numbers[1] = Convert.ToInt32(Console.ReadLine());
    if ( (input_numbers[0] < 0) || (input_numbers[1] < 0)) {
        Console.WriteLine("Wrong input. The numbers cannot be less than 0.");
        return inputNumbersGet();
    }

    return input_numbers;
}

double calculateAckermannFunction(double n, double m) {
    if (n == 0) return m + 1;
    else if (m == 0) return calculateAckermannFunction(n - 1, 1);
    else return calculateAckermannFunction(n - 1, calculateAckermannFunction(n, m - 1));
}

int[] input_numbers = inputNumbersGet();
double answer = calculateAckermannFunction(input_numbers[0], input_numbers[1]);

Console.WriteLine($"The Ackermann function of {input_numbers[0]} and {input_numbers[1]} is {answer}");
