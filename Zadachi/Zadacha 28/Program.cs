// Принимает число N и выдает произведение от 1 до N

int num = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");
int powNumbers = GetPowNumbers(num);
Console.WriteLine($"{num} -> {powNumbers}");

static int GetPowNumbers(int number)
{
    int pow = 1;

while(number > 0)
{
    pow *= number;
    number--;
}
    return pow;
}

static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber >= 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}