// 2. По заданному номеру дня недели вывести его название.

Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
string[] array = new string[] {"ПОНЕДЕЛЬНИК", "ВТОРНИК", "СРЕДА", "ЧЕТВЕРГ", "ПЯТНИЦА", "СУББОТА", "ВОСКРЕСЕНЬЕ"};
if ((number >= 1) && (number < 8)) Console.Write($"День недели под номером {number} - это {array[number-1]}!");
else Console.Write($"Число {number} НЕ является номером дня недели!");
