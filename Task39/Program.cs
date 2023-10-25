// Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

int[] Reverse(int[] array)
{
    int first = array[0];
    int second = array[0];
    for (int i = 0; i < (array.Length / 2); i++)
    {
        first = array[array.Length -1 - i];
        second = array[i];
        array[array.Length -1 - i] = second;
        array[i] = first;
    }
    return array;

}

Console.Clear();
int length = Prompt("Введите длину массива:  ");
int[] arr = NewArray(length);
Console.Write("Массив: ");
PrintArray(arr);
int[] newarr = Reverse(arr);
Console.WriteLine();
Console.Write("Перевернутый массив: ");
PrintArray(newarr);
