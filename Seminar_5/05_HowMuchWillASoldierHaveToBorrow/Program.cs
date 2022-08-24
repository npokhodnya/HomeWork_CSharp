// 5. Сколько долларов ему придется одолжить у однополчанина, чтобы купить w бананов?

int HowMuch(int cost, int count, int quantity)
{
    int sum = 0;
    for (int i = 1; i <= quantity; i++) sum+=i*cost;
    // Console.WriteLine(sum);   --->   This code shows the required amount of payment for bananas
    int res = count - sum;
    // Console.WriteLine(res);   --->   This code shows how many soldiers should be occupied (if >= 0, it returns 0)
    if(res>=0) return 0;
    else return -res;
}
string[] parametres = Console.ReadLine().Split(" ");
int k = int.Parse(parametres[0]);
int n = int.Parse(parametres[1]);
int w = int.Parse(parametres[2]);
Console.WriteLine(HowMuch(k, n, w));
