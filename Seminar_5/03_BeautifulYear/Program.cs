// 3. Задан номер года, найдите наименьший номер года, который строго больше заданного и в котором все цифры различны.

int IsBeutifullYear(int num)
{
    num++;
    string yearString = num.ToString();
    for (int i = 0; i < yearString.Length; i++)
    {
        for (int j = 0; j < yearString.Length; j++)
        {
            // Console.WriteLine($"{yearString[i]} - {yearString[j]}");   --->   This code shows how the numbers are compared 
            if (yearString[i] == yearString[j] && i != j)
            {
                return IsBeutifullYear(num);
            }
        }
    }
    return num;
}
Console.WriteLine(IsBeutifullYear(int.Parse(Console.ReadLine())));
