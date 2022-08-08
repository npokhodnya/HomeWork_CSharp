// 9. Удалить вторую цифру трёхзначного числа.

Console.Write("Введите число: (от 100 до 999)");
int n = int.Parse(Console.ReadLine());
if(n > 99 && n < 1000)
{
    int newNumber = (n/100 * 10 + n%10);
    Console.WriteLine($"Если в числе {n} удалить вторую цифру, то получится число {newNumber}!");
}
else
{
    Console.WriteLine($"В числе нет второй цифры!");
}
