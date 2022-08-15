// 7. Найти сумму чисел одномерного массива стоящих на нечетной позиции.

void PrintArray(int[] array)
{
    foreach (var element in array) Console.Write($"{element} ");
    Console.WriteLine();
}
void FillArray(int[] array, int min, int max)
{
    var rand = new Random();
    for (int i = 0; i < array.Length; i++) 
        array[i] = rand.Next(min, max+1);
}
void SumOfElementsOnNotEvenIndexes(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i+=2) count++;
    Console.WriteLine($"Сумма всех элементов, стоящих на нечётных индексах = {count}");
}
Console.Clear();
Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
int[] array = new int[len];
FillArray(array, 10, 99); 
Console.Write("Массив: ");
PrintArray(array);
SumOfElementsOnNotEvenIndexes(array);
