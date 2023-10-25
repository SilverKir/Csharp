// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int [] NewFebonacci(int nomber)
{
    int[] array = new int[nomber];
    array[0] = 0;
    array[1] = 1;
    if (nomber > 2)
    {
        for (int i = 2; i < nomber; i++)
        {
            array[i] = array[i - 1] + array[i - 2];

        }
    }
    return array;
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        if (position == (count - 1))
        {
            Console.Write($"{col[position]}");
            position++;
        }
        else
        {
            Console.Write($"{col[position]}" + "\t");
            position++;
        }
    }
}

Console.Clear();
int nomber = Prompt("Введите требуемое количество чисел Фибоначчи: ");
int[] array =NewFebonacci(nomber);
PrintArray(array);