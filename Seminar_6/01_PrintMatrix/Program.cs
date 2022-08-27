// 1. Показать двумерный массив размером m×n заполненный вещественными числами.

double[,] CreateMatrixDouble(int row, int col, int min, int max)
{
    var matrix = new double[row, col];
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <  matrix.GetLength(1); j++) matrix[i, j] = rand.Next(min, max+1) * Math.Round(rand.NextDouble(), 3);
    }
    return matrix;
}
void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите число столбцов: ");
var n = int.Parse(Console.ReadLine());
Console.Write("Введите число сторк: ");
var m = int.Parse(Console.ReadLine());
Console.WriteLine();
var matr = CreateMatrixDouble(m, n, 0, 9);
PrintMatrix(matr);
