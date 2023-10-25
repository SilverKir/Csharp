// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] NewArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count)
    {
        if (position == (count - 1))
        {
            Console.Write($"{col[position]}");
            position++;
        }
        else
        {
            Console.Write($"{col[position]},");
            position++;
        }
    }
    Console.Write("]");
}

int[] CloneArray(int[] array)
{
    int length = array.Length;
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = array[i];
    }
    return arr;
}

Console.Clear();
int nomber= Prompt("Введите размер массива: ");
int[] array = NewArray(nomber);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(array);
Console.WriteLine();
int[] arr = CloneArray(array);
Console.WriteLine("Клонированный массив: ");
PrintArray(arr);