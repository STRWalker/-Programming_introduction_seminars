/* Практическое задание 4.
   Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран. */

int[] arrayGet() {
    Console.Write("Input a length of the array: ");
    int length = Convert.ToInt32(Console.ReadLine());
    if (length < 0) return arrayGet();

    int[] input_array = new int[length];
    for (int i = 0; i < length; i++) {
        Console.Write($"Input {i+1} value of the array: ");
        input_array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return input_array;
}

void arrayPrint(int[] array) {
    Console.Write("[");

    if (array.Length != 0) Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++) {
        Console.Write($", {array[i]}");
    }

    Console.WriteLine("]");
}

int[] input_array = arrayGet();
arrayPrint(input_array);
