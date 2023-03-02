// принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int Num = int.Parse(Console.ReadLine());

int a2 = (Num / 10) % 10;

Console.WriteLine($"Вторая цифра числа {Num} -> {a2}");