// 2. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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
void FindAvergeOfColumnsMatrix(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++) // Это столбцы
    {
        for (int j = 0; j <  matrix.GetLength(0); j++) // Это строки
        {
            sum+=matrix[j, i];
        }
        Console.WriteLine($"Среденее арифметичекое {i+1} столбца = {(float)sum/matrix.GetLength(0)}");
        sum = 0;
    }
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
FindAvergeOfColumnsMatrix(massive);
