// 1. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.

string CheckPoint(double k1, double k2, double b1, double b2)
{
    if((k1 == k2) && (b1 == b2)) return "Данные прямые не имеют общих точек!";
    else if(k1 == k2) return "Данные прямые имеет бесконечное количество общих точек!";
    else 
    {
        double x = (-b2 + b1)/(-k1 + k2);
        double y = k2 * x + b2;
        return $"({x}; {y})";
    }
}
Console.Clear();
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write($"Результат: {CheckPoint(k1, k2, b1, b2)}");
