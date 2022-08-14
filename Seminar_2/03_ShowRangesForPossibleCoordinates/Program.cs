// 3. Задать номер четверти, показать диапазоны для возможных координат.

Console.Write("Введите номер плоскости: ");
int plane = int.Parse(Console.ReadLine());
Random rand = new Random();
if (plane == 1) 
{
    int x = rand.Next(1, 10); int y = rand.Next(1, 10);
    Console.Write($"Для {plane} плоскости характерен диапозон координат (x>0; y>0), например ({x}; {y})");
}
else if (plane == 2)
{
    int x = rand.Next(-10, 0); int y = rand.Next(1, 10);
    Console.Write($"Для {plane} плоскости характерен диапозон координат (x<0; y>0), например ({x}; {y})");
}
else if (plane == 3)
{
    int x = rand.Next(-10, 0); int y = rand.Next(-10, 0);
    Console.Write($"Для {plane} плоскости характерен диапозон координат (x<0; y<0), например ({x}; {y})");
}
else if (plane == 4)
{
    int x = rand.Next(1, 10); int y = rand.Next(-10, 0);
    Console.Write($"Для {plane} плоскости характерен диапозон координат (x>0; y<0), например ({x}; {y})");
}
else Console.Write($"Число {plane} не является номером плоскости!");