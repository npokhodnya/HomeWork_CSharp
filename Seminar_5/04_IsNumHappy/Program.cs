// 4. Петя называет число почти счастливым, если количество счастливых цифр в нем — счастливое число. Ему интересно, является ли число n почти счастливым.

string IsHappyYear(string num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        // Console.WriteLine($"{num[i]} - element ");   --->   This code shows each element, for example "7 - element"
        if ((num[i] == '4') || (num[i] == '7')) count++;
    }
    // Console.WriteLine($"count - count of elements (4 and 7 only)");   -->   This code shows the final number of elements (4 and 7 only)
    if (count == 4 || count == 7) return "YES";
    else return "NO";
}
Console.WriteLine(IsHappyYear(Console.ReadLine()));
