//67. Напришите программу, котора будет принимать на вход число и возвращать сумму его цифр.

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
     return Convert.ToInt32(value);
}

int SumN(int n)
{
    if (n/10>0) return n%10 + SumN(n/10);
    return n;
}

Console.Clear();
int numberN = Prompt("Задайте значение N: ");
Console.WriteLine($"Сумма цифр числа {numberN} равна {SumN(numberN)}");