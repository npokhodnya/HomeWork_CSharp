// 1. По двум заданным числам проверять является ли первое квадратом второго.

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine());
if (second*second == first)
{
    Console.Write($"Число {first} является квадратом числа {second}! ({first} = {second}^2)");
}
else
{
    Console.Write($"Число {first} НЕ является квадратом числа {second}! ({first} != {second}^2)");
}