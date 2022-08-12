// Найти сумму чисел от 1 до А.

void SumOfNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++) sum+=i;
    Console.Write($"Сумма чисел от 1 до {number} = {sum}");
}
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
SumOfNums(num);
