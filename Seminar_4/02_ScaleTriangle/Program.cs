// 2. Написать программу масштабирования фигуры.

void CheckTriangle()
{
    Console.Write("Введите коэффициент масштабирования: ");
    double k = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты вершин (x, y), пример - (0, 0) (2.55, 0) (2.123, 2) (0, 2).");
    Console.WriteLine();
    Console.Write("Вводите: ");
    string[] parametrs = Console.ReadLine().Split(new string[] { " ", '('.ToString(), ')'.ToString(), ","}, StringSplitOptions.RemoveEmptyEntries);
    Console.WriteLine();
    Console.Write($"Результат: ");
    for (int i = 0; i < parametrs.Length; i+=2)
    {
        Console.Write($"({double.Parse(parametrs[i]) * k}, {double.Parse(parametrs[i+1]) * k}) ");
    }
}
Console.Clear();
CheckTriangle();
