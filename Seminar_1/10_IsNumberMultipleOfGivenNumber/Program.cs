// 10. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int remainder = num1 % num2;
if (remainder == 0)
{
    Console.Write($"Число {num1} КРАТНО числу {num2}!");
}
else
{
    Console.Write($"Число {num1} НЕ КРАТНО числу {num2}! Остаток - {remainder}");
}
