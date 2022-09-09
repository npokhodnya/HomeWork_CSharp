// 5. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

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
void SwitchRowsToColumns(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        int[,] nums = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int m = 0; m < matrix.GetLength(0); m++)
        {
            for (int n = 0; n < matrix.GetLength(1); n++)
            {
                nums[m, n] = matrix[m, n];
            }
        }
        for (int m = 0; m < matrix.GetLength(0); m++)
        {
            for (int n = 0; n < matrix.GetLength(1); n++)
            {
                matrix[m, n] = nums[n, m];
            }
        }
    }
    else Console.WriteLine("Матрица не квадратная");
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
SwitchRowsToColumns(massive);
PrintMatrix(massive);
