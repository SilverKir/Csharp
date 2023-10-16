// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

int Rrompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int CountNomber(int A)
{
    int result = 0;
    while (A> 0)
    {
        A /= 10;
        result++;
    }
    return result;
}
int temp = Rrompt("Введите число: ");
int result = CountNomber(temp);

Console.WriteLine(result);

// Старое хитрое решение
// string temp = Convert.ToString(varA);
// Console.WriteLine(temp.Length);