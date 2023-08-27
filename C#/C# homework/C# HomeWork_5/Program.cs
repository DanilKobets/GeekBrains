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

