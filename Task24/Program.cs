//  Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// Функция, которая берет значение с консоли
int Rrompt (string  massage) 
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result= Convert.ToInt32(value);
    return result;
}
// Функция сложения числа от 1 до самой переменной А
int SummNumber(int A) {
    int result = 0;
    for (int i = 1; i <= A; i++)
    {
            result += i;    // result = result+i;
    }
    return result;
}
int A = Rrompt ("Введите число: ");
int summ = SummNumber(A);

Console.WriteLine(summ);
// У меня микрофон не работает
// 7 -> 28
// 4 -> 10
// 8 -> 36
