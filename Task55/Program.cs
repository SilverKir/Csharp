// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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
            matrix[i, j]=array[j, i];          
        }      
    }  
    return matrix; 
}

Console.Clear();
int numberM = Prompt("Введите число строк матрицы: ");
int numberN = Prompt("Введите число столбцов: ");
if (numberM==numberN){
int[,] matrix = NewArray(numberM, numberN);
PrintMatrix(matrix);
Console.WriteLine("Преобразованнй массив: ");
int[,] array  = ChangeArray(matrix);
PrintMatrix(array);
}
else Console.WriteLine("Количество строк не равно количеству столбцов! Преобразование невозможно!");