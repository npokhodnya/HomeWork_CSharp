// See https://aka.ms/new-console-template for more information

void CheckCubesOfNums(int[] numbers)
{
    foreach (int element in numbers)
        if ((element%10)%2 == 0) Console.Write($"{element*element*element} ");
}
void PrintArray(int[] array)
{
    foreach (int element in array) Console.Write($"{element} ");
}
Console.Clear();
var rand = new Random();
int[] array = new int[] {rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10)};
Console.Write("Список всех элементов - ");
PrintArray(array);
Console.WriteLine();
Console.Write("Список кубов - ");
CheckCubesOfNums(array);

