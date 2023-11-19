// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}

int Ack(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Ack(n - 1, 1);
    else return Ack(n - 1, Ack(n, m - 1));
}

Console.Clear();
int numberN = Prompt("Задайте значение m: ");
int numberM = Prompt("Задайте значение n: ");
Console.WriteLine($"A({numberN},{numberM}) = {Ack(numberN, numberM)}");