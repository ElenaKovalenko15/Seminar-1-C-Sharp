// по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (х и у).

Console.Clear();

int num = ReadNumber("Введите номер четверти: ");
PrintResualt(num);

static int ReadNumber(string Message)
{
    int n = 0;
    while (true)
    {
        try
        {
            Console.Write(Message);
            n = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception exc)
        { Console.WriteLine("Ошибка ввода"); }
    }
    return n;
}

static void PrintResualt(int num)
{
    if (num == 1)
        Console.WriteLine("X > 0 и Y > 0");
    else if (num == 2)
        Console.WriteLine("X < 0 и Y > 0");
    else if (num == 3)
        Console.WriteLine("X < 0 и Y < 0");
    else if (num == 4)
        Console.WriteLine("X > 0 и Y < 0");
    else
        Console.Write("Ошибка ввода");
}