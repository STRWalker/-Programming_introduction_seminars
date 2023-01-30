/* Практическое задание 7.
   Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. */


int[,] randomArray2dGet() {
    Console.Write("Input a number of rows in 2d array: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns in 2d array: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    if (rows <= 0 || columns <= 0) {
        Console.WriteLine("Wrong input. The dimensions of 2d array cannot be less than 1.");
        return randomArray2dGet();
    }
    
    Console.Write($"Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
    if (min > max) {
        Console.WriteLine("Wrong input. The min value is greater than the max.");
        return randomArray2dGet();
    }

    int[,] random_array2d = new Int32[rows, columns];
    for (int row = 0; row < rows; row++)
        for (int col = 0; col < columns; col++)
            random_array2d[row, col] = new Random().Next(min, max + 1);

    return random_array2d;
}

void array2dPrint(int[,] array2d) {
    int rows = array2d.GetLength(0), columns = array2d.GetLength(1); 
    for (int row = 0; row < rows; row++) {
        for (int col = 0; col < columns; col++)
            Console.Write($"{array2d[row, col]}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] calculateAverageInColumnsOfArray2d(int[,] array2d) {
    int rows = array2d.GetLength(0), columns = array2d.GetLength(1);
    double[] average_values = new Double[columns];

    for (int col = 0; col < columns; col++) {

        double sum = 0;
        for (int row = 0; row < rows; row++)
            sum += array2d[row, col];
        average_values[col] = sum / rows;
    }

    return average_values;
}

int[,] array2d = randomArray2dGet();
array2dPrint(array2d);

double[] average_values = calculateAverageInColumnsOfArray2d(array2d);

Console.Write("The average values of each columns is:");
for (int i = 0; i < average_values.Length; i++) Console.Write($"  {Math.Round(average_values[i], 2)}");
Console.WriteLine();
