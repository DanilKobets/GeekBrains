// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
{
    int[,] array = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
    {
        for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
System.Console.WriteLine("Кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Кол-во колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Минимальный элемент: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Максимальный элемент: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
Print2DArray(myArray);
SortToLower(myArray);
Print2DArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
{
    int[,] array = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
    {
        for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
static int Check(int [,] array)
    {
        int minSum = int.MaxValue;
        int minSumRow = -1;

        for (int i = 0; i < array.GetLength(0); i++) // перебор строк
        {
            int sum = 0;

            for (int j = 0; j < array.GetLength(1); j++) // перебор элементов в строке
            {
                sum += array[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = i +1;
            }
        }

        return minSumRow;
    }
System.Console.WriteLine("Кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Кол-во колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Минимальный элемент: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Максимальный элемент: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
Print2DArray(myArray);
int minSumRow = Check(myArray);
Console.WriteLine("Наименьшая сумма элементов в строке: " + minSumRow + " строка");
Check(myArray);
Print2DArray(myArray);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
{
    int[,] array = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
    {
        for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
/////////////////////////////////
void Matrix2DArray(int[,] myArray, int[,] myArray1, int[,] myArrayfin)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < myArray1.GetLength(0); k++)
            {
                sum += myArray[i, k] * myArray1[k, j];
            }
            myArrayfin[i, j] = sum;
        }
    }
}
////////////////////
System.Console.WriteLine("Кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Кол-во колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Минимальный элемент: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Максимальный элемент: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
int[,] myArray1 = Create2DArray(columns, rows, minValue, maxValue);
int[,] myArrayfin = new int[myArray.GetLength(0), myArray1.GetLength(1)];

Print2DArray(myArray);
Print2DArray(myArray1);

Matrix2DArray(myArray, myArray1, myArrayfin);
Print2DArray(myArrayfin);





// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);


// Функция вывода индекса элементов 3D массива
void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

// Функция заполнения 3D массива не повторяющимеся числами
void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}

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

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

//////////////////////////////

