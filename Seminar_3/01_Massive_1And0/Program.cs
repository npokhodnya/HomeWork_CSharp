// 1. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран.

void PrintArray(int[] array)
{
    foreach (var element in array) 
        Console.Write($"{element} ");
}
void FillArray(int[] array, int min, int max)
{
    var rand = new Random();
    for (int i = 0; i < array.Length; i++) 
        array[i] = rand.Next(min, max+1);
}
Console.Clear();
Console.Write("Введите длинну массива: ");
int len = int.Parse(Console.ReadLine());
int[] array = new int[len];
FillArray(array, 0, 1);
Console.Write("Массив: ");
PrintArray(array);