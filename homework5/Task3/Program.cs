/* Практическое задание 5.
   Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива. */

double[] randomDoubleArrayGet() {
    Console.Write("Input a length of the array: ");
    int length = Convert.ToInt32(Console.ReadLine());
    if (length < 0) {
        Console.WriteLine("Wrong input. The length can't be less than 0.");
        return randomDoubleArrayGet();
    }
    if (length == 0) return new double[0];

    Console.Write($"Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
    if (min > max) {
        Console.WriteLine("Wrong input. The min value is greater than the max.");
        return randomDoubleArrayGet();
    }

    double[] random_array = new double[length];
    for (int i = 0; i < length; i++) {
        random_array[i] = new Random().Next(min, max) + Math.Round(new Random().NextDouble(), 2);
    }

    return random_array;
}

void arrayPrint(double[] array) {
    Console.Write("[");

    if (array.Length != 0) Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++) {
        Console.Write($" {array[i]}");
    }

    Console.WriteLine("]");
}

double calculateMinMaxDiff(double[] array) {
    if (array.Length <= 1) return 0;

    double min = array[0], max = array[0];
    for (int i = 1; i < array.Length; i++) {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }

    return max - min;
}

double[] input_array = randomDoubleArrayGet();
arrayPrint(input_array);
double answer = calculateMinMaxDiff(input_array);
Console.WriteLine($"The difference between the maximum and minimum elements is {answer}");
