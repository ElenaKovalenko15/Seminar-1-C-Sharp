//принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

int num = ReadNumber("Введите пятизначное число: ");
//Palindrom(??; ??);

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

//static void Palindrom(string[] args)
{
    int n = 0;
    int sum = 0;
    int rev = 0;
    int temp = n;
    while (n > 0)
    {
        rev = n % 10;
        sum = (sum * 10) + rev;
        n = n / 10;
    }
    {
        if (temp == sum)
            Console.WriteLine("Число - палиндром.");
        else
            Console.WriteLine("Число - не палиндром.");
    }
}