// Принимает три числа и выдвет максимальное их них
Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;

if (max < numB) max=numB;
if (max < numC) max=numC;

Console.Write("max = ");
Console.WriteLine(max);
