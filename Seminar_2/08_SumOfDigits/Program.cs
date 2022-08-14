// 8. Подсчитать сумму цифр в числе.

string SumOfDigits(int number)
{
    int sum = 0;
    int dublicateNum = number;
    while (dublicateNum>0)
    {
        sum+=dublicateNum%10;
        dublicateNum/=10; 
    }
    return $"Сумма цифр в числе {number} = {sum}";
}
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write(SumOfDigits(num));