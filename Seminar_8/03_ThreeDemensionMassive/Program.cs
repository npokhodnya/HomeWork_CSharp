// 3. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента.

void FillMassive(int[,,] array, int min, int max)
{
    var rand = new Random();
    int num = rand.Next(min, max+1);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++) 
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (true) 
                {
                    if (!IsNumInArray(array, num)) 
                    {
                        array[i, j, k] = num;
                        break;
                    }
                    num = rand.Next(min, max+1);
                } 
            }
        }
    }
}
void PrintMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++) 
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} - [{i}, {j}, {k}]");
                Console.WriteLine();
            } 
            
        }
    }
}
bool IsNumInArray(int[, ,] matrix, int num)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <  matrix.GetLength(1); j++) 
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == num)
                    return true;
            } 
        }
    }
    return false;
}
Console.Clear();
Console.Write("Enter 0 demension: ");
var n = int.Parse(Console.ReadLine());
Console.Write("Enter 1 demension: ");
var m = int.Parse(Console.ReadLine());
Console.Write("Enter 2 demension: ");
var b = int.Parse(Console.ReadLine());
int[,,] massive = new int[m, n, b];
FillMassive(massive, 10, 99);
Console.WriteLine("Матрица: ");
PrintMatrix(massive);
Console.WriteLine();

