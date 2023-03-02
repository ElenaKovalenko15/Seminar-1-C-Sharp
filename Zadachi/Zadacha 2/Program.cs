// на вход принимает два числа и выдает, какое число больше, а какое меньше.

Console.Write("Введите число: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int numB = int.Parse(Console.ReadLine());

int max = numA;

if (max < numB)
{
    max = numB;
}

Console.Write("max = ");
Console.WriteLine(max);