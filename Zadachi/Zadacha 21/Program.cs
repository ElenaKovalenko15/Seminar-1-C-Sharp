// принимает на вход координаты двух точек и находитрасстояние между ними в 2D пространстве.

Console.Clear();
int x1 = InputNumber("Введите х1: ");
int y1 = InputNumber("Введите у1: ");
int x2 = InputNumber("Введите х2: ");
int y2 = InputNumber("Введите у2: ");

Console.WriteLine($"Расстояние между точками ({x1}, {y1}) и ({x2}, {y2}) {CalculateDistance(x1, y1, x2, y2)})"); //здесь сразу же вызывается метод, которому передаются координаты

static int InputNumber(string Message) // в Message попадают все сообщения по очереди из int x1, y1 etc.
{
    try
    {
        Console.Write(message);
        return (int.Parse(Console.ReadLine() ?? ""));
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}

static double CalculateDistance(int x1, int y1, int x2, int y2)
{
    return Math.sqrt(Math.Pow(x2-x1, 2) + (Math.Pow(y2-y1, 2))); // Math.sqrt корень квадратный Math.Pow возведение числа в степень
}