/* Практическое задание 4.
   Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. */

int[] numbersGet() {
    Console.Write("Input a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a power of the number: ");
    int power = Convert.ToInt32(Console.ReadLine());

    return new int[] {number, power};
}

int pow(int number, int power) {
    int result = 1;
    for (int i = 1; i <= power; i++) {
        result *= number;
    }

    return result;
}

int[] inputValues = numbersGet();
int answer = pow(number: inputValues[0], power: inputValues[1]);
Console.WriteLine($"Answer is {answer}");
