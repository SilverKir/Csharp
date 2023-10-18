// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

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
        array[i] = new Random().Next(-20, 21);
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

int Summ3(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 > 0) summ+=array[i];
    }
    return summ;
}

Console.Clear();
int temp = Rrompt("Введите длину массива: ");
Console.Write("В массиве: ");
int[] array = NewArray(temp);
PrintArray(array);
Console.WriteLine($" сумма элементов, стоящих на нечетных позициях равна {Summ3(array)}");
