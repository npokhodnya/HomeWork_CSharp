// 1. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.

string CheckPoint(int k1, int k2, int b1, int b2)
{
    if(k1 == k2) return "Данные прямы не имеют общих точек или имеют бесконечное количество общих точек!";
    else return $"({(b2 - b1) / (k1 - k2)}, {(k1 * (b2 - b1) / (k1 - k2)) + b1})";
}
Console.Clear();
Console.Write("Введите k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = int.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.Write($"Результат: {CheckPoint(k1, k2, b1, b2)}");
