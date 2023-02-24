// на вход принимает два числа и проверяет, является ли первое квадратом второго. а=25 в=5 -> yes; a=2,b=10 ->yes;a=9 b=-3 -> no; a=-3 b=9 -> no
Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA==numB*numB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}