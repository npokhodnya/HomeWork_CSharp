// 3. Найти максимальное из трех чисел.

int Max(int arg1, int arg2, int arg3)
{
    int maxNum = arg1;
    if (arg2 > maxNum) maxNum = arg2;
    if (arg3 > maxNum) maxNum = arg3;
    return maxNum;
}
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
Console.Write($"Максимальное из трех введённых чисел ({number1}, {number2}, {number3}) - это число {Max(number1, number2, number3)}!");