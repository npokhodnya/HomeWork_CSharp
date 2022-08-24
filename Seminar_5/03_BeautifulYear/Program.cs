// 3. Задан номер года, найдите наименьший номер года, который строго больше заданного и в котором все цифры различны.

bool IsBeutifullYear(int num)
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
                return false;
            }
        }
    }
    return true;
}

int CheckYear(int num)
{
    if(IsBeutifullYear(num)) return num+1;
    else return CheckYear(num+1);
        
}
Console.WriteLine(CheckYear(int.Parse(Console.ReadLine())));
