// 1. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет.

void FillMatrix(int[,] array, int min, int max)
{
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++) array[i, j] = rand.Next(min, max+1);
    }
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
void FindElementMatrix(int[,] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            if(array[i, j] == num) 
            {
                if(count == 0) Console.WriteLine($"Элемент ({num}) есть этом в массиве он занимает позицию [{i}, {j}]");
                else Console.WriteLine($"Найден ещё один элемент ({num}), он занимает позицию [{i}, {j}]");
                count++;
            }
        }
    }
    if(count == 0) Console.WriteLine($"Элемента ({num}) НЕТ в этом массиве!");
}
Console.Clear();
Console.Write("Введите число столбцов: ");
var n = int.Parse(Console.ReadLine());
Console.Write("Введите число сторк: ");
var m = int.Parse(Console.ReadLine());
int[,] massive = new int[m, n];
FillMatrix(massive, 0, 9);
Console.WriteLine("Матрица: ");
PrintMatrix(massive);
Console.WriteLine();
Console.Write("Введите число, которое хотите найти: ");
var num = int.Parse(Console.ReadLine());
Console.WriteLine();
FindElementMatrix(massive, num);
