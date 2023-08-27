
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//  void CheckEven (int num)
// {
//     int ed = num / 10;
//     System.Console.WriteLine(ed % 10);
// }
// System.Console.WriteLine("Введите число ->");
// int num = Convert.ToInt32(Console.ReadLine());
// CheckEven(num);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// System.Console.WriteLine("Введите трехзначное число ->");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 999 && num <= 999999)
// {
//     System.Console.WriteLine($"Последняя цифра числа {num} -> {(num / 100) % 10}");
// }
// else if (num >= 100 && num <= 999)
// {
//     System.Console.WriteLine($"Последняя цифра числа {num} -> {num % 10}");
// }
// else if (num >= 0 && num <= 99)
// {
//     System.Console.WriteLine("Вы ввели не трехзначное число!");
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

class Program
{
static void Main(string[] args)
{
    System.Console.WriteLine ("Введите дату ->");
    int DayWee = int.Parse(Console.ReadLine());
    bool isWeek = WeeK(DayWee);
    if (isWeek)
    {
        System.Console.WriteLine("Да, это выходной");
    }
    else
    {
        System.Console.WriteLine("Нет, это рабочий день");
    }
    System.Console.ReadKey();
}
static bool WeeK(int DayWee)
  {
    if (DayWee == 6 || DayWee == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
  }
}
