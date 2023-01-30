/* Практическое задание 7.
   Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
   и возвращает значение этого элемента или же указание, что такого элемента нет. */

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

int[] inputPositionGet() {
    int[] input_position = new int[2];
    Console.Write("Input a row position of element in 2d array (starts from 1): ");
    input_position[0] = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Input a column position of element in 2d array (starts from 1): ");
    input_position[1] = Convert.ToInt32(Console.ReadLine()) - 1;

    return input_position;
}

double[] findElementInArray2d(double[,] array2d, int[] position) {
    double[] answer = new Double[2];
    if ((array2d.GetLength(0) < position[0] + 1) || (array2d.GetLength(1) < position[1] + 1) || (position[0] < 0) || (position[1] < 0)) {
        answer[0] = -1;
        return answer;
    } else {
        answer[0] = 1;
        answer[1] = array2d[position[0], position[1]];
        return answer;
    }
}

double[,] array2d = randomArray2dDoubleGet();
array2dPrint(array2d);

int[] input_position = inputPositionGet();
double[] answer = findElementInArray2d(array2d, input_position);

if (answer[0] == -1) Console.WriteLine("There is no element in the array with that position.");
else Console.WriteLine($"The value of the element at this position is {Math.Round(answer[1], 2)}");