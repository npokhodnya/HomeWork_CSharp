﻿int no_row,c=1,blk,i,j;
Console.WriteLine("Input number of rows: ");
no_row = int.Parse(Console.ReadLine());
for(i=0;i<no_row;i++)
{
    for(blk=1;blk<=no_row-i;blk++)
    Console.Write(" ");
    for(j=0;j<=i;j++)
    {
        if (j==0||i==0)
            c=1;
        else
            c=c*(i-j+1)/j;
        Console.Write(" "+c);
    }
    Console.Write("\n");
}