int MultiA_And_B_Rec(int a, int b)
{
    return b >= 1 ? a*MultiA_And_B_Rec(a, b - 1) : 1;
}

Console.Write(MultiA_And_B_Rec(2, 3)); // Output: 8 (2 * 2 * 2)
