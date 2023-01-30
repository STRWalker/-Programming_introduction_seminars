/* Практическое задание 7.
   Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. */

double[,] randomArray2dDoubleGet() {
    Console.Write("Input a number of rows in 2d array: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns in 2d array: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    if (rows <= 0 || columns <= 0) {
        Console.WriteLine("Wrong input. The dimensions of 2d array cannot be less than 1.");
        return randomArray2dDoubleGet();
    }
    
    Console.Write($"Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
    if (min > max) {
        Console.WriteLine("Wrong input. The min value is greater than the max.");
        return randomArray2dDoubleGet();
    }

    double[,] random_array2d = new Double[rows, columns];
    if (min == max) {
        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < columns; col++)
                random_array2d[row, col] = min;
        }
    } else {
        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < columns; col++)
                random_array2d[row, col] = new Random().Next(min, max) + new Random().NextDouble();
        }
    }

    return random_array2d;
}

void array2dPrint(double[,] array2d) {
    int rows = array2d.GetLength(0), columns = array2d.GetLength(1); 
    for (int row = 0; row < rows; row++){
        for (int col = 0; col < columns; col++)
            Console.Write($"{Math.Round(array2d[row, col], 2)}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] array2d = randomArray2dDoubleGet();
array2dPrint(array2d);
