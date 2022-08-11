// 1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
string[] array = new string[] {"ПОНЕДЕЛЬНИК", "ВТОРНИК", "СРЕДА", "ЧЕТВЕРГ", "ПЯТНИЦА", "СУББОТА", "ВОСКРЕСЕНЬЕ"};
if ((number >= 1) && (number < 8))
{
    if ((number == 6) || (number == 7))
    {
        Console.Write($"День недели под номером {number} - это {array[number-1]}! Это выходной!");
    }
    else
    {
        Console.Write($"День недели под номером {number} - это {array[number-1]}! Это НЕ выходной!");
    }
}
else Console.Write($"Число {number} НЕ является номером дня недели!");
