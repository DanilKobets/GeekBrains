// git remote add origin 

/////////////////////
// Sem1
/////////////////////
//Tusk1

// System.Console.Write("Введите число, квадрат которого вы хотите увидеть ->");
// int num = Convert.ToInt32(Console.ReadLine());
// int quad = num * num;
// Console.WriteLine($"Квадрат числа {num} -> {num*num}");

//Task2 (1ое число квадрат 2)
// 5 25
// 25 5

// System.Console.Write("Введите перво число ->");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число ->");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad = num2 * num2;

// if(num1 == quad)
// {
//     System.Console.WriteLine($"Первое чилсло {num1} является квадратом второго числа {num2}");
// }
// else
// {
//     System.Console.WriteLine($"Первое чилсло {num2} не является квадратом второго числа {num1}");
// }


//Task3
//Написать программу которая принимает число N и выводит последовательность чисел от -N до N

// Task4

// System.Console.WriteLine("Введите число N ->");
// int n = Convert.ToInt32(Console.ReadLine());

// int current = n * (-1);

// while (current <= n)
// {
//     System.Console.Write(current + " ");
//     current ++;
// }

// Task5
// дается  3х значное число, нам нужно вывести последнюю цифру этого числа
//&& и то и то 
// || или
//3,6,9

// System.Console.WriteLine("Введите трехзначное число ->");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100 && num <= 999)
// {
//     System.Console.WriteLine($"Последняя цифра числа {num} -> {num % 10}");
// }
// else
// {
//     System.Console.WriteLine("Вы ввели не трехзначное число!");
// }


/////////////////////
// DZ Sem1
/////////////////////
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.Write("Введите перво число ->");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число ->");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     System.Console.WriteLine($"max -> {num1} min -> {num2}");
// }
// else if (num1 < num2)
// {
//     System.Console.WriteLine($"max -> {num2} min -> {num1}");
// }
// else
// {
//     System.Console.WriteLine("Числа равны");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// class Program {
//   static void Main(string[] args) {
//         Console.WriteLine("Введите три числа:");
//         int a = int.Parse(Console.ReadLine());
//         int b = int.Parse(Console.ReadLine());
//         int c = int.Parse(Console.ReadLine());

//         int max = a;

//         if (b > max) 
//         {
//             max = b;
//         }
//         if (c > max) {
//             max = c;
//         }

//         Console.WriteLine("Максимальное число: " + max);
//     }
// }



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите число: ");
//         int number = int.Parse(Console.ReadLine());

//         if (number % 2 == 0)
//         {
//             Console.WriteLine("Число четное");
//         }
//         else
//         {
//             Console.WriteLine("Число нечетное");
//         }
//     }
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите N: ");
//         int n = int.Parse(Console.ReadLine());

//         Console.WriteLine("Четные числа от 1 до " + n + ":");

//         for (int i = 2; i <= n; i += 2)
//         {
//             Console.Write(i + " ");
//         }

//         Console.ReadLine();
//     }
// }



/////////////////////
// Sem2
/////////////////////
/////////////Questions1//////////////
// int FindSum(int num1, int num2);
// {
//     int sum = num1 + num2;
//     return sum;
// }

// int x = 5;
// int y = 6;

// // int result = FindSum (x, y);
// System.Console.WriteLine(result);


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно
/////////////Questions2//////////////

// void CheckEven (int num1, int num2)
// {
//     if(num1 % 2 == 0)
//     {
//         System.Console.WriteLine($"число {num2} кратно {num1}");
//     }
//     else
//     {
//         System.Console.WriteLine($"число {num2} не кратно {num1} остаток от деления -> {num1 % num2}");
//     }
// }

// System.Console.WriteLine("Введите первое число ->");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число ->");
// int num2 = Convert.ToInt32(Console.ReadLine());

// CheckEven (num1, num2);



/////////////Questions3//////////////

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// bool CheckEven(int num)
// {
//     if(num % 7 == 0 && num % 23 == 0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// System.Console.WriteLine("Введите число ->");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(CheckEven(num));

/////////////Questions4//////////////
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого


// void ques2 (int num1, int num2)
// {
//     if (num2 == num1 * num1)
//     {
//         Console.WriteLine($"Число {num2} является квадратом числа {num1}");
//     }
//     else if (num1 == num2 * num2)
//     {
//         Console.WriteLine($"Число {num1} является квадратом числа {num2}");
//     }
//     else
//     {
//         Console.WriteLine("НЕ является квадратом");
//     }
// }

//     Console.Write("Введите первое число: ");
//     int num1 = int.Parse(Console.ReadLine());
//     Console.Write("Введите второе число: ");
//     int num2 = int.Parse(Console.ReadLine());
//     ques2(num1, num2);



/////////////Questions5//////////////
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// void CheckEven (int num)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     System.Console.WriteLine(ed + sot * 10);
// }


// System.Console.WriteLine("Введите число ->");
// int num = Convert.ToInt32(Console.ReadLine());
// CheckEven(num);




/////////////////////
// DZ sem2
/////////////////////

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

// class Program
// {
// static void Main(string[] args)
// {
//     System.Console.WriteLine ("Введите дату ->");
//     int DayWee = int.Parse(Console.ReadLine());
//     bool isWeek = WeeK(DayWee);
//     if (isWeek)
//     {
//         System.Console.WriteLine("Да, это выходной");
//     }
//     else
//     {
//         System.Console.WriteLine("Нет, это рабочий день");
//     }
//     System.Console.ReadKey();
// }
// static bool WeeK(int DayWee)
//   {
//     if (DayWee == 6 || DayWee == 7)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
//   }
// }


/////////////////OVERRIDE
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// System.Console.Write("Введите трехзначное число ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num >= 100 && num < 1000  num <= -100 && num > -1000)
// {
//     System.Console.WriteLine($"Первая цифра числа {num} -> {num / 100}");
//     System.Console.WriteLine($"Вторая цифра числа {num} -> {(num / 10) % 10}");
//     System.Console.WriteLine($"Третья цифра числа {num} -> {num % 10}"); 
// }
// else
// {
//     System.Console.WriteLine("ОШИБКА!!! Число не является трехзначным!");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// System.Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 100 && num >= 0  num > -100 && num <= 0)
// {
//     System.Console.WriteLine("Третьей цифры НЕТ!");
// }
// if (num >= 100 && num <= 999  num <= -100 && num >= -999)
// {
//     System.Console.WriteLine($"Третья цифра числа {num} -> {num % 10}");
// }
// int n = (num);
// while (n > 999  n < -999)
// {
// {    
//     n = n / 10;
// }
//     if (n <= 999 && n >= -999)
//     {
//         System.Console.WriteLine($"Третья цифра числа {num} -> {n % 10}");
//     }
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.


// class Program
// {
// static void Main(string[] args)
// {
//     System.Console.WriteLine ("Введите дату ->");
//     int DayWee = int.Parse(Console.ReadLine());
//     bool isWeek = WeeK(DayWee);
//     if (isWeek)
//     {
//         System.Console.WriteLine("Да, это выходной");
//     }
//     else
//     {
//         System.Console.WriteLine("Нет, это рабочий день");
//     }
//     System.Console.ReadKey();
// }
// static bool WeeK(int DayWee)
//   {
//     if (DayWee == 6 || DayWee == 7)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
//   }
// }

///////////////////////////////////////////
///////////////////////////////////////////
///////////////////////////////////////////
//////////////////SEM3////////////////////

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Palindrom(int number)
// {
//     if (number >= 0 && number <= 999999)
//     {
//         int num1 = number % 10;
//         int num2 = (number / 10000) % 10;
//         if (num1 == num2)
//             {
//             int num3 = (number / 10 ) % 10;
//             int num4 = (number / 1000) % 10;
//             if (num3 == num4)
//                 {
//                 System.Console.WriteLine($"Число полидром{number}");
//                 }
//                     else 
//                         {
//                         System.Console.WriteLine($"Число полидром {number}");
//                         }
//             }
//             else
//             {
//                 System.Console.WriteLine($"{number} не явзяется полидромом");
//             }
//     }
//     else
//     {
//         System.Console.WriteLine($"неверное число");
//     }
// }

// System.Console.Write("Введите пятизначное число -> ");
// int number = Convert.ToInt32(Console.ReadLine());
// Palindrom(number);


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// double FindDistance (double xa, double ya, double ca, double xb, double yb, double cb)
// {
//     return Math.Round((Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(ca-cb, 2))), 2);
// }
// System.Console.WriteLine("input X coordinate point A : ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input Y coordinate point A : ");
// double ya = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input C coordinate point A : ");
// double ca = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input X coordinate point B : ");
// double xb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input Y coordinate point B : ");
// double yb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input C coordinate point A : ");
// double cb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"Distance between point A and B and C ->{FindDistance(xa,ya,ca,xb,yb,cb)}");



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Quad (int x)
// {
//     int count = 1;
//     while (count <= x)
//     {
//         System.Console.WriteLine($"{count} -> {Math.Pow(count, 3)}");
//         count++;
//     }
// }
// System.Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());

// Quad(x);

///////////////////////////////////
//SEMENAR 3
///Q1
///Задание 1 Напишите программа которая принимает на вход координаты точки (Х и Y) причём Х не равза 0 и Y =не 0
//Выдаёт номер четверти плоскости в которой находится эта точка

// int FaindQuad (int x, int y)
// {
//     if (x > 0 && y > 0 )
//     {
//         return 1;
//     }
//         if (x < 0 && y > 0 )
//     {
//         return 2;
//     }
//         if (x < 0 && y < 0 )
//     {
//         return 3;
//     }
//         if (x > 0 && y < 0 )
//     {
//         return 4;
//     }
//     return 0;
// }

// System.Console.WriteLine("input x coordinate: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input y coordinate: ");
// int y = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Pont with x coordinate ({x}) and Y coordinate ({y}) {FaindQuad(x,y)} quart");


///Q2

//Задача 3. Напишите программу которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// A (3,6); B (2,1) -> 5.09
// A (7,-5); B (1,-1) -> 7.21

// double FindDistance (double xa, double ya, double xb, double yb)
// {
//     return Math.Round((Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2))), 2);
// }
// System.Console.WriteLine("input X coordinate point A : ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input Y coordinate point A : ");
// double ya = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input X coordinate point B : ");
// double xb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input Y coordinate point B : ");
// double yb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"Distance between point A and B ->{FindDistance(xa,ya,xb,yb)}");


///Q3
//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
///

// void Diapozone(int x)
// {
//     if (x > 0 && x < 5)
//     {
//         if( x == 1)
//         {
//             System.Console.WriteLine("x + and Y +");
//         }
//         if( x == 2)
//         {
//             System.Console.WriteLine("x - and Y +");
//         }
//         if( x == 3)
//         {
//             System.Console.WriteLine("x - and Y -");
//         }
//         if( x == 4)
//         {
//             System.Console.WriteLine("x + and Y -");
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("Ввели не существующую четверть");
//     }
// }
// System.Console.WriteLine("Введите четверть ->");
// int x = Convert.ToInt32(Console.ReadLine());
// Diapozone(x);




///Q4
//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N
///

// void Quad (int x)
// {
//     int count = 0;
//     while (count <= x)
//     {
//         System.Console.WriteLine($"{count} -> {Math.Pow(count, 2)}");
//         count++;
//     }
// }
// System.Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());

// Quad(x);


//////24.06.2023

///////////////////////////////////////////
///////////////////////////////////////////
///////////////////////////////////////////
//////////////////SEM4////////////////////

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// bool ValidPower(int b)
// {
//     if (b < 0)
//     {
//         System.Console.WriteLine("ОШИБКА!!! Число B не должно быть < 0");
//         return false;
//     }
//     return true;
// }

// int FindPower(int a, int b)
// {
//     int power = 1;
//     for (int i = 0; i < b; i++)
//     {
//         power *= a;
//     }
//     return power;
// }
// System.Console.WriteLine("Input number A -> ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number B -> ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (ValidPower(b))
// {
//     System.Console.WriteLine($"{a} in power {b} is -> {FindPower(a, b)}");
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// void Create(int number)
// {
//     if(number >= 0 && number <= 99999)
//     {
//         int num1 = (number / 10000) % 10;
//         int num2 = (number / 1000) % 10;
//         int num3 = (number / 100) % 10;
//         int num4 = (number / 10) % 10;
//         int num5 = (number % 10);
//         number = num1 + num2 + num3 + num4 + num5;
//         System.Console.WriteLine($"{num1} + {num2} + {num3} + {num4} + {num5} = {number}");
//     }
// }
// System.Console.Write("Введите пятизначное число -> ");
// int number = Convert.ToInt32(Console.ReadLine());
// Create(number);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal elements of array: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal elements of array: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// PrintArray(CreateRandomArray(size, minValue, maxValue));


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Задача 1.  Напишите программу которая принимает на вход число 4 и выдет сумму чисел от 1 до 4
//7 -> 28
//4 -> 10
//8 -> 36

// int FindSum (int a)
// {
//     int sum = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// System.Console.WriteLine("input number: " );
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Sum of numbers at 1 from A -> {FindSum(a)}");

/////////
/// Напишите программу которая выводит масив из 8 элементов, заполненный нулями и единицами в Случайно порядке.
// (1,0,1,1,0,1,0,0)

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.WriteLine(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minValue:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maxValue:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(size, minValue, maxValue));


////////
//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36
// int FindNumber(int a)
// {
//     int current = 0;
//     for (int i = 1; a > 0; i++)
//     {
//         a = a/10;
//         current = i;
//     }
//         return current;
// }
// System.Console.WriteLine("Введите число -> ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{a} -> {FindNumber(a)}");



//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

// int FindFatrorial(int a)
// {
//     int f = 1;
//     for (int i = 1; i <=a; i++)
//     {
//         f = f * i;

//     }
//     return f;
// }

// System.Console.WriteLine("Введите число ->");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{a} -> {FindFatrorial(a)}");

//////////////////
///lekcia

///fibonacCI
// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }
// /////////////
// ///fACTORIAL рЕКУРСИЯ
// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }
//////
//////////Палец вверх

// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };
// ////
// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }
// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }
// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);


///////////

///SEM5
//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     } 
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// void PosnegSum(int[] array)
// {
//     int sumPos = 0;
//     int SumNeg = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) sumPos += array[i];
//         else SumNeg += array[i];
//     }
//     System.Console.WriteLine($"Сумма положительных чисел ровна -> {sumPos} Сумма отрицательных чисел ровна -> {SumNeg}");
// }
// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);
// PosnegSum(myArray);

////////////////////////////////////////////////


//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]
// int[] IvertArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }




// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);


// PrintArray(myArray);

// myArray = InvertArray(myArray);
// PrintArray(myArray);


///

//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// bool TrueNumber (int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num) return true;
//     }
//     return false;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());


// int [] array1 = CreateArray(size);

// PrintArray(array1);

// System.Console.WriteLine(TrueNumber(array1, num));


//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     } 
//     return array;
// }

// int TrueDigits(int [] array)
// {
//     int current = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//         {
//             current ++;
//         }
//     }
//     return current;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [] array1 = CreateRandomArray(size, minValue, maxValue);
// PrintArray(array1);
// System.Console.WriteLine($"В этом массиве количество элементов значения которых лежат в отрезке [10,99] = {TrueDigits(array1)}");



//////////////////
///////DZ/////////
//////////////////

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Input 4 three-digit numbers:");
//         int size1 = Convert.ToInt32(Console.ReadLine());
//         int size2 = Convert.ToInt32(Console.ReadLine());
//         int size3 = Convert.ToInt32(Console.ReadLine());
//         int size4 = Convert.ToInt32(Console.ReadLine());

//         int[] myArray = CreateRandomArray(size1, size2, size3, size4);
//         PrintArray(myArray);

//         int evenNumbersCount = CountEvenNumbers(myArray);
//         Console.WriteLine($"The number of even numbers in the array is {evenNumbersCount}");
//     }

//     static int[] CreateRandomArray(int size1, int size2, int size3, int size4)
//     {
//         int[] array = new int[size1 * size2 * size3 * size4];

//         Random random = new Random();
//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = random.Next(100, 1000);
//         }

//         return array;
//     }

//     static void PrintArray(int[] array)
//     {
//         for (int i = 0; i < array.Length; i++)
//         {
//             Console.Write(array[i] + " ");
//         }
//         Console.WriteLine();
//     }

//     static int CountEvenNumbers(int[] array)
//     {
//         int evenNumbersCount = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i] % 2 == 0)
//             {
//                 evenNumbersCount++;
//             }
//         }
//         return evenNumbersCount;
//     }
// }



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] arr = new int[4];
//         Random rand = new Random();

//         // Заполняем массив случайными числами
//         for (int i = 0; i < arr.Length; i++)
//             arr[i] = rand.Next(-100, 100);

//         // Печатаем массив на консоль
//         System.Console.WriteLine("Массив: ");
//         foreach (int x in arr)
//             System.Console.Write(x + " ");

//         System.Console.WriteLine();

//         // Находим сумму элементов на нечетных позициях
//         int sum = 0;
//         for (int i = 1; i < arr.Length; i += 2)
//             sum += arr[i];

//         System.Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
//     }
// }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int z = 0; z < numbers.Length; z++)
// {
//     if (numbers[z] > max)
//         {
//             max = numbers[z];
//         }
//     if (numbers[z] < min)
//         {
//             min = numbers[z];
//         }
// }

// Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }


///---///


//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// int sum = 0;

// for (int z = 0; z < numbers.Length; z+=2)
//     sum = sum + numbers[z];

//     Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,100);
//         }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }


// //Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// //максимальным и минимальным элементов массива.
// //[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int z = 0; z < numbers.Length; z++)
// {
//     if (numbers[z] > max)
//         {
//             max = numbers[z];
//         }
//     if (numbers[z] < min)
//         {
//             min = numbers[z];
//         }
// }

// Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }


///Sem6
//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     } 
//     return array;
// }

// void PrintArray(int[] array) // 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int[] ReverseArray(int[] array) // Перевород массива
// {
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length -i -1] = temp;
//     }
//     return array;
// }
// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);
// myArray = ReverseArray(myArray);
// PrintArray(myArray);


///////Оисать метод который переводит число в двоичную систему исчисления
// 123
// 61 -> 1
// 30 -> 1
// 15 -> 0
// 7 -> 1
// 3 -> 1
// 1 -> 1
// string DecimalToBinary(int num)
// {
//     string result = string.Empty;
//     while(num > 0)
//     {
//         result = num % 2 + result ;
//         num = num / 2;
//     }
//     return result;
// }


// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Number {num} in binary system -> {DecimalToBinary(num)}");


//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]


// int [] Fibanacci( int size , int num1, int num2)
// {
//     int [] array = new int [size];
//     array[0] = num1;
//     array[1] = num2;
//     for (int i=2 ; i< array.Length; i++)
//     {
//       array [i] = array[(i-1)]+array[(i-2)];
//     }
  
//    return array;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input num1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input num2: ");
//  int num2 = Convert.ToInt32(Console.ReadLine());  
//  PrintArray(Fibanacci (10,num1, num2));

//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон

// bool CheckTriangle (int a, int b, int c)
// {
//     if (a < b + c && b < a + c && c < a + b) return true;
//     else return false;
// }
// if(CheckTriangle(4, 5, 10)) System.Console.WriteLine("Треугольник может");
// else System.Console.WriteLine("Треугольник не может");


//////DZ///////
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите количество чисел:");
//         int n = int.Parse(Console.ReadLine());

//         int[] numbers = new int[n];

//         Console.WriteLine("Введите числа:");
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = int.Parse(Console.ReadLine());
//         }

//         CountPositiveNumbers(numbers);
//     }

//     static void CountPositiveNumbers(int[] numbers)
//     {
//         int positiveCount = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] > 0)
//             {
//                 positiveCount++;
//             }
//         }
//         Console.WriteLine($"Количество чисел больше 0: {positiveCount}");
//     }
// }




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Ввод значений b1, k1, b2 и k2
//         Console.Write("Введите b1: ");
//         double b1 = double.Parse(Console.ReadLine());

//         Console.Write("Введите k1: ");
//         double k1 = double.Parse(Console.ReadLine());

//         Console.Write("Введите b2: ");
//         double b2 = double.Parse(Console.ReadLine());

//         Console.Write("Введите k2: ");
//         double k2 = double.Parse(Console.ReadLine());

//         // Находим координаты точки пересечения
//         double x = (b2 - b1) / (k1 - k2);
//         double y = k1 * x + b1;
//         // Выводим результат
//         Console.WriteLine("Точка пересечения: ({0}; {1})", x, y);
//     }
// }


///////////////////////////////////////////////////SEM 7
// //Задача 4. задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Print2DArray(Create2DArray(rows, columns, minValue, maxValue));

///***///
//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// 1 2 3
// 4 5 6
// 7 8 9

// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int [,] HandInput(int rows, int cols);
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++);
//     {
//         for (int j = 0; j < cols; j++);
//         {
//             array [i,j] = Convert.ToInt32(Console.ReadLine());
//         }
//     }
//     return array;
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine("Input minimal value of array element: ");
// // int minValue = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine("Input maximal value of array element: ");
// // int maxValue = Convert.ToInt32(Console.ReadLine());

// //int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(HandInput(rows, columns));
// System.Console.WriteLine(FindSumOFMainDiagonal(HandInput(rows, columns)));
// //System.Console.WriteLine(FindSumOFMainDiagonal(myArray));
// //Print2DArray(Create2DArray(rows, columns, minValue, maxValue));


// //Задача 4. задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(Create2DArray(rows, columns, minValue, maxValue));
// System.Console.WriteLine(FindSumOfMainDiagonal(myArray));

///////
// int FindSumOFMainDiagonal (int [,] array);
// {   
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++);
//         {
//             if ( i == j );
//             {
//                 sum+= array [i,j];
//             }
//         }
//     }
//     return sum;
// }

//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:

//1 4 7 2
//5 **81  ** 2 **9**
//8 4 2 4

//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] EvenSum(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//                 array[i, j] = Convert.ToInt32(Math.Pow(array[i, j], 2));
//         }
//     }
//     return array;
// }


// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(array);

// Print2DArray(EvenSum(array));

//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.


// int[,] Create2DArray (int rows, int columns)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = i+j;
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Print2DArray(Create2DArray(rows, columns));

//////////
////DZ////
//////////

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void Create2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100,100)) / 10;
//         }
//     }
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         System.Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine(" ]");
//     }
//     System.Console.WriteLine(" ");
// }

// System.Console.WriteLine("Кол-во строк: ");
// int line = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[line, columns];
// Create2DArray(numbers);
// Print2DArray(numbers);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// void Create2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("]");
//     }
//     Console.WriteLine();
// }

// void Check(double[,] array, int i, int j)
// {
//     if (i < array.GetLength(0) && j < array.GetLength(1))
//     {
//         Console.WriteLine(array[i, j]);
//     }
//     else
//     {
//         Console.WriteLine($"{i} ая строка и {j} столбца -> нет");
//     }
// }

// Console.WriteLine("Кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] numbers = new double[rows, columns];
// Create2DArray(numbers);
// Print2DArray(numbers);

// Console.WriteLine("Введите номер строки и столбца для проверки:");
// Console.WriteLine("Номер строки: ");
// int rowIndex = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Номер столбца: ");
// int columnIndex = Convert.ToInt32(Console.ReadLine());

// Check(numbers, rowIndex, columnIndex);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void Create2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("]");
//     }
//     Console.WriteLine();
// }

// void Check(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum += array[i, j];
//     }
//     Console.Write($"{ sum / array.GetLength(0)} ");
//     }   
// }


// Console.WriteLine("Кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] numbers = new double[rows, columns];
// Create2DArray(numbers);
// Print2DArray(numbers);
// Check(numbers);

////////////////
//////SEM8/////
///////////////
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// void SortToLower(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }
// System.Console.WriteLine("Кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Кол-во колонок: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Минимальный элемент: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Максимальный элемент: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// SortToLower(myArray);
// Print2DArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// static int Check(int [,] array)
//     {
//         int minSum = int.MaxValue;
//         int minSumRow = -1;

//         for (int i = 0; i < array.GetLength(0); i++) // перебор строк
//         {
//             int sum = 0;

//             for (int j = 0; j < array.GetLength(1); j++) // перебор элементов в строке
//             {
//                 sum += array[i, j];
//             }

//             if (sum < minSum)
//             {
//                 minSum = sum;
//                 minSumRow = i +1;
//             }
//         }

//         return minSumRow;
//     }
// System.Console.WriteLine("Кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Кол-во колонок: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Минимальный элемент: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Максимальный элемент: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// int minSumRow = Check(myArray);
// Console.WriteLine("Наименьшая сумма элементов в строке: " + minSumRow + " строка");
// Check(myArray);
// Print2DArray(myArray);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// /////////////////////////////////
// void Matrix2DArray(int[,] myArray, int[,] myArray1, int[,] myArrayfin)
// {
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < myArray1.GetLength(0); k++)
//             {
//                 sum += myArray[i, k] * myArray1[k, j];
//             }
//             myArrayfin[i, j] = sum;
//         }
//     }
// }
// ////////////////////
// System.Console.WriteLine("Кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Кол-во колонок: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Минимальный элемент: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Максимальный элемент: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// int[,] myArray1 = Create2DArray(columns, rows, minValue, maxValue);
// int[,] myArrayfin = new int[myArray.GetLength(0), myArray1.GetLength(1)];

// Print2DArray(myArray);
// Print2DArray(myArray1);

// Matrix2DArray(myArray, myArray1, myArrayfin);
// Print2DArray(myArrayfin);





// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] array3D = new int[2, 2, 2];
// FillArray(array3D);
// PrintIndex(array3D);


// // Функция вывода индекса элементов 3D массива
// void PrintIndex(int[,,] arr)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// // Функция заполнения 3D массива не повторяющимеся числами
// void FillArray(int[,,] arr)
// {
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


﻿// Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

// int n = 4;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//   sqareMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// WriteArray(sqareMatrix);

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }

//////////////////////////////

//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2
//////////////////////////////

// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] ChangeRows(int[,] array, int row1, int row2)
// {   
//     if ( row1 >= array.GetLength (0) || row2 >= array.GetLength(0))
//     {
//         System.Console.WriteLine("Указанные строки выходят за пределы массива!");
//         return array;
//     }
//     else
//         for (int j = 0;  j < array.GetLength(1); j++)
//         {
//             int temp = array[row1,j];
//             array[row1,j] = array[row2, j];
//             array[row2,j] = temp;
//         }
//     return array;
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input number of row1 to change ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of row2 to change ");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Print2DArray(ChangeRows(myArray, row1, row2)); //зад 1
// Print2DArray(RowsTOColumns(myArray)); // зад 2

////////////

//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7

/////////////////////////

// int[,] RowsTOColumns(int[,] array)
// {
//     if(array.GetLength(0) != array.GetLength(1))
//     {
//         System.Console.WriteLine("Не квадратный массив!");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = i+1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array [j, i];
//                 array [j, i] = temp;
//             }
//         }
//     }
//     return array;
// }

////////////////////

// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] MinValue(int[,] array)
// {
//     int minI = 0; //строка
//     int minJ = 0; // столбец
//     int minNum = array[0, 0];
//     for(int i = 0; i < array.GetLength(0); i++)// array.GetLength(
//         {
//             for(int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (array[i,j] <= minNum)
//                 minNum = array [i,j];
//                 minI = i;
//                 minJ = j;

//             }
//         }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         array[i, minJ] = 0;       
//     }
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[minI,j] = 0; 
//     }
//     return array;
// }



// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Print2DArray(MinValue(myArray));

/////////Не мой
// int[,] MinValue(int[,] array)
// {
//     int minI = 0;
//     int minJ = 0;
//     int minnum = array[0, 0];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] <= minnum)
//             {
//                 minnum = array[i, j];
//             minI = i;
//             minJ = j;
//             }
//         }
//     }

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         array[i, minJ] = 0;

//     }

//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[minI, j] = 0;
//     }

//     return array;
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Print2DArray(MinValue(myArray));

//////////////////////////
//////////SEM9////////////
//////////////////////////

// git remote add origin https://github.com/DanilKobets/HomeWORK.git

/////////////////////
// Sem1
/////////////////////
//Tusk1

// System.Console.Write("Введите число, квадрат которого вы хотите увидеть ->");
// int num = Convert.ToInt32(Console.ReadLine());
// int quad = num * num;
// Console.WriteLine($"Квадрат числа {num} -> {num*num}");

//Task2 (1ое число квадрат 2)
// 5 25
// 25 5

// System.Console.Write("Введите перво число ->");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число ->");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad = num2 * num2;

// if(num1 == quad)
// {
//     System.Console.WriteLine($"Первое чилсло {num1} является квадратом второго числа {num2}");
// }
// else
// {
//     System.Console.WriteLine($"Первое чилсло {num2} не является квадратом второго числа {num1}");
// }


//Task3
//Написать программу которая принимает число N и выводит последовательность чисел от -N до N

// Task4

// System.Console.WriteLine("Введите число N ->");
// int n = Convert.ToInt32(Console.ReadLine());

// int current = n * (-1);

// while (current <= n)
// {
//     System.Console.Write(current + " ");
//     current ++;
// }

// Task5
// дается  3х значное число, нам нужно вывести последнюю цифру этого числа
//&& и то и то 
// || или
//3,6,9

// System.Console.WriteLine("Введите трехзначное число ->");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100 && num <= 999)
// {
//     System.Console.WriteLine($"Последняя цифра числа {num} -> {num % 10}");
// }
// else
// {
//     System.Console.WriteLine("Вы ввели не трехзначное число!");
// }


/////////////////////
// DZ Sem1
/////////////////////
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.Write("Введите перво число ->");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число ->");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     System.Console.WriteLine($"max -> {num1} min -> {num2}");
// }
// else if (num1 < num2)
// {
//     System.Console.WriteLine($"max -> {num2} min -> {num1}");
// }
// else
// {
//     System.Console.WriteLine("Числа равны");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// class Program {
//   static void Main(string[] args) {
//         Console.WriteLine("Введите три числа:");
//         int a = int.Parse(Console.ReadLine());
//         int b = int.Parse(Console.ReadLine());
//         int c = int.Parse(Console.ReadLine());

//         int max = a;

//         if (b > max) 
//         {
//             max = b;
//         }
//         if (c > max) {
//             max = c;
//         }

//         Console.WriteLine("Максимальное число: " + max);
//     }
// }



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите число: ");
//         int number = int.Parse(Console.ReadLine());

//         if (number % 2 == 0)
//         {
//             Console.WriteLine("Число четное");
//         }
//         else
//         {
//             Console.WriteLine("Число нечетное");
//         }
//     }
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите N: ");
//         int n = int.Parse(Console.ReadLine());

//         Console.WriteLine("Четные числа от 1 до " + n + ":");

//         for (int i = 2; i <= n; i += 2)
//         {
//             Console.Write(i + " ");
//         }

//         Console.ReadLine();
//     }
// }



/////////////////////
// Sem2
/////////////////////
/////////////Questions1//////////////
// int FindSum(int num1, int num2);
// {
//     int sum = num1 + num2;
//     return sum;
// }

// int x = 5;
// int y = 6;

// // int result = FindSum (x, y);
// System.Console.WriteLine(result);


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно
/////////////Questions2//////////////

// void CheckEven (int num1, int num2)
// {
//     if(num1 % 2 == 0)
//     {
//         System.Console.WriteLine($"число {num2} кратно {num1}");
//     }
//     else
//     {
//         System.Console.WriteLine($"число {num2} не кратно {num1} остаток от деления -> {num1 % num2}");
//     }
// }

// System.Console.WriteLine("Введите первое число ->");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число ->");
// int num2 = Convert.ToInt32(Console.ReadLine());

// CheckEven (num1, num2);



/////////////Questions3//////////////

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// bool CheckEven(int num)
// {
//     if(num % 7 == 0 && num % 23 == 0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// System.Console.WriteLine("Введите число ->");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(CheckEven(num));

/////////////Questions4//////////////
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого


// void ques2 (int num1, int num2)
// {
//     if (num2 == num1 * num1)
//     {
//         Console.WriteLine($"Число {num2} является квадратом числа {num1}");
//     }
//     else if (num1 == num2 * num2)
//     {
//         Console.WriteLine($"Число {num1} является квадратом числа {num2}");
//     }
//     else
//     {
//         Console.WriteLine("НЕ является квадратом");
//     }
// }

//     Console.Write("Введите первое число: ");
//     int num1 = int.Parse(Console.ReadLine());
//     Console.Write("Введите второе число: ");
//     int num2 = int.Parse(Console.ReadLine());
//     ques2(num1, num2);



/////////////Questions5//////////////
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// void CheckEven (int num)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     System.Console.WriteLine(ed + sot * 10);
// }


// System.Console.WriteLine("Введите число ->");
// int num = Convert.ToInt32(Console.ReadLine());
// CheckEven(num);




/////////////////////
// DZ sem2
/////////////////////

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

// class Program
// {
// static void Main(string[] args)
// {
//     System.Console.WriteLine ("Введите дату ->");
//     int DayWee = int.Parse(Console.ReadLine());
//     bool isWeek = WeeK(DayWee);
//     if (isWeek)
//     {
//         System.Console.WriteLine("Да, это выходной");
//     }
//     else
//     {
//         System.Console.WriteLine("Нет, это рабочий день");
//     }
//     System.Console.ReadKey();
// }
// static bool WeeK(int DayWee)
//   {
//     if (DayWee == 6 || DayWee == 7)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
//   }
// }


/////////////////OVERRIDE
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// System.Console.Write("Введите трехзначное число ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num >= 100 && num < 1000  num <= -100 && num > -1000)
// {
//     System.Console.WriteLine($"Первая цифра числа {num} -> {num / 100}");
//     System.Console.WriteLine($"Вторая цифра числа {num} -> {(num / 10) % 10}");
//     System.Console.WriteLine($"Третья цифра числа {num} -> {num % 10}"); 
// }
// else
// {
//     System.Console.WriteLine("ОШИБКА!!! Число не является трехзначным!");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// System.Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 100 && num >= 0  num > -100 && num <= 0)
// {
//     System.Console.WriteLine("Третьей цифры НЕТ!");
// }
// if (num >= 100 && num <= 999  num <= -100 && num >= -999)
// {
//     System.Console.WriteLine($"Третья цифра числа {num} -> {num % 10}");
// }
// int n = (num);
// while (n > 999  n < -999)
// {
// {    
//     n = n / 10;
// }
//     if (n <= 999 && n >= -999)
//     {
//         System.Console.WriteLine($"Третья цифра числа {num} -> {n % 10}");
//     }
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.


// class Program
// {
// static void Main(string[] args)
// {
//     System.Console.WriteLine ("Введите дату ->");
//     int DayWee = int.Parse(Console.ReadLine());
//     bool isWeek = WeeK(DayWee);
//     if (isWeek)
//     {
//         System.Console.WriteLine("Да, это выходной");
//     }
//     else
//     {
//         System.Console.WriteLine("Нет, это рабочий день");
//     }
//     System.Console.ReadKey();
// }
// static bool WeeK(int DayWee)
//   {
//     if (DayWee == 6 || DayWee == 7)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
//   }
// }

///////////////////////////////////////////
///////////////////////////////////////////
///////////////////////////////////////////
//////////////////SEM3////////////////////

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Palindrom(int number)
// {
//     if (number >= 0 && number <= 999999)
//     {
//         int num1 = number % 10;
//         int num2 = (number / 10000) % 10;
//         if (num1 == num2)
//             {
//             int num3 = (number / 10 ) % 10;
//             int num4 = (number / 1000) % 10;
//             if (num3 == num4)
//                 {
//                 System.Console.WriteLine($"Число полидром{number}");
//                 }
//                     else 
//                         {
//                         System.Console.WriteLine($"Число полидром {number}");
//                         }
//             }
//             else
//             {
//                 System.Console.WriteLine($"{number} не явзяется полидромом");
//             }
//     }
//     else
//     {
//         System.Console.WriteLine($"неверное число");
//     }
// }

// System.Console.Write("Введите пятизначное число -> ");
// int number = Convert.ToInt32(Console.ReadLine());
// Palindrom(number);


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// double FindDistance (double xa, double ya, double ca, double xb, double yb, double cb)
// {
//     return Math.Round((Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(ca-cb, 2))), 2);
// }
// System.Console.WriteLine("input X coordinate point A : ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input Y coordinate point A : ");
// double ya = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input C coordinate point A : ");
// double ca = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input X coordinate point B : ");
// double xb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input Y coordinate point B : ");
// double yb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input C coordinate point A : ");
// double cb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"Distance between point A and B and C ->{FindDistance(xa,ya,ca,xb,yb,cb)}");



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Quad (int x)
// {
//     int count = 1;
//     while (count <= x)
//     {
//         System.Console.WriteLine($"{count} -> {Math.Pow(count, 3)}");
//         count++;
//     }
// }
// System.Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());

// Quad(x);

///////////////////////////////////
//SEMENAR 3
///Q1
///Задание 1 Напишите программа которая принимает на вход координаты точки (Х и Y) причём Х не равза 0 и Y =не 0
//Выдаёт номер четверти плоскости в которой находится эта точка

// int FaindQuad (int x, int y)
// {
//     if (x > 0 && y > 0 )
//     {
//         return 1;
//     }
//         if (x < 0 && y > 0 )
//     {
//         return 2;
//     }
//         if (x < 0 && y < 0 )
//     {
//         return 3;
//     }
//         if (x > 0 && y < 0 )
//     {
//         return 4;
//     }
//     return 0;
// }

// System.Console.WriteLine("input x coordinate: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input y coordinate: ");
// int y = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Pont with x coordinate ({x}) and Y coordinate ({y}) {FaindQuad(x,y)} quart");


///Q2

//Задача 3. Напишите программу которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// A (3,6); B (2,1) -> 5.09
// A (7,-5); B (1,-1) -> 7.21

// double FindDistance (double xa, double ya, double xb, double yb)
// {
//     return Math.Round((Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2))), 2);
// }
// System.Console.WriteLine("input X coordinate point A : ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input Y coordinate point A : ");
// double ya = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input X coordinate point B : ");
// double xb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("input Y coordinate point B : ");
// double yb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"Distance between point A and B ->{FindDistance(xa,ya,xb,yb)}");


///Q3
//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
///

// void Diapozone(int x)
// {
//     if (x > 0 && x < 5)
//     {
//         if( x == 1)
//         {
//             System.Console.WriteLine("x + and Y +");
//         }
//         if( x == 2)
//         {
//             System.Console.WriteLine("x - and Y +");
//         }
//         if( x == 3)
//         {
//             System.Console.WriteLine("x - and Y -");
//         }
//         if( x == 4)
//         {
//             System.Console.WriteLine("x + and Y -");
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("Ввели не существующую четверть");
//     }
// }
// System.Console.WriteLine("Введите четверть ->");
// int x = Convert.ToInt32(Console.ReadLine());
// Diapozone(x);




///Q4
//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N
///

// void Quad (int x)
// {
//     int count = 0;
//     while (count <= x)
//     {
//         System.Console.WriteLine($"{count} -> {Math.Pow(count, 2)}");
//         count++;
//     }
// }
// System.Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());

// Quad(x);


//////24.06.2023

///////////////////////////////////////////
///////////////////////////////////////////
///////////////////////////////////////////
//////////////////SEM4////////////////////

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// bool ValidPower(int b)
// {
//     if (b < 0)
//     {
//         System.Console.WriteLine("ОШИБКА!!! Число B не должно быть < 0");
//         return false;
//     }
//     return true;
// }

// int FindPower(int a, int b)
// {
//     int power = 1;
//     for (int i = 0; i < b; i++)
//     {
//         power *= a;
//     }
//     return power;
// }
// System.Console.WriteLine("Input number A -> ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number B -> ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (ValidPower(b))
// {
//     System.Console.WriteLine($"{a} in power {b} is -> {FindPower(a, b)}");
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// void Create(int number)
// {
//     if(number >= 0 && number <= 99999)
//     {
//         int num1 = (number / 10000) % 10;
//         int num2 = (number / 1000) % 10;
//         int num3 = (number / 100) % 10;
//         int num4 = (number / 10) % 10;
//         int num5 = (number % 10);
//         number = num1 + num2 + num3 + num4 + num5;
//         System.Console.WriteLine($"{num1} + {num2} + {num3} + {num4} + {num5} = {number}");
//     }
// }
// System.Console.Write("Введите пятизначное число -> ");
// int number = Convert.ToInt32(Console.ReadLine());
// Create(number);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal elements of array: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal elements of array: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// PrintArray(CreateRandomArray(size, minValue, maxValue));


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Задача 1.  Напишите программу которая принимает на вход число 4 и выдет сумму чисел от 1 до 4
//7 -> 28
//4 -> 10
//8 -> 36

// int FindSum (int a)
// {
//     int sum = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// System.Console.WriteLine("input number: " );
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Sum of numbers at 1 from A -> {FindSum(a)}");

/////////
/// Напишите программу которая выводит масив из 8 элементов, заполненный нулями и единицами в Случайно порядке.
// (1,0,1,1,0,1,0,0)

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.WriteLine(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minValue:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maxValue:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(size, minValue, maxValue));


////////
//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36
// int FindNumber(int a)
// {
//     int current = 0;
//     for (int i = 1; a > 0; i++)
//     {
//         a = a/10;
//         current = i;
//     }
//         return current;
// }
// System.Console.WriteLine("Введите число -> ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{a} -> {FindNumber(a)}");



//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

// int FindFatrorial(int a)
// {
//     int f = 1;
//     for (int i = 1; i <=a; i++)
//     {
//         f = f * i;

//     }
//     return f;
// }

// System.Console.WriteLine("Введите число ->");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{a} -> {FindFatrorial(a)}");

//////////////////
///lekcia

///fibonacCI
// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }
// /////////////
// ///fACTORIAL рЕКУРСИЯ
// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }
//////
//////////Палец вверх

// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };
// ////
// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }
// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }
// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);


///////////

///SEM5
//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     } 
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// void PosnegSum(int[] array)
// {
//     int sumPos = 0;
//     int SumNeg = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) sumPos += array[i];
//         else SumNeg += array[i];
//     }
//     System.Console.WriteLine($"Сумма положительных чисел ровна -> {sumPos} Сумма отрицательных чисел ровна -> {SumNeg}");
// }
// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);
// PosnegSum(myArray);

////////////////////////////////////////////////


//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]
// int[] IvertArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }




// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);


// PrintArray(myArray);

// myArray = InvertArray(myArray);
// PrintArray(myArray);


///

//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// bool TrueNumber (int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num) return true;
//     }
//     return false;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());


// int [] array1 = CreateArray(size);

// PrintArray(array1);

// System.Console.WriteLine(TrueNumber(array1, num));


//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     } 
//     return array;
// }

// int TrueDigits(int [] array)
// {
//     int current = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//         {
//             current ++;
//         }
//     }
//     return current;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [] array1 = CreateRandomArray(size, minValue, maxValue);
// PrintArray(array1);
// System.Console.WriteLine($"В этом массиве количество элементов значения которых лежат в отрезке [10,99] = {TrueDigits(array1)}");



//////////////////
///////DZ/////////
//////////////////

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Input 4 three-digit numbers:");
//         int size1 = Convert.ToInt32(Console.ReadLine());
//         int size2 = Convert.ToInt32(Console.ReadLine());
//         int size3 = Convert.ToInt32(Console.ReadLine());
//         int size4 = Convert.ToInt32(Console.ReadLine());

//         int[] myArray = CreateRandomArray(size1, size2, size3, size4);
//         PrintArray(myArray);

//         int evenNumbersCount = CountEvenNumbers(myArray);
//         Console.WriteLine($"The number of even numbers in the array is {evenNumbersCount}");
//     }

//     static int[] CreateRandomArray(int size1, int size2, int size3, int size4)
//     {
//         int[] array = new int[size1 * size2 * size3 * size4];

//         Random random = new Random();
//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = random.Next(100, 1000);
//         }

//         return array;
//     }

//     static void PrintArray(int[] array)
//     {
//         for (int i = 0; i < array.Length; i++)
//         {
//             Console.Write(array[i] + " ");
//         }
//         Console.WriteLine();
//     }

//     static int CountEvenNumbers(int[] array)
//     {
//         int evenNumbersCount = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i] % 2 == 0)
//             {
//                 evenNumbersCount++;
//             }
//         }
//         return evenNumbersCount;
//     }
// }



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] arr = new int[4];
//         Random rand = new Random();

//         // Заполняем массив случайными числами
//         for (int i = 0; i < arr.Length; i++)
//             arr[i] = rand.Next(-100, 100);

//         // Печатаем массив на консоль
//         System.Console.WriteLine("Массив: ");
//         foreach (int x in arr)
//             System.Console.Write(x + " ");

//         System.Console.WriteLine();

//         // Находим сумму элементов на нечетных позициях
//         int sum = 0;
//         for (int i = 1; i < arr.Length; i += 2)
//             sum += arr[i];

//         System.Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
//     }
// }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int z = 0; z < numbers.Length; z++)
// {
//     if (numbers[z] > max)
//         {
//             max = numbers[z];
//         }
//     if (numbers[z] < min)
//         {
//             min = numbers[z];
//         }
// }

// Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }


///---///


//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// int sum = 0;

// for (int z = 0; z < numbers.Length; z+=2)
//     sum = sum + numbers[z];

//     Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,100);
//         }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }


// //Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// //максимальным и минимальным элементов массива.
// //[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int z = 0; z < numbers.Length; z++)
// {
//     if (numbers[z] > max)
//         {
//             max = numbers[z];
//         }
//     if (numbers[z] < min)
//         {
//             min = numbers[z];
//         }
// }

// Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }


///Sem6
//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     } 
//     return array;
// }

// void PrintArray(int[] array) // 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int[] ReverseArray(int[] array) // Перевород массива
// {
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length -i -1] = temp;
//     }
//     return array;
// }
// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);
// myArray = ReverseArray(myArray);
// PrintArray(myArray);


///////Оисать метод который переводит число в двоичную систему исчисления
// 123
// 61 -> 1
// 30 -> 1
// 15 -> 0
// 7 -> 1
// 3 -> 1
// 1 -> 1
// string DecimalToBinary(int num)
// {
//     string result = string.Empty;
//     while(num > 0)
//     {
//         result = num % 2 + result ;
//         num = num / 2;
//     }
//     return result;
// }


// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Number {num} in binary system -> {DecimalToBinary(num)}");


//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]


// int [] Fibanacci( int size , int num1, int num2)
// {
//     int [] array = new int [size];
//     array[0] = num1;
//     array[1] = num2;
//     for (int i=2 ; i< array.Length; i++)
//     {
//       array [i] = array[(i-1)]+array[(i-2)];
//     }

//    return array;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input num1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input num2: ");
//  int num2 = Convert.ToInt32(Console.ReadLine());  
//  PrintArray(Fibanacci (10,num1, num2));

//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон

// bool CheckTriangle (int a, int b, int c)
// {
//     if (a < b + c && b < a + c && c < a + b) return true;
//     else return false;
// }
// if(CheckTriangle(4, 5, 10)) System.Console.WriteLine("Треугольник может");
// else System.Console.WriteLine("Треугольник не может");


//////DZ///////
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите количество чисел:");
//         int n = int.Parse(Console.ReadLine());

//         int[] numbers = new int[n];

//         Console.WriteLine("Введите числа:");
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = int.Parse(Console.ReadLine());
//         }

//         CountPositiveNumbers(numbers);
//     }

//     static void CountPositiveNumbers(int[] numbers)
//     {
//         int positiveCount = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] > 0)
//             {
//                 positiveCount++;
//             }
//         }
//         Console.WriteLine($"Количество чисел больше 0: {positiveCount}");
//     }
// }




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Ввод значений b1, k1, b2 и k2
//         Console.Write("Введите b1: ");
//         double b1 = double.Parse(Console.ReadLine());

//         Console.Write("Введите k1: ");
//         double k1 = double.Parse(Console.ReadLine());

//         Console.Write("Введите b2: ");
//         double b2 = double.Parse(Console.ReadLine());

//         Console.Write("Введите k2: ");
//         double k2 = double.Parse(Console.ReadLine());

//         // Находим координаты точки пересечения
//         double x = (b2 - b1) / (k1 - k2);
//         double y = k1 * x + b1;
//         // Выводим результат
//         Console.WriteLine("Точка пересечения: ({0}; {1})", x, y);
//     }
// }


///////////////////////////////////////////////////SEM 7
// //Задача 4. задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Print2DArray(Create2DArray(rows, columns, minValue, maxValue));

///***///
//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// 1 2 3
// 4 5 6
// 7 8 9

// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int [,] HandInput(int rows, int cols);
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++);
//     {
//         for (int j = 0; j < cols; j++);
//         {
//             array [i,j] = Convert.ToInt32(Console.ReadLine());
//         }
//     }
//     return array;
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine("Input minimal value of array element: ");
// // int minValue = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine("Input maximal value of array element: ");
// // int maxValue = Convert.ToInt32(Console.ReadLine());

// //int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(HandInput(rows, columns));
// System.Console.WriteLine(FindSumOFMainDiagonal(HandInput(rows, columns)));
// //System.Console.WriteLine(FindSumOFMainDiagonal(myArray));
// //Print2DArray(Create2DArray(rows, columns, minValue, maxValue));


// //Задача 4. задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(Create2DArray(rows, columns, minValue, maxValue));
// System.Console.WriteLine(FindSumOfMainDiagonal(myArray));

///////
// int FindSumOFMainDiagonal (int [,] array);
// {   
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++);
//         {
//             if ( i == j );
//             {
//                 sum+= array [i,j];
//             }
//         }
//     }
//     return sum;
// }

//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:

//1 4 7 2
//5 **81  ** 2 **9**
//8 4 2 4

//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] EvenSum(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//                 array[i, j] = Convert.ToInt32(Math.Pow(array[i, j], 2));
//         }
//     }
//     return array;
// }


// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(array);

// Print2DArray(EvenSum(array));

//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.


// int[,] Create2DArray (int rows, int columns)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = i+j;
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Print2DArray(Create2DArray(rows, columns));

//////////
////DZ////
//////////

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void Create2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100,100)) / 10;
//         }
//     }
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         System.Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine(" ]");
//     }
//     System.Console.WriteLine(" ");
// }

// System.Console.WriteLine("Кол-во строк: ");
// int line = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[line, columns];
// Create2DArray(numbers);
// Print2DArray(numbers);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// void Create2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("]");
//     }
//     Console.WriteLine();
// }

// void Check(double[,] array, int i, int j)
// {
//     if (i < array.GetLength(0) && j < array.GetLength(1))
//     {
//         Console.WriteLine(array[i, j]);
//     }
//     else
//     {
//         Console.WriteLine($"{i} ая строка и {j} столбца -> нет");
//     }
// }

// Console.WriteLine("Кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] numbers = new double[rows, columns];
// Create2DArray(numbers);
// Print2DArray(numbers);

// Console.WriteLine("Введите номер строки и столбца для проверки:");
// Console.WriteLine("Номер строки: ");
// int rowIndex = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Номер столбца: ");
// int columnIndex = Convert.ToInt32(Console.ReadLine());

// Check(numbers, rowIndex, columnIndex);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void Create2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("]");
//     }
//     Console.WriteLine();
// }

// void Check(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum += array[i, j];
//     }
//     Console.Write($"{ sum / array.GetLength(0)} ");
//     }   
// }


// Console.WriteLine("Кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] numbers = new double[rows, columns];
// Create2DArray(numbers);
// Print2DArray(numbers);
// Check(numbers);

////////////////
//////SEM8/////
///////////////
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// void SortToLower(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }
// System.Console.WriteLine("Кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Кол-во колонок: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Минимальный элемент: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Максимальный элемент: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// SortToLower(myArray);
// Print2DArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// static int Check(int [,] array)
//     {
//         int minSum = int.MaxValue;
//         int minSumRow = -1;

//         for (int i = 0; i < array.GetLength(0); i++) // перебор строк
//         {
//             int sum = 0;

//             for (int j = 0; j < array.GetLength(1); j++) // перебор элементов в строке
//             {
//                 sum += array[i, j];
//             }

//             if (sum < minSum)
//             {
//                 minSum = sum;
//                 minSumRow = i +1;
//             }
//         }

//         return minSumRow;
//     }
// System.Console.WriteLine("Кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Кол-во колонок: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Минимальный элемент: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Максимальный элемент: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// int minSumRow = Check(myArray);
// Console.WriteLine("Наименьшая сумма элементов в строке: " + minSumRow + " строка");
// Check(myArray);
// Print2DArray(myArray);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// /////////////////////////////////
// void Matrix2DArray(int[,] myArray, int[,] myArray1, int[,] myArrayfin)
// {
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < myArray1.GetLength(0); k++)
//             {
//                 sum += myArray[i, k] * myArray1[k, j];
//             }
//             myArrayfin[i, j] = sum;
//         }
//     }
// }
// ////////////////////
// System.Console.WriteLine("Кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Кол-во колонок: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Минимальный элемент: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Максимальный элемент: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// int[,] myArray1 = Create2DArray(columns, rows, minValue, maxValue);
// int[,] myArrayfin = new int[myArray.GetLength(0), myArray1.GetLength(1)];

// Print2DArray(myArray);
// Print2DArray(myArray1);

// Matrix2DArray(myArray, myArray1, myArrayfin);
// Print2DArray(myArrayfin);





// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] array3D = new int[2, 2, 2];
// FillArray(array3D);
// PrintIndex(array3D);


// // Функция вывода индекса элементов 3D массива
// void PrintIndex(int[,,] arr)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// // Функция заполнения 3D массива не повторяющимеся числами
// void FillArray(int[,,] arr)
// {
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

// int n = 4;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//   sqareMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// WriteArray(sqareMatrix);

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }

//////////////////////////////

//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2
//////////////////////////////

// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] ChangeRows(int[,] array, int row1, int row2)
// {   
//     if ( row1 >= array.GetLength (0) || row2 >= array.GetLength(0))
//     {
//         System.Console.WriteLine("Указанные строки выходят за пределы массива!");
//         return array;
//     }
//     else
//         for (int j = 0;  j < array.GetLength(1); j++)
//         {
//             int temp = array[row1,j];
//             array[row1,j] = array[row2, j];
//             array[row2,j] = temp;
//         }
//     return array;
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input number of row1 to change ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of row2 to change ");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Print2DArray(ChangeRows(myArray, row1, row2)); //зад 1
// Print2DArray(RowsTOColumns(myArray)); // зад 2

////////////

//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7

/////////////////////////

// int[,] RowsTOColumns(int[,] array)
// {
//     if(array.GetLength(0) != array.GetLength(1))
//     {
//         System.Console.WriteLine("Не квадратный массив!");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = i+1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array [j, i];
//                 array [j, i] = temp;
//             }
//         }
//     }
//     return array;
// }

////////////////////

// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] MinValue(int[,] array)
// {
//     int minI = 0; //строка
//     int minJ = 0; // столбец
//     int minNum = array[0, 0];
//     for(int i = 0; i < array.GetLength(0); i++)// array.GetLength(
//         {
//             for(int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (array[i,j] <= minNum)
//                 minNum = array [i,j];
//                 minI = i;
//                 minJ = j;

//             }
//         }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         array[i, minJ] = 0;       
//     }
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[minI,j] = 0; 
//     }
//     return array;
// }



// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Print2DArray(MinValue(myArray));

/////////Не мой
// int[,] MinValue(int[,] array)
// {
//     int minI = 0;
//     int minJ = 0;
//     int minnum = array[0, 0];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] <= minnum)
//             {
//                 minnum = array[i, j];
//             minI = i;
//             minJ = j;
//             }
//         }
//     }

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         array[i, minJ] = 0;

//     }

//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[minI, j] = 0;
//     }

//     return array;
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Print2DArray(MinValue(myArray));

//////////////////////////
//////////////////////////
//////////////////////////

//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"
///РЕКУРСИЯ

// void printNum (int n)
// {
//     if(n>=1)
//     {
//         printNum(n-1);
//         System.Console.Write(n + " ");
//     }
// }

// printNum(6);

//////////
//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

//453 -> 12
//45 -> 9
//////////////

// int FindSum(int num)
// {
//     if (num > 0)
//     {
//         return FindSum(num / 10) + num % 10;
//     }
//     else return num;
// }
// System.Console.WriteLine("Input num");
// int num = Convert.ToInt32(Console.ReadLine());
// ////
// // System.Console.WriteLine(FindSum(453));
// ////
// System.Console.WriteLine(FindSum(num));

//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"
////////

// void FindSum(int m, int n)
// {
//     if (m != n)
//     {
//         if (m < n)
//         {
//             FindSum(m, n-1);
//             System.Console.Write(n + " ");
//         }
//         else
//         {
//             FindSum(m-1, n);
//             System.Console.Write(m + " "); // перенести вверх будет наоборот
//         }
//     }
//     else System.Console.Write(m + " ");
// }
// FindSum(10, 2);

////////
//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
////////

// int  FindNumbers(int a, int b)
// {
//     if(b > 0)
//     {
//         return FindNumbers(a, b-1) * a;
//     }
//     else return 1;
// }
// System.Console.WriteLine(FindNumbers(2, 3));

///////////
///DZSeM9//
///////////
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"
///РЕКУРСИЯ

// void PrintNum(int num)
// {
//     if(num>=1)
//     {
//         System.Console.Write(num + ", ");
//         PrintNum(num-1);

//     }
// }
// System.Console.WriteLine("Input num");
// int num = Convert.ToInt32(Console.ReadLine());

// PrintNum(num);
// System.Console.WriteLine();

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// void NaturalNumber(int a, int b)
// {
//     System.Console.WriteLine(SumMN(a - 1, b));
// }

// int SumMN(int a, int b)
// {
//     int res = a;
//     if (a == b)
//         return 0;
//     else
//     {
//         a++;
//         res = a + SumMN(a, b);
//         return res;
//     }
// }

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// NaturalNumber(a, b);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }

// void AkkermanFunction(int m, int n)
// {

//     System.Console.Write($"Akkerman Function ({m},{n}) -> {Akkerman(m, n)}");
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input M");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input N");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m, n);
