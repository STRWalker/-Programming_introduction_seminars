/* Семинар 2.
   Задача 2: Напишите программу, которая выводит случайное число
   из отрезка [10, 99] и показывает наибольшую цифру числа. */

int numberGet() {
    return new Random().Next(10, 100);
}

int findMaxFigure(int number) {
    if (number < 0) number = -number;

    int max_figure = -1;
    while (number != 0) {
        int current_figure = number % 10;
        if (current_figure > max_figure) max_figure = current_figure;
        number = number / 10;
    }

    return max_figure;
}

int number = numberGet();
Console.WriteLine($"number = {number}");
int figure = findMaxFigure(number);
Console.WriteLine($"max figure = {figure}");
