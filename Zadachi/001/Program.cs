//Квадрат числа возвращает
Console.Write("Введите целое число: ");

string userInputStr = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInputStr);

int result = userNumber * userNumber;

Console.WriteLine(result);
