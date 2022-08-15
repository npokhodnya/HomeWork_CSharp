// 5. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.

void PrintArray(int[] array)
{
    foreach (var element in array) 
        Console.Write($"{element} ");
        Console.WriteLine();
}
void FillArray(int[] array, int min, int max)
{
    var rand = new Random();
    for (int i = 0; i < array.Length; i++) 
        array[i] = rand.Next(min, max+1);
}
void SumOfElements(int[] array)
{
    double notEvenSum = 0;
    double evenSum = 0;
    foreach (var element in array)
    {
        if(element%2==0) evenSum+=element;
        else notEvenSum+=element;
    }
    Console.WriteLine($"Сумма всех чётных элементов = {evenSum}");
    Console.WriteLine($"Сумма всех НЕ чётных элементов = {notEvenSum}");

}
Console.Clear();
Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
int[] array = new int[len];
FillArray(array, 100, 999); 
Console.Write("Массив: ");
PrintArray(array);
SumOfElements(array);
