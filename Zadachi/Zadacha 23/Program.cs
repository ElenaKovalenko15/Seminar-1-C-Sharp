// Принимает на вход число N и выдает таблицу кубов чисел от 1 до N.

Console.Clear();

int N = ReadNumber("Введите число: ");
int[] array = new int[N + 1];

CubeNum(array);

PrintArray(array);

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

void CubeNum(int[] CubeNum)
{
    int count = 0;
    int length = CubeNum.Length;
    while (count < length)
    {
        CubeNum[count] = Convert.ToInt32(Math.Pow(count, 3));
        count++;
    }
}


void PrintArray(int[] array)
{
    int spread = array.Length;
    for (int i = 0; i < spread; i++)
    {
        Console.Write(array[i]+ " ");
    }
}