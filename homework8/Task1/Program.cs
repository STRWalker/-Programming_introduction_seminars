/*  Практическое задание 8.
    Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. */

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

void sortArray2d(int[,] array2d) {
    int rows = array2d.GetLength(0), columns = array2d.GetLength(1);
    if (columns == 1) {
        //Console.WriteLine("(debug) columns == 1");
        return;
    }

    for (int row = 0; row < rows; row++) {

        for (int iter = 0; iter < columns - 1; iter++) {
            int min_val = array2d[row, 0], min_pos = 0;
            for (int col = 1; col < columns - iter; col++) {
                if (array2d[row, col] < min_val) {
                    min_val = array2d[row, col];
                    min_pos = col;
                }
            }
            array2d[row, min_pos] = array2d[row, columns - iter - 1];
            array2d[row, columns - iter - 1] = min_val;
        }
    }
}

int[,] array2d = randomArray2dGet();
array2dPrint(array2d);

sortArray2d(array2d);
Console.WriteLine("Sorted 2d array:");
array2dPrint(array2d);
