/*  Практическое задание 8.
    Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */

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

bool canCalculateProductOfMatrices(int[,] array2d_1, int[,] array2d_2) {
    return (array2d_1.GetLength(1) == array2d_2.GetLength(0));
}

int[,] calculateProductOfMatrices(int[,] array2d_1, int[,] array2d_2) {
    int rows_1 = array2d_1.GetLength(0), columns_1 = array2d_1.GetLength(1),
        rows_2 = array2d_2.GetLength(0), columns_2 = array2d_2.GetLength(1);
    int[,] product_of_matrices = new Int32[rows_1, columns_2];

    for (int row = 0; row < rows_1; row++) {
        for (int col = 0; col < columns_2; col++) {

            for (int elem = 0; elem < columns_1; elem++)
                product_of_matrices[row, col] += array2d_1[row, elem] * array2d_2[elem, col];
        }
    }

    return product_of_matrices;
}

Console.WriteLine("First matrix:");
int[,] first_array2d = randomArray2dGet();
array2dPrint(first_array2d);
Console.WriteLine("Second matrix:");
int[,] second_array2d = randomArray2dGet();
array2dPrint(second_array2d);

if (canCalculateProductOfMatrices(first_array2d, second_array2d)) {
    int[,] product_of_two_matrices = calculateProductOfMatrices(first_array2d, second_array2d);
    Console.WriteLine("Product of two matrices:");
    array2dPrint(product_of_two_matrices);
}
else Console.WriteLine("These matrices cannot be multiplied");
