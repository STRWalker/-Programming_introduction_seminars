/* Практическое задание 6.
   Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
   значения b1, k1, b2 и k2 задаются пользователем. */

double[] inputGet() {
    double[] input_coefficients = new double[4];
    Console.Write("Input a b1 value of the first line: ");
    input_coefficients[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input a k1 value of the first line: ");
    input_coefficients[1] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input a b2 value of the second line: ");
    input_coefficients[2] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input a k2 value of the second line: ");
    input_coefficients[3] = Convert.ToDouble(Console.ReadLine());

    return input_coefficients;
}

byte typeOfIntersection(double[] coeff) {
    double b1 = coeff[0], k1 = coeff[1],
           b2 = coeff[2], k2 = coeff[3];
    
    if ((b1 == b2) && (k1 == k2)) return 0;
    if (k1 == k2) return 1;
    return 2;
}

double[] calculateIntersection(double[] coeff) {
    double b1 = coeff[0], k1 = coeff[1],
           b2 = coeff[2], k2 = coeff[3];
    
    double[] intersection_point = new double[2];
    intersection_point[0] = (b1-b2) / (k2-k1);
    intersection_point[1] = intersection_point[0] * k1 + b1;

    return intersection_point;
}

double[] input_coefficients = inputGet();
byte type_intersection = typeOfIntersection(input_coefficients);

if (type_intersection == 0) Console.WriteLine("The lines have an infinite number of points of intersection");
else if (type_intersection == 1) Console.WriteLine("The lines have no intersection points");
else {

    double[] intersection_point = calculateIntersection(input_coefficients);
    Console.WriteLine($"The point of intersection of two lines is (x = {Math.Round(intersection_point[0], 2)}; y = {Math.Round(intersection_point[1], 2)})");
}
