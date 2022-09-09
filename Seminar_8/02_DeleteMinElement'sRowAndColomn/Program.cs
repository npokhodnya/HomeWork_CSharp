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
int[] MinSumInRows(int[,] matrix)
{
    int minElement = int.MaxValue;
    int minColNumber = 0;
    int minRowNumber = 0;
    for (int k = 0; k <  matrix.GetLength(0); k++)
    {
        for (int i = 0; i <  matrix.GetLength(1); i++)
        {
            if(matrix[k, i] < minElement)
            {
                minElement = matrix[k, i];
                minRowNumber = k;
                minColNumber = i;
            }
        }
    }
    return new int[] {minColNumber, minRowNumber};
}
int[,] DelRowAndColInMatrix(int[] ignore, int[,] matrix)
{
    int[,] resMatr = new int[matrix.GetLength(0)-1, matrix.GetLength(0)-1];
    int k = 0, n = 0;
    for (int i = 0; i <  resMatr.GetLength(1); i++)
    {
        k = i >= ignore[1] ? i+1 : i;
        for (int j = 0; j < resMatr.GetLength(0); j++)
        {
            n = j >= ignore[0] ? j+1 : j;
            resMatr[i, j] = matrix[k, n];
        }
    }
    return resMatr;
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
Console.WriteLine("Матрица после удаления: ");
var res = DelRowAndColInMatrix(MinSumInRows(massive), massive);
PrintMatrix(res);