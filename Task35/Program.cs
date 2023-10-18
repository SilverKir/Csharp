// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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
        array[i] = new Random().Next(0, 150);
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

int CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (10 <= array[i] && array[i]<= 99) count++;
    }
    return count;
}


Console.Clear();
int temp = Rrompt("Введите длину массива: ");
Console.Write("Массив: ");
int[] array = NewArray(temp);
PrintArray(array);
Console.WriteLine($" Kоличество элементов массива, значения которых лежат в отрезке [10,99]: {CountNumber(array)}");

