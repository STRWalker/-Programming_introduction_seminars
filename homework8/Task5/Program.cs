/*  Практическое задание 8.
    Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4. */

int[,] spiralArray2dGet() {
    Console.Write("Input a number of rows in 2d array: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns in 2d array: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    if (rows <= 0 || columns <= 0) {
        Console.WriteLine("Wrong input. The dimensions of 2d array cannot be less than 1.");
        return spiralArray2dGet();
    }

    int[,] spiral_array2d = new Int32[rows, columns];
    int value = 1, iter = 0;
    do {
        // current box
        int min_row = iter, max_row = rows-1 - iter,
            min_col = iter, max_col = columns-1 - iter;

        // right move
        for (int col = min_col; col <= max_col; col++) {
            spiral_array2d[min_row, col] = value;
            value++;
        }

        // down move
        if (value <= rows * columns)
            for (int row = min_row + 1; row <= max_row; row++) {
                spiral_array2d[row, max_col] = value;
                value++;
            }

        // left move
        if (value <= rows * columns)
            for (int col = max_col - 1; col >= min_col; col--) {
                spiral_array2d[max_row, col] = value;
                value++;
            }
            
        // up move
        if (value <= rows * columns)
            for (int row = max_row - 1; row >= min_row + 1; row--) {
                spiral_array2d[row, min_col] = value;
                value++;
            }
        iter++;
    } while (value <= rows * columns);

    return spiral_array2d;
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

int[,] array2d = spiralArray2dGet();
Console.WriteLine("Spiral filled matrix:");
array2dPrint(array2d);
