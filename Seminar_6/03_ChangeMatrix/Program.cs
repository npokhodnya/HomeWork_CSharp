// 3. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

int[,] CreateMatrix(int row, int col, int min, int max)
{
    var matrix = new int[row, col];
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <  matrix.GetLength(1); j++) matrix[i, j] = rand.Next(min, max+1);
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
void ChangeMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            if(i%2 == 0 && j%2 == 0) array[i, j] = array[i, j]*array[i, j];
        }
    }
}
Console.Clear();
Console.Write("Введите число столбцов: ");
var n = int.Parse(Console.ReadLine());
Console.Write("Введите число сторк: ");
var m = int.Parse(Console.ReadLine());
Console.WriteLine();
var massive = CreateMatrix(m, n, 0, 9);
Console.WriteLine("До изменений: ");
PrintMatrix(massive);
Console.WriteLine();
Console.WriteLine("После изменений: ");
ChangeMatrix(massive);
PrintMatrix(massive);
