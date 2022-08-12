// Определить количество цифр в числе.

void CountOfDigits(int number)
{
    int count = 0;
    int dublicateNum = number;
    while (dublicateNum>0)
    {
        dublicateNum/=10; 
        count++;
    }
    Console.Write($"Количество цифр в числе {number} = {count}");
}
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
CountOfDigits(num);