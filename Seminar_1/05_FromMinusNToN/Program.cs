// 5. Показать числа от -N до N.

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int minusN = -n;
Console.WriteLine($"Все числа от {minusN} до {n} (включительно!):");
while (minusN != n+1)
{
    if(minusN == n)
    {
        Console.Write($"{minusN}!");
    }
    else
    {
    Console.Write($"{minusN}, ");
    }
    minusN++;
}
