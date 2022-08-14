// 2. Задать номер четверти, показать диапазоны для возможных координат.

void CheckPlane(int plane)
{
    Random rand = new Random();
    if (plane == 1) Console.Write($"Для {plane} четверти характерен диапозон координат (x>0; y>0), например ({rand.Next(1, 10)}; {rand.Next(1, 10)})");
    else if (plane == 2) Console.Write($"Для {plane} четверти характерен диапозон координат (x<0; y>0), например ({rand.Next(-10, 0)}; {rand.Next(1, 10)})");
    else if (plane == 3) Console.Write($"Для {plane} четверти характерен диапозон координат (x<0; y<0), например ({rand.Next(-10, 0)}; {rand.Next(-10, 0)})");
    else if (plane == 4) Console.Write($"Для {plane} четверти характерен диапозон координат (x>0; y<0), например ({rand.Next(1, 10)}; {rand.Next(-10, 0)})");
    else Console.Write($"Число {plane} не является номером четверти!");
}
Console.Clear();
Console.Write("Введите номер четверти: ");
int plane = int.Parse(Console.ReadLine());
CheckPlane(plane);