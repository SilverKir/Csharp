// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void PrintInt(int n, int i = 1)
{
    if (n > i)
    {
        Console.Write($"{i}, ");
        PrintInt(n, i + 1);
    }
    else if (n == i)
    {
        Console.Write($"{n}");
        return;
    }
}

Console.Clear();
int numberN = Prompt("Задайте значение N: ");
PrintInt(numberN);