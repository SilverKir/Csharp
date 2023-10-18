// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

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
// Подсчет суммы положительных
int CountPositive(int[] array, int nomber, bool positive)
{
    int countPos = 0;
    int countNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= nomber) countPos += array[i];
        else countNeg += array[i];
    }
    if (positive == true) return countPos;
    else return countNeg;
}


Console.Clear();
int temp = Rrompt("Введите длину массива: ");
Console.Write("В массиве: ");
int[] array = NewArray(temp);
PrintArray(array);
Console.Write($" сумма положительных чисел равна {CountPositive(array, 0, true)}, сумма отрицательных чисел равна {CountPositive(array, 0, false)}");

