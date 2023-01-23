/* Практическое задание 5.
   Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
   Напишите программу, которая покажет количество чётных чисел в массиве. */

int[] randomArrayGet() {
    Console.Write("Input a length of the array: ");
    int length = Convert.ToInt32(Console.ReadLine());
    if (length < 0) {
        Console.WriteLine("Wrong input. The length can't be less than 0.");
        return randomArrayGet();
    };

    int[] random_array = new int[length];
    int min = 100, max = 999;
    for (int i = 0; i < length; i++) {
        random_array[i] = new Random().Next(min, max + 1);
    }

    return random_array;
}

void arrayPrint(int[] array) {
    Console.Write("[");

    if (array.Length != 0) Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++) {
        Console.Write($", {array[i]}");
    }

    Console.WriteLine("]");
}

int countingEvenNumbers(int[] array) {
    int even_count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) even_count++;
    }

    return even_count;
}

int[] input_array = randomArrayGet();
arrayPrint(input_array);
int answer = countingEvenNumbers(input_array);
Console.WriteLine($"The count of even numbers is {answer}");
