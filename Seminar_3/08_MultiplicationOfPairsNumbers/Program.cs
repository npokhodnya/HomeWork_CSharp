// 8. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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
void MultiplicationOfPairs(int[] array)
{
    int indexMax = array.Length-1;
    int indexMin = 0;
    int helper = 0;
    if(indexMax%2 == 0) helper = indexMax/2;
    else helper = indexMax/2+1;
    for (int i = 0; i < helper; i++) 
    {
        Console.WriteLine($"Произведение пары чисел {array[indexMin]} и {array[indexMax]} = {array[indexMin] * array[indexMax]}!");
        indexMax--;
        indexMin++;
    }
}
Console.Clear();
Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
int[] array = new int[len];
FillArray(array, 0, 10);
PrintArray(array);
MultiplicationOfPairs(array);
