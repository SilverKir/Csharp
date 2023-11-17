// Задача 59: Задайтедвумерный массив из целых чисел. Напишите
// программу, которая удалит строку и столбец, на пересечении которых
// расположен наименьший элемент массива.

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
            matrix[i, j] = new Random().Next(0, 11);
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

(int row, int column) FindMin(int[,] matrix)
{
    int minimum = matrix[0, 0];
    int minColumn = 0;
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minimum > matrix[i, j])
            {
                minimum = matrix[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    return (minRow, minColumn);
}

int[,] DelMinRowColumn(int[,] matrix, int row, int column)
{
    int[,] newmatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int k = 0;
    int m = 0;
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        if (i < row)
        { k = i; }
        else
        { k = i + 1; }

        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (j < column) { m = j; }
            else { m = j + 1; }
            newmatrix[i, j] = matrix[k, m];
        }
    }
    return newmatrix;
}



Console.Clear();
int numberM = Prompt("Введите число строк матрицы: ");
int numberN = Prompt("Введите число столбцов: ");
int[,] matrix = NewArray(numberM, numberN);
PrintMatrix(matrix);
(int row, int column) = FindMin(matrix);

Console.WriteLine($"строка{row} столбец {column}");
Console.WriteLine("Нова матрица:");

PrintMatrix(DelMinRowColumn(matrix, row, column));