//////DZ///////
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество чисел:");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("Введите числа:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        CountPositiveNumbers(numbers);
    }

    static void CountPositiveNumbers(int[] numbers)
    {
        int positiveCount = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                positiveCount++;
            }
        }
        Console.WriteLine($"Количество чисел больше 0: {positiveCount}");
    }
}




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод значений b1, k1, b2 и k2
        Console.Write("Введите b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("Введите k1: ");
        double k1 = double.Parse(Console.ReadLine());

        Console.Write("Введите b2: ");
        double b2 = double.Parse(Console.ReadLine());

        Console.Write("Введите k2: ");
        double k2 = double.Parse(Console.ReadLine());

        // Находим координаты точки пересечения
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        // Выводим результат
        Console.WriteLine("Точка пересечения: ({0}; {1})", x, y);
    }
}