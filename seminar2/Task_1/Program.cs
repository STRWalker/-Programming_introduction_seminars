/* Семинар 2.
   Задача 1: Напишите программу, которая выводит случайное
   трёхзначное число и удаляет вторую цифру этого числа. */

int numberGet() {
    return new Random().Next(100, 1000);
}

int numberCut(int number) {
    int sot = number / 100;
    int ed = number % 10;

    int result = sot*10 + ed;
    return result;
}

int number = numberGet();
Console.WriteLine($"number = {number}");
int result = numberCut(number);
Console.WriteLine($"result = {result}");
