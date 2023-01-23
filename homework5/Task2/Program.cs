/* Практическое задание 5.
   Задача 36: Задайте одномерный массив, заполненный случайными числами.
   Найдите сумму элементов, стоящих на нечётных позициях. */

int[] randomArrayGet() {
    Console.Write("Input a length of the array: ");
    int length = Convert.ToInt32(Console.ReadLine());
    if (length < 0) {
        Console.WriteLine("Wrong input. The length can't be less than 0.");
        return randomArrayGet();
    }
    if (length == 0) return new int[0];

    Console.Write($"Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
    if (min > max) {
        Console.WriteLine("Wrong input. The min value is greater than the max.");
        return randomArrayGet();
    }

    int[] random_array = new int[length];
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

int calculateSumOddPositions(int[] array) {
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) {
        sum += array[i];
    }

    return sum;
}

int[] input_array = randomArrayGet();
arrayPrint(input_array);
int answer = calculateSumOddPositions(input_array);
Console.WriteLine($"The sum of elements in odd positions is {answer}");
