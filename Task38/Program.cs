// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива.

int Rrompt(string massage)
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

int DiffMinMax(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    return max - min;
}

Console.Clear();
int temp = Rrompt("Введите длину массива: ");
Console.Write("В массиве: ");
int[] array = NewArray(temp);
PrintArray(array);
Console.WriteLine($" разница между максимальным и минимальным элементами массива равна {DiffMinMax(array)}");
