// 2. По заданному номеру дня недели вывести его название.

Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());

// У программистов всё с нуля начинается :)
if ((number == 0) || (number  == 1)) Console.Write($"День недели под номером {number} - это ПОНЕДЕЛЬНИК!");   
else if (number == 2) Console.Write($"День недели под номером {number} - это ВТОРНИК!");
else if (number == 3) Console.Write($"День недели под номером {number} - это СРЕДА!");
else if (number == 4) Console.Write($"День недели под номером {number} - это ЧЕТВЕРГ!");
else if (number == 5) Console.Write($"День недели под номером {number} - это ПЯТНИЦА!");
else if (number == 6) Console.Write($"День недели под номером {number} - это СУББОТА!");
else if (number == 8) Console.Write($"День недели под номером {number} - это ВОСКРЕСЕНЬЕ!");
else if ((number < 0) || (number  > 8)) Console.Write($"Число {number} НЕ является номером дня недели!");
