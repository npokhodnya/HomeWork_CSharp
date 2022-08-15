// 4. Определить, присутствует ли в заданном массиве, некоторое число.

void FindElementInArray(int[] array, int element)
{
    int countElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == element)
            Console.WriteLine($"Элемент {element} присутствует в этом массиве и занимает индекс под номером {i}!");
            countElements++;
    }
    if (countElements == 0) Console.WriteLine($"Элемента {element} НЕТ в этом массиве!");
}

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

Console.Clear();
Console.Write("Введите длинну массива: ");
int len = int.Parse(Console.ReadLine());
int[] array = new int[len];
FillArray(array, -20, 20);
Console.Write("Массив: ");
PrintArray(array);
Console.Write("Введите число, которое хотите найти: ");
int element = int.Parse(Console.ReadLine());
FindElementInArray(array, element);
