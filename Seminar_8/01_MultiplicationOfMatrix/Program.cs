// 1. Найти произведение двух матриц.

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
int[,] FindMultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(1); i++) // Это столбцы
    {
        for (int j = 0; j <  matrix2.GetLength(0); j++) // Это строки
        {
            resMatrix[j, i] = matrix1[j, i] * matrix2[j, i];
        }
    }
    return resMatrix;
}
Console.Clear();
Console.Write("Введите число столбцов: ");
var n = int.Parse(Console.ReadLine());
Console.Write("Введите число сторк: ");
var m = int.Parse(Console.ReadLine());
int[,] massive = new int[m, n];
FillMatrix(massive, 0, 9);
Console.WriteLine("1 матрица: ");
PrintMatrix(massive);
Console.WriteLine();
int[,] massive2 = new int[m, n];
FillMatrix(massive2, 0, 9);
Console.WriteLine("2 матрица: ");
PrintMatrix(massive2);
Console.WriteLine();
var matr = FindMultiplicationMatrix(massive, massive2);
Console.WriteLine("Результат: ");
PrintMatrix(matr);
Console.WriteLine();