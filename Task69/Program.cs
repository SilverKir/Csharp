// 69. Напишите программу, котора на вход принимает два числа А и В,  и возводит число А в целую степень числа В с помощью рекурсии.

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}

int PowerAB(int a, int b)
{
    return b == 0 ? 1 : a * PowerAB(a, b - 1);

    // if (b == 0) return 1;
    // else if (b % 2 == 0) return PowerAB(a * a, b / 2);
    // else return a * PowerAB(a, b - 1);
}


Console.Clear();
int numberN = Prompt("Число А: ");
int numberM = Prompt("Число Б: ");
Console.WriteLine($"{PowerAB(numberN, numberM)}");