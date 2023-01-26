/* Практическое задание 6.
   Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. */

Console.Write("Input a length of the array: ");
int length = Convert.ToInt32(Console.ReadLine());
if (length < 0) {
    Console.WriteLine("Wrong input. The length can't be less than 0.");
} else {

    int positive_count = 0;
    for (int i = 1; i < length+1; i++) {
        Console.Write($"Input {i} value of the array: ");
        double input_value = Convert.ToDouble(Console.ReadLine());
        if (input_value > 0) positive_count++;
    }

    Console.WriteLine($"The count of values greater than 0 is {positive_count}");
}
