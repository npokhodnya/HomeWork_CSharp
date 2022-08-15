// 3. Написать программу замену элементов массива на противоположные.

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
void ChangeElementsOfMassive(int[] array)
{
    for (int i = 0; i < array.Length; i++) 
        array[i] = -array[i];
}
Console.Clear();
Console.Write("Введите длинну массива: ");
int len = int.Parse(Console.ReadLine());
int[] array = new int[len];
FillArray(array, -20, 20);
Console.Write("Массив: ");
PrintArray(array);
ChangeElementsOfMassive(array);
Console.Write("Изменённый массив: ");
PrintArray(array);
