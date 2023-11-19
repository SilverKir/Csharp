// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
     return Convert.ToInt32(value);
}

int PrintIntSumMN(int n, int m)
{
    if (n > m) return m + PrintIntSumMN(n, m + 1);
    return m;
}

Console.Clear();
int numberM = Prompt("Задайте значение M: ");
int numberN = Prompt("Задайте значение N: ");
Console.WriteLine($"{PrintIntSumMN(numberN, numberM)}");