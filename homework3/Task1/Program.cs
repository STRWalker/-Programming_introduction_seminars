/* Практическое задание 3.
   Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. */

Tuple<int, int> numberGet() {
    Console.Write("Input a number: ");
    string input = Console.ReadLine();

    int number = Convert.ToInt32(input);
    int size = 0;
    if (number < 0) {
        number = -number;
        size = input.Length - 1;
    } else size = input.Length;
    
    //Console.WriteLine($"(debug) number = {number}, size = {size}");
    return Tuple.Create(number, size);
}

bool isPalindrome(int number, int size) {
    int left = -1, right = -1;
    while (number > 1) {
        left = number / Convert.ToInt32(Math.Pow(10, size - 1));
        right = number % 10;
        //Console.WriteLine($"(debug) palindrome_number = {number}, size = {size}, left = {left}, right = {right}");
        if (left != right) return false;
        number = number % Convert.ToInt32(Math.Pow(10, size - 1));
        number = number / 10;
        size -= 2;
    }
    return true;
}

void answerOut(bool answer) {
    if (answer) Console.WriteLine("Yes!");
    else Console.WriteLine("No...");
}

Tuple<int, int> input_tuple = numberGet();
int number = input_tuple.Item1, size = input_tuple.Item2;
bool is_palindrome = isPalindrome(number, size);
answerOut(is_palindrome);
