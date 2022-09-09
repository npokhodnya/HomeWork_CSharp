// 3. Написать программу, которая обменивает элементы первой строки и последней строки.

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
int[,] SwitchElementsInMatrix(int[,] matrix)
{
    for (int j = 0; j <  matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[(matrix.GetLength(0) - 1),j];
        matrix[(matrix.GetLength(0) - 1), j] = temp;
    }
    return matrix;
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
int[,] matrix = SwitchElementsInMatrix(massive);
PrintMatrix(matrix);
