// 3. Написать программу масштабирования фигуры.

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
int[] CopyMassive(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for (int i = 0; i < array.Length; i++) arrayCopy[i] = array[i];
    return arrayCopy;
}
Console.Clear();
Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
int[] array = new int[len];
FillArray(array, 10, 99); 
Console.Write("Массив: ");
PrintArray(array);
Console.Write("Копия массива: ");
PrintArray(CopyMassive(array));
