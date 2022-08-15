// 2. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива.

void PrintArray(int[] array)
{
    foreach (var element in array) 
        Console.Write($"{element} ");
        Console.WriteLine();
}
void FillArray(int[] array, int min, int max)
{
    var rand = new Random();
    for (int i = 0; i < array.Length; i++) 
        array[i] = rand.Next(min, max+1);
}
void SumOfElements(int[] array)
{
    double positiveSum = 0;
    double negativeSum = 0;
    foreach (var element in array)
    {
        if(element<0) negativeSum+=element;
        else positiveSum+=element;
    }
    Console.WriteLine($"Сумма всех положительных элементов = {positiveSum}");
    Console.WriteLine($"Сумма всех отрицательных элементов = {negativeSum}");

}
Console.Clear();
Console.Write("Введите длинну массива: ");
int len = int.Parse(Console.ReadLine());
int[] array = new int[len];
FillArray(array, 0, 9); // Не пойму причем здесь отрицатеьная сумма, если все элементы положительные
Console.Write("Массив: ");
PrintArray(array);
SumOfElements(array);
