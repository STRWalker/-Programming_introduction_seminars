/* Практическое задание 3.
   Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. */

Tuple<double, double, double, double, double, double> coordinatesGet() {
    Console.Write("Input first coordinate of the first point: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input second coordinate of the first point: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input third coordinate of the first point: ");
    double z1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Input first coordinate of the second point: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input second coordinate of the second point: ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input third coordinate of the second point: ");
    double z2 = Convert.ToDouble(Console.ReadLine());

    return Tuple.Create(x1, y1, z1, x2, y2, z2);
}

double findDistance(Tuple<double, double, double, double, double, double> coordinates) {
    double x1 = coordinates.Item1, y1 = coordinates.Item2, z1 = coordinates.Item3;
    double x2 = coordinates.Item4, y2 = coordinates.Item5, z2 = coordinates.Item6;

    double distance = Math.Sqrt( Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2) );
    return distance;
}

Tuple<double, double, double, double, double, double> input_coordinates = coordinatesGet();
double distance = findDistance(input_coordinates);
Console.WriteLine($"Distance is {Math.Round(distance, 2)}");
