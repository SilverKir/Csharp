// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x +
// b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double CountX(int k1, int b1, int k2, int b2)
{
return  (double)(b2-b1)/(k1-k2);
}

double CountY(int k1, int b1, int k2, int b2)
{
return  (double)(b1*k2-b2*k1)/(k2-k1);
}



Console.Clear();
int k1 = Prompt("Введите значение к1: ");
int b1 = Prompt("Введите значение b1: ");
int k2 = Prompt("Введите значение к2: ");
int b2 = Prompt("Введите значение b2: ");
Console.WriteLine();
Console.WriteLine($"Точкой пересечения двух прямых, заданных уравнениями y = k1 * x +b1, y = k2 * x + b2 является точка ({CountX(k1, b1, k2, b2)};{CountY(k1, b1, k2, b2)})");