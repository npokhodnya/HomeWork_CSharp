// 6. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].

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
void CountOfElements(int[] array, int min, int max)
{
    int count = 0;
    foreach (var element in array)
    {
        if(element>9 && element<100) count++;
    }
    Console.WriteLine($"Количество всех элементов из отрезка [{min}, {max}] = {count}");
}
Console.Clear();
int[] array = new int[123];
FillArray(array, 0, 999); 
Console.Write("Массив из 123 элементов: ");
PrintArray(array);
CountOfElements(array, 10, 99);