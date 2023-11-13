// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double[,] NewArray(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * (20) - 10, 2, MidpointRounding.AwayFromZero);
        }
    }
    return matrix;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
    }
}

Console.Clear();
int numberM = Prompt("Введите число строк матрицы: ");
int numberN = Prompt("Введите число столбцов: ");
double[,] matrix = NewArray(numberM, numberN);
PrintArray(matrix);