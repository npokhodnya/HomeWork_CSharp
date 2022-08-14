// 9. Написать программу вычисления произведения чисел от 1 до N.

void MultiplyOfNums(int number)
{
    int multiply = 1;
    for (int i = 1; i <= number; i++) multiply*=i;
    Console.Write($"Произведение чисел от 1 до {number} = {multiply}");
}
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
MultiplyOfNums(num);