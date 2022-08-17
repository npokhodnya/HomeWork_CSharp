// 2. Написать программу масштабирования фигуры.

void CheckTriangle()
{
    Console.Write("Введите коэффициент масштабирования: ");
    int k = int.Parse(Console.ReadLine());
    Console.Write("Введите координаты через запятую разделяя пробелом (пример - 2,3 4,3 6,7 4,5): ");
    string parametrs = Console.ReadLine();
    int ax = int.Parse(parametrs[0].ToString());
    int ay = int.Parse(parametrs[2].ToString());
    int bx = int.Parse(parametrs[4].ToString());
    int by = int.Parse(parametrs[6].ToString());
    int cx = int.Parse(parametrs[8].ToString());
    int cy = int.Parse(parametrs[10].ToString());
    int dx = int.Parse(parametrs[12].ToString());
    int dy = int.Parse(parametrs[14].ToString());
    Console.Write($"Результат: ({ax*k}, {ay*k}) ({bx*k}, {by*k}) ({cx*k}, {cy*k}) ({dx*k}, {dy*k})");
}
Console.Clear();
CheckTriangle();
