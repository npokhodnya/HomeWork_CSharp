// Найти кубы чисел от 1 до N.

void CheckNumsInThreeDegree(int number)
{
    Console.Write("Все числа (уже в 3 степени!) по порядку: ");
    for (int i = 1; i <= number; i++) Console.Write($"{Math.Pow(i, 3)} ");
}
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
CheckNumsInThreeDegree(num);