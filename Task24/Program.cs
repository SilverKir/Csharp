//  Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
int Rrompt (string  massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result= Convert.ToInt32(value);
    return result;
}

int SummNumber(int A) {
    int result = 0;
    for (int i = 1; i <= A; i++)
    {
        result += i;
    }
    return result;
}

Console.WriteLine(SummNumber(Rrompt ("Введите число: ")));
