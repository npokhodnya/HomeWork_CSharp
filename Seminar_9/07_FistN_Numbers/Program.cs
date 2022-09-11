int N = 10;
int a = 3;
int b = 5;

int CheckNumber(int a, int b, int position)
{
    if (position == 1) return a;
    if (position == 2) return b;
    return CheckNumber(a, b, position - 2) + CheckNumber(a, b, position - 1);
}

void ShowNumbers(int count, int nowPosition = 0)
{
    nowPosition++;
    if(count >= nowPosition)
    {
        Console.Write($"{CheckNumber(a, b, nowPosition)} ");
        ShowNumbers(count, nowPosition);
    }
    else return; 
}

ShowNumbers(5); // 3 5 8 13 21  --->  3, 5, (3 + 5), (3 + 5 + 5), (3 + 5 + 5 + (3 + 5)