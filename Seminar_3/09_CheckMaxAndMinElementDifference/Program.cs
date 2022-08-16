// 9. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

void PrintArray(double[] array)
{
    foreach (var element in array) Console.Write($"{element} ");
    Console.WriteLine();
}
void FillArray(double[] array, int min, int max)
{
    var rand = new Random();
    for (int i = 0; i < array.Length; i++) 
        array[i] =Math.Round(rand.NextDouble(), 2) * rand.Next(min, max+1);
}
double CheckDiff(double[] array)
{
    return array[1] - array[0];
}
double[] FindMaxAndMinElement(double[] array)
{
    double maxElement = array[0];
    double minElement = array[0];
    foreach (var element in array) 
    {
        if(maxElement<element) maxElement = element;
        else if(minElement>element) minElement = element;
    }
    double[] max_min = new double[] {minElement, maxElement};
    return max_min;
}
Console.Clear();
Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
double[] array = new double[len];
FillArray(array, -10, 10);
Console.Write($"Массив : ");
PrintArray(array);
Console.WriteLine($"Максимальный элемент = {FindMaxAndMinElement(array)[1]}, минимальный элемент =  {FindMaxAndMinElement(array)[0]}");
Console.WriteLine($"Разница между максимальным и минимальным элементом = {CheckDiff(FindMaxAndMinElement(array))}");
