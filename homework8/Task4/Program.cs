/*  Практическое задание 8.
    Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
    Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */


int[,,] randomUniqueArray3dGet() {
    Console.Write("Input a number of layers in 3d array: ");
    int layers = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of rows in 3d array: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns in 3d array: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    if (layers <= 0 || rows <= 0 || columns <= 0) {
        Console.WriteLine("Wrong input. The dimensions of 3d array cannot be less than 1.");
        return randomUniqueArray3dGet();
    }
    
    Console.Write($"Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
    if (min > max) {
        Console.WriteLine("Wrong input. The min value is greater than the max.");
        return randomUniqueArray3dGet();
    }
    if (max-min+1 < layers*rows*columns) {
        Console.WriteLine("Wrong input. It is not possible to create a 3d array of unique values.");
        return randomUniqueArray3dGet();
    }

    int[,,] random_array3d = new Int32[layers, rows, columns];
    bool[] unavailable_values = new bool[max - min + 1];
    for (int layer = 0; layer < layers; layer++)
        for (int row = 0; row < rows; row++)
            for (int col = 0; col < columns; col++) {

                do random_array3d[layer, row, col] = new Random().Next(min, max + 1);
                while (unavailable_values[ random_array3d[layer, row, col] - min ]);
                unavailable_values[random_array3d[layer, row, col] - min] = true;
            }
    /*
    Console.Write($"(debug) unavailable_values:");
    for (int i = 0; i < unavailable_values.Length; i++)
        if (unavailable_values[i]) Console.Write($" {i + min}");
    Console.WriteLine();
    */
    return random_array3d;
}

void array3dPrint(int[,,] array3d) {
    int layers = array3d.GetLength(0), rows = array3d.GetLength(1), columns = array3d.GetLength(2);

    for (int layer = 0; layer < layers; layer++) {

        Console.WriteLine($"Layer {layer + 1} of {layers}:");
        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < columns; col++)
                Console.Write($"{array3d[layer, row, col]} ({layer},{row},{col})\t");
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int[,,] unique_array3d = randomUniqueArray3dGet();
array3dPrint(unique_array3d);
