using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}" + "\t");
            }
              Console.WriteLine();
        }

    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] matrix = new int[n, m];
        int number = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = number;
                number += k;
            }
        }
        return matrix;

    }

    static void PrintListAvr(double[] list)
    {
        int count = list.Length;
        int position = 0;
        Console.WriteLine("The averages in columns are:");
        while (position < count)
        {
            if (position == (count - 1))
            {
                Console.Write($"{list[position]:0.00}");
                position++;
            }
            else
            {
                Console.Write($"{list[position]:0.00}" + "\t");
                position++;
            }
        }

    }

    static double[] FindAverageInColumns(int[,] matrix)
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


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}