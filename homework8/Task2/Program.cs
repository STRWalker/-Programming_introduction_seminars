/*  Практическое задание 8.
    Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

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

int findRowWithMinSum(int[,] array2d) {
    int rows = array2d.GetLength(0), columns = array2d.GetLength(1);
    int min_sum = 0, min_row = 0;
    for (int col = 0; col < columns; col++)
        min_sum += array2d[0, col];

    for (int row = 1; row < rows; row++) {
        int sum = 0;
        for (int col = 0; col < columns; col++)
            sum += array2d[row, col];
        if (sum < min_sum) {
            min_sum = sum;
            min_row = row;
        }
    }

    return min_row;
}

int[,] array2d = randomArray2dGet();
array2dPrint(array2d);

int answer = findRowWithMinSum(array2d);
Console.WriteLine($"The row with the smallest sum of elements is {answer + 1} (starts from 1)");
