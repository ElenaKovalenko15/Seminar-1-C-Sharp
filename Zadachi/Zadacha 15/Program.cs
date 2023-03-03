// принимает на вход цифру, обозначающую день недели, и прооверяет, является ли этот деньвыходным.

Console.Clear();
Console.WriteLine("Введите число: ");
int Den = int.Parse(Console.ReadLine());

if ((Den > 7) || (Den < 1))
{
    Console.WriteLine("Неверное число");

}
else
{
    bool resualt = (Den == 6) || (Den == 7);

    if (resualt)
    {
        Console.WriteLine($"День недели с порядковым номером {Den} -> выходной.");
    }

    else
    {
        Console.WriteLine($"День недели с порядковым номером {Den} -> будний.");
    }
}