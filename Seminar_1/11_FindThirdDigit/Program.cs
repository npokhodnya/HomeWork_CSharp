// 11. Найти третью цифру числа или сообщить, что её нет.

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int oldN = n;

Console.WriteLine();
if(n > 99)
{
    while (n > 1000)
    {
        n/=10;
    }
    int digit = (n%10);
    Console.WriteLine($"Третья цифра в числе {oldN} - это цифра {digit}!");
}
else
{
    Console.WriteLine($"В числе нет второй цифры!");
}

Console.WriteLine();