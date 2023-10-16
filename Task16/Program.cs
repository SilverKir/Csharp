// нутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.

using System;

public class Answer
{
  static bool IsPalindrome(int number)
  {
    // Введите свое решение ниже
    if (number < 10000 || number > 99999)
    {
      Console.WriteLine("Число не пятизначное");
      return false;
    }
    string nomber = $"{number}";
    string test = $"{nomber[4]}" + $"{nomber[3]}" + $"{nomber[2]}" + $"{nomber[1]}" + $"{nomber[0]}";
    return nomber == test;


    //  Старое мое решение
    // if (number<10000 || number > 99999){
    //   Console.WriteLine ("Число не пятизначное");  
    //    return false;    
    // }
    // else {
    //   string nomber = $"{number}";
    //   string test = $"{nomber[4]}"+ $"{nomber[3]}"+$"{nomber[2]}"+$"{nomber[1]}"+$"{nomber[0]}";
    //    if (nomber==test) return true;
    // }
    // return false;  



  }
  // Эталонное решение
  // static bool IsPalindrome(int number){
  //     if (number < 10000 || number >= 100000){
  //         Console.WriteLine("Число не пятизначное");
  //         return false;
  //     }

  //     int reverse = 0;
  //     int temp = number;
  //     while (temp > 0){
  //         reverse = reverse * 10 + temp % 10;
  //         temp /= 10;
  //     }
  //     return reverse == number;

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args)
  {
    int number;

    if (args.Length >= 1)
    {
      number = int.Parse(args[0]);
    }
    else
    {
      // Здесь вы можете поменять значения для отправки кода на Выполнение
      number = 156751;
    }

    // Не удаляйте строки ниже
    bool result = IsPalindrome(number);
    System.Console.WriteLine($"{result}");
  }
}
