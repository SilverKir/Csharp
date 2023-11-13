// Задайте двумернй массив. Напишите программу, котора поменет
// местами первую и последнюю строку массива

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

int [,] ChangeArray(int[,] array) 
{
    int[,] matrix = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i==0) 
            {
                matrix[0, j] = array[array.GetLength(0)-1, j];
            }
            else 
            {
                if (i==(array.GetLength(0)-1)) {
                    matrix[array.GetLength(0)-1, j] = array[0, j];
                }
                else {
                    matrix[i, j]=array[i, j];
                    }
            }
        }   
    }  
    return matrix; 
}

Console.Clear();
int numberM = Prompt("Введите число строк матрицы: ");
int numberN = Prompt("Введите число столбцов: ");
int[,] matrix = NewArray(numberM, numberN);
PrintMatrix(matrix);
Console.WriteLine("Преобразованнй массив: ");
int[,] array  = ChangeArray(matrix);
PrintMatrix(array);
