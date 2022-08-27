// 2. Задать двумерный массив следующим правилом: Aₘₙ = m+n.

int[,] CreateMatrix(int row, int col)
{
    var matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <  matrix.GetLength(1); j++) matrix[i, j] = i+j;
    }
    return matrix;
}
void PrintMatrix(int[,] array)
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
var matr = CreateMatrix(m, n);
PrintMatrix(matr);
