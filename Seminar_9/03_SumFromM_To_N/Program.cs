int SumFrom_N_To_N_Rec(int m, int n)
{
    return n >= m ? m+SumFrom_N_To_N_Rec(m+1, n) : 0;
}

Console.Write(SumFrom_N_To_N_Rec(1, 3)); // Output: 6 (1 + 2 + 3)
