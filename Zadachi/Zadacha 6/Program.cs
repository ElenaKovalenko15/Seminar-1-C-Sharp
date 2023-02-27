// на вход принимает число и выдает, является ли число четным.
Console.WriteLine("Введите число: ");
int UserNum = Convert.ToInt32(Console.ReadLine());

if (UserNum % 2 == 0)
    Console.Write("-> четное");
else Console.Write("-> нечетное");