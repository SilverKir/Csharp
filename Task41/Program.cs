// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

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
        array[i] = Prompt($"Введите значение {i + 1} числа: ");
    }
    return array;
}

int PositiveArray(int[] array)
{

    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    return result;
}
Console.Clear();
int nomber = Prompt("Введите количество чисел:");
int[] array = NewArray(nomber);
Console.WriteLine($" Количество введенных положительных чисел равно: {PositiveArray(array)}");