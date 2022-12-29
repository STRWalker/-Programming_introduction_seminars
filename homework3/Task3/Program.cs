/* Практическое задание 3.
   Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. */

int numberGet() {
   Console.Write("Input a number: ");
   int number = Convert.ToInt32(Console.ReadLine());
   if (number <= 0) return numberGet();
   return number;
}

string calculateCubes(int input_number) {
    string cubes = "1";
    int current_number = 2;
    double cube = -1;
    while (current_number <= input_number) {
        cube = Math.Pow(current_number, 3);
        cubes = cubes + ", " + Convert.ToString(cube);
        current_number++;
    }
    return cubes;
}

int number = numberGet();
string answer = calculateCubes(number);
Console.WriteLine($"Cubes are {answer}");
