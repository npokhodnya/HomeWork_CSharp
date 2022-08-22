// 1. Театральная площадь в столице Берляндии представляет собой прямоугольник n × m метров. 
// Какое наименьшее количество плит понадобится для замощения площади? 

string[] parametres = Console.ReadLine().Split(" ");
int n = int.Parse(parametres[0]);
int m = int.Parse(parametres[1]);
int a = int.Parse(parametres[2]);
decimal h1 = (n + a - 1) / a;
decimal h2 = (m + a - 1) / a;
Console.WriteLine(h1*h2);