// 2. Слоник решил сходить в гости к другу. 
// Помогите ему определить, за какое минимальное количество шагов он может добраться до дома друга.

var x = double.Parse(Console.ReadLine());
var res = x/5;
if (res%1 > 0) Console.WriteLine((int)res+1);
else Console.WriteLine(res);