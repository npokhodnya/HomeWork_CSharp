// 8. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.

int Max(int arg1, int arg2)
{
    int maxNum = arg1;
    if (arg2 > maxNum) maxNum = arg2;
    return maxNum;
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if(n > 9 && n < 100)
{
    Console.Write($"Максимальная из цифр введённого числа ({n}) - это цифра {Max(n/10, n%10)}!");
}
else
{
    Console.WriteLine($"Число должно быть от 10 и до 99! (по условию задачи)");
}
