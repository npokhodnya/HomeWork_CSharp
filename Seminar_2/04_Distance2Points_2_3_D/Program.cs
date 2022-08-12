// See https://aka.ms/new-console-template for more information

double CheckDistance2D()
{
    Console.Write("Введите x1: ");
    double x1 = double.Parse(Console.ReadLine());
    Console.Write("Введите x2: ");
    double x2 = double.Parse(Console.ReadLine());
    Console.Write("Введите y1: ");
    double y1 = double.Parse(Console.ReadLine());
    Console.Write("Введите y2: ");
    double y2 = double.Parse(Console.ReadLine());
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}
double CheckDistance3D()
{
    Console.Write("Введите x1: ");
    double x1 = double.Parse(Console.ReadLine());
    Console.Write("Введите x2: ");
    double x2 = double.Parse(Console.ReadLine());
    Console.Write("Введите y1: ");
    double y1 = double.Parse(Console.ReadLine());
    Console.Write("Введите y2: ");
    double y2 = double.Parse(Console.ReadLine());
    Console.Write("Введите z1: ");
    double z1 = double.Parse(Console.ReadLine());
    Console.Write("Введите z2: ");
    double z2 = double.Parse(Console.ReadLine());
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}
Console.Clear();
while (true)
{
    Console.WriteLine("1. Расстояние между двумя точками на плоскости (2D)");
    Console.WriteLine("2. Расстояние между двумя точками в пространстве (3D)");
    Console.Write("Введите режим работы: ");
    int mode = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (mode == 1)
    {
        Console.WriteLine($"Расстояние между двумя точками на плоскости равно {CheckDistance2D()}!");
        break;
    }
    else if (mode == 2) 
    {
        Console.WriteLine($"Расстояние между двумя точками в пространстве равно {CheckDistance3D()}!");
        break;
    }
    else Console.WriteLine($"Вы не выбрали режим!");
}