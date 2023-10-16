// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Rrompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int DegreeDo(int number, int degree)
{

    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result = result * number;
    }
    return result;
}
Console.Clear();
int number = Rrompt("Введите число которое нужно возвести в степень: ");
int degree = Rrompt("Введите натуральную степень: ");
if (degree > 0)
{
    int result = DegreeDo(number, degree);
    Console.WriteLine($"Если возвести число {number} в степень {degree}, то получим результат {result}");
}
else
{
    Console.WriteLine($"Введенное число {degree} не явлется натуральным");
}
