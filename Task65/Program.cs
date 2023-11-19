// Задача 65: Задайте значения M и N. напишите программу, котора выведет все натуральные числа в промежутке от M до N.

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void PrintIntMN(int n, int m)
{
    if (n > m)
    {
        Console.Write($"{m}, ");
        PrintIntMN(n, m + 1);
    }
    else if (n == m)
    {
        Console.Write($"{n}");
        return;
    }
}

Console.Clear();
int numberM = Prompt("Задайте значение M: ");
int numberN = Prompt("Задайте значение N: ");
PrintIntMN(numberN, numberM);