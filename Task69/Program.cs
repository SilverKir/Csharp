// 69. Напишите программу, котора на вход принимает два числа А и В,  и возводит число А в целую степень числа В с помощью рекурсии.

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
     return Convert.ToInt32(value);
}

int PowerAB(int a, int b)
{
    if (b > 1) return a*PowerAB(a, b-1);
    return a;
}

Console.Clear();
int numberN = Prompt("Число А: ");
int numberM = Prompt("Число Б: ");
Console.WriteLine($"{PowerAB(numberN, numberM)}");