// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Rrompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int SumNumber(int A)
{
    int result = 0;
    while (A > 0)
    {
        result += A % 10;
        A /= 10;
    }
    return result;
}

Console.Clear();
int temp = Rrompt("Введите число: ");
int result = SumNumber(temp);
Console.WriteLine(result);