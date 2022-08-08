// 6. Показать последнюю цифру трёхзначного числа.

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if(n > 99)
{
    int lastDigit = n%10;
    Console.WriteLine($"Последняя цифра в числе {n} - это {lastDigit}!");
}
else
{
    Console.WriteLine($"Число должно быть трех-значным! (по условию задачи)");
}
