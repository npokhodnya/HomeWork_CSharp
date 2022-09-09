// 4. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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
int[,] SwitchElements(int[,] matrix)
{
    for (int k = 0; k <  matrix.GetLength(0); k++)
    {
        for (int j = 0; j <  matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                 if(matrix[k, i] > matrix[k, j])
                {
                    int temp = matrix[k, i];
                    matrix[k, i] = matrix[k, j];
                    matrix[k, j] = temp;
                }
            }
        }
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
int[,] matrix = SwitchElements(massive);
PrintMatrix(matrix);
