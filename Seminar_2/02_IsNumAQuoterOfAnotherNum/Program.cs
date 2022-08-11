// 2. По двум заданным числам проверять является ли одно квадратом другого.

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine());
if (second*second == first) Console.Write($"Число {first} является квадратом числа {second}! ({first} = {second}^2)");
else if (first*first == second) Console.Write($"Число {second} является квадратом числа {first}! ({second} = {first}^2)");
else Console.Write($"Ни одно число не является квадратом другого! ({first} != {second}^2 ; {second} != {first}^2)");