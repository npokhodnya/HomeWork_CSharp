// 7. Показать вторую цифру трёхзначного числа.

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if(n > 99 && n < 1000)
{
    int secondDigit = (n%100-n%10)/10;
    Console.WriteLine($"Вторая цифра в числе {n} - это {secondDigit}!");
}
else
{
    Console.WriteLine($"Число должно быть трех-значным! (по условию задачи)");
}
