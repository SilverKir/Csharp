// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10
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
        array[i] = new Random().Next(1, 10);
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

int[] MultArray(int[] array)
{
    int lengthNew = 0;
    if (array.Length % 2 > 0)
    {
        lengthNew = (array.Length / 2) + 1;
        int[] arrayNew = new int[lengthNew];
        for (int i = 0; i < (lengthNew-1); i++)
        {
            arrayNew[i] = array[i] * array[(array.Length - 1 - i)];
        }
        arrayNew[lengthNew-1] = array[lengthNew-1];
        return arrayNew;
    }

    else
    {
        lengthNew = (array.Length / 2);
        int[] arrayNew = new int[lengthNew];
        for (int i = 0; i < lengthNew; i++)
        {
            arrayNew[i] = array[i] * array[(array.Length - 1 - i)];
        }
        return arrayNew;
    }
}


Console.Clear();
int temp = Rrompt("Введите длину массива: ");
Console.Write("Массив: ");
int[] array = NewArray(temp);
PrintArray(array);
Console.Write(" Измененный массив: ");
PrintArray(MultArray(array));
