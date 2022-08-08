// 4. Выяснить является ли число чётным.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.Write($"Число {number} - ЧЁТНОЕ!");
}
else
{
    Console.Write($"Число {number} - НЕЧЁТНОЕ!");
}
