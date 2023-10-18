// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
        array[i] = new Random().Next(0, 30);
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

string ConsistNum(int[] array, int number)
{
for (int i = 0; i < array.Length; i++)
{
 if (array[i]==number) {
    return "да";
    break; 
 }   
}
return "нет";
}

Console.Clear();
int temp = Rrompt("Введите длину массива: ");
Console.Write("Массив: ");
int[] array = NewArray(temp);
PrintArray(array);
int number = Rrompt(" Введите число: ");
Console.WriteLine($"Наличие числа в массиве - {ConsistNum(array, number)}");

