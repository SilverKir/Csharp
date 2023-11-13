// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[,] NewArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}" + "\t");
        }
        Console.WriteLine();
    }
}

double[] ColumsAverage(int [,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        array[i] = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            array[i] += matrix[j, i];
        }
        array[i] =  Math.Round(array[i]/matrix.GetLength(0),2,MidpointRounding.AwayFromZero);
    }
    return array;
}

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count)
    {
        if (position == (count - 1))
        {
            Console.Write($"{col[position]:0.00}");
            position++;
        }
        else
        {
            Console.Write($"{col[position]:0.00}; ");
            position++;
        }
    }
    Console.Write("]");
}

Console.Clear();
int numberM = Prompt("Введите число строк матрицы: ");
int numberN = Prompt("Введите число столбцов: ");
int[,] matrix = NewArray(numberM, numberN);
PrintMatrix(matrix);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
double[] array  = ColumsAverage(matrix);
PrintArray(array);