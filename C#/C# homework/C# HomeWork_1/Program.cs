// // //DZ
// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

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


// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22


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



// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// // 4 -> да
// // -3 -> нет
// // 7 -> нет

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


