// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int FindMax(int[,] matrix) 
{
    int maximum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            if (maximum<=matrix[i, j])   maximum=matrix[i, j];
        }      
    }  
    return maximum; 
}


int[] FriqDict (int[,] matrix)
{
    int[] array = new int[FindMax(matrix)+1];
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            array[matrix[i,j]]++;
        }      
    }  
    return array; 
}

void PrintFriqArray(int[] array)
{
    for (int i=0; i < array.Length; i++)
    {
        if (array[i]>0) Console.WriteLine ($"{i} встречается {array[i]} раз");
    }
}

Console.Clear();
int numberM = Prompt("Введите число строк матрицы: ");
int numberN = Prompt("Введите число столбцов: ");
int[,] matrix = NewArray(numberM, numberN);
PrintMatrix(matrix);
Console.WriteLine ();
PrintFriqArray(FriqDict(matrix));