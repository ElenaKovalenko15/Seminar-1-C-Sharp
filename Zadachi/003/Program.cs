// программа будет выдавать название дня недели по заданному номеру 3-> среда 5-> пятница
Console.Write("Прошу ввести число");
int week = Convert.ToInt32(Console.ReadLine());

if ((week > 7) || (week < 1))
{
    Console.WriteLine("Неверное число");

}
else
{
    if (week == 1) { Console.Write($"{week} -> Понедельник"); }
    if (week == 2) { Console.Write($"{week} -> Вторник"); }
    if (week == 3) { Console.Write($"{week} -> Среда"); }
    if (week == 4) { Console.Write($"{week} -> Четверг"); }
    if (week == 5) { Console.Write($"{week} -> Пятница"); }
    if (week == 6) { Console.Write($"{week} -> Суббота"); }
    if (week == 7) { Console.Write($"{week} -> Воскресенье"); }
}