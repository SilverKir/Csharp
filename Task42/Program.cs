// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int Double(int nomber)
{
    int result=8;
    int tmp =0;
    for (int i = nomber; i > 0; i/=2)   
     {
        tmp=i%2;
        result=result*10 + tmp;
    }

int result1=0;
for (int i = result; i >0; i/=10)

{ tmp=i%10;
result1=result1*10+tmp;  
}
    return result1/10;
}

Console.Clear();
int nomber = Prompt("Число:  ");

Console.Write($"Двоичное число: {Double(nomber)}");