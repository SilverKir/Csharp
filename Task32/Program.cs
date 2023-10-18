// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
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
        array[i] = new Random().Next(-9, 10);
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

int[] ReverseArray(int[] array)
{
int[] arrayNew = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    arrayNew[i]=array[i]*(-1);
}
return arrayNew;
}

Console.Clear();
int temp = Rrompt("Введите длину массива: ");
Console.Write("Первый массив: ");
int[] array = NewArray(temp);
PrintArray(array);
Console.Write(", преобразованный массив: ");
PrintArray(ReverseArray(array));