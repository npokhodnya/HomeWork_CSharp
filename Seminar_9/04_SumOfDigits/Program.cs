int SumOfDigitsRec(int n)
{
    return n > 0 ? n%10+SumOfDigitsRec(n/10) : 0;
}

Console.Write(SumOfDigitsRec(12345)); // Output: 15 (1 + 2 + 3 + 4 + 5)