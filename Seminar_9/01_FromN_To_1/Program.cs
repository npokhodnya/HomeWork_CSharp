void From_N_To_1_Rec(int n, int finish=1)
{
    if(finish<=n) 
    {
        Console.Write($"{n} ");
        From_N_To_1_Rec(n-1, finish);
    }
    else return;
}

From_N_To_1_Rec(10);
