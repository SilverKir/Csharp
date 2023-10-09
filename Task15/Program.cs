// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите цифру, обозначающую день недели:  ");
int userNumber1=Convert.ToInt32(Console.ReadLine());

    if (userNumber1==7 || userNumber1==6 ) {
        Console.WriteLine("да");
    }
    else {
        Console.WriteLine("нет");
    }