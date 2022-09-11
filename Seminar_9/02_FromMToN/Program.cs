void From_M_To_N_Rec(int m, int n)
{
    if(m<=n) 
    {
        Console.Write($"{m} ");
        From_M_To_N_Rec(n, m+1);
    }
    else return;
}

From_M_To_N_Rec(10, 5); // 5 6 7 8 9 10 