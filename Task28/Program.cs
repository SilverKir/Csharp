//// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.

int Rrompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double MultNumber(int varA)
{
    int result = 1;
    for (int i = 1; i <= varA; i++)
    {
        result = result * i;
    }
    return result;
}

int varA = Rrompt("Введите число: ");
double result = MultNumber(varA);
Console.WriteLine(result);
// в первом случае мы превысили int
// 12! это 479001600
