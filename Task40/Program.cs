// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

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
        array[i] = Prompt($"Введите значение {i} элемента массива: ");
    }
    return array;
}

bool Triangle(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            for (int k = 0; k < array.Length; k++)
            {
                if ((array[i] >= (array[j] + array[k])) && (j!=k))
                {
                    return (array[j] + array[k]) > array[i];
                    break;
                }
            }

        }

       
    }
 return 1==1;
}

Console.Clear();
// int length = Prompt("Введите размерность массива ");
int[] array = NewArray(3);
Console.WriteLine($"Соответствие неравенству треугольника: {Triangle(array)}");
