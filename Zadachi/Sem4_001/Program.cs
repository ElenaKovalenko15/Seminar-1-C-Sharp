//сумма чисел от 1 до Н

// Input
int num = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");

//Logic
int sumNumbers = GetSumNumbers(num);


//Output

Console.WriteLine($"{num} -> {sumNumbers}");


////////////////////////////////////////////////////
static int GetSumNumbers(int number)
{
    int sum = 0;

while(number > 0)
{
    sum += number;
    number--;
}
    return sum;
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
