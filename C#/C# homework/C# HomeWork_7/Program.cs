// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Create2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100,100)) / 10;
        }
    }
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine(" ]");
    }
    System.Console.WriteLine(" ");
}

System.Console.WriteLine("Кол-во строк: ");
int line = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[line, columns];
Create2DArray(numbers);
Print2DArray(numbers);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Create2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}

void Check(double[,] array, int i, int j)
{
    if (i < array.GetLength(0) && j < array.GetLength(1))
    {
        Console.WriteLine(array[i, j]);
    }
    else
    {
        Console.WriteLine($"{i} ая строка и {j} столбца -> нет");
    }
}

Console.WriteLine("Кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[rows, columns];
Create2DArray(numbers);
Print2DArray(numbers);

Console.WriteLine("Введите номер строки и столбца для проверки:");
Console.WriteLine("Номер строки: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Номер столбца: ");
int columnIndex = Convert.ToInt32(Console.ReadLine());

Check(numbers, rowIndex, columnIndex);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Create2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}

void Check(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0)} ");
    }   
}


Console.WriteLine("Кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[rows, columns];
Create2DArray(numbers);
Print2DArray(numbers);
Check(numbers);

