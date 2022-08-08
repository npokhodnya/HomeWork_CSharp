// 2. По заданному номеру дня недели вывести его название.

Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number == 0)
{
    Console.Write($"День недели под номером {number} - это ПОНЕДЕЛЬНИК!");
}
if (number == 1)
{
    Console.Write($"День недели под номером {number} - это ПОНЕДЕЛЬНИК!");
}
if (number == 2)
{
    Console.Write($"День недели под номером {number} - это ВТОРНИК!");
}
if (number == 3)
{
    Console.Write($"День недели под номером {number} - это СРЕДА!");
}
if (number == 4)
{
    Console.Write($"День недели под номером {number} - это ЧЕТВЕРГ!");
}
if (number == 5)
{
    Console.Write($"День недели под номером {number} - это ПЯТНИЦА!");
}
if (number == 6)
{
    Console.Write($"День недели под номером {number} - это СУББОТА!");
}
if (number == 8)
{
    Console.Write($"День недели под номером {number} - это ВОСКРЕСЕНЬЕ!");
}
if ((number < 0) || (number  > 8))
{
    Console.Write($"Число {number} НЕ является номером дня недели!");
}
    

