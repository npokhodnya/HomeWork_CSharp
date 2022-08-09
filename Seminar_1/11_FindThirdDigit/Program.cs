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
    Console.WriteLine($"Третья цифра (с начала) в числе {oldN} - это цифра {digit}!");
    Console.WriteLine($"Третья цифра (с конца) в числе {oldN} - это цифра {(oldN%1000-oldN%100)/100}!");
}
else
{
    Console.WriteLine($"В числе нет третьей цифры!");
}

Console.WriteLine();