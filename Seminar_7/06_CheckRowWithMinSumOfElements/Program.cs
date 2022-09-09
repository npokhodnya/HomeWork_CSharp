// 6. В прямоугольной матрице найти строку с наименьшей суммой элементов.

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
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int[] MinSumInRows(int[,] matrix)
{
    int nowRowSum = 0;
    int nowRowNumber = 0;
    int minSum = 0;
    int minRowNumber = 0;
    for (int i = 0; i <  matrix.GetLength(1); i++)
    {
        minSum+=matrix[0, i];
    }
    for (int k = 0; k <  matrix.GetLength(0); k++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            nowRowSum+=matrix[k, j];
            nowRowNumber = k;
        }
        if(nowRowSum < minSum)
        {
            minSum = nowRowSum;
            minRowNumber = nowRowNumber;
        }
        nowRowNumber = 0;
        nowRowSum = 0;
    }
    return new int[] {minSum, minRowNumber};
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
Console.Write($"Строка - {MinSumInRows(massive)[1]} (или {MinSumInRows(massive)[1]+1} по-человечески). "); 
Console.Write($"Сумма элементов в этой строке = {MinSumInRows(massive)[0]}");