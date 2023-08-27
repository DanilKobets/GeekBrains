///////////////////////////////////////////
///////////////////////////////////////////
///////////////////////////////////////////
//////////////////SEM4////////////////////

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

bool ValidPower(int b)
{
    if (b < 0)
    {
        System.Console.WriteLine("ОШИБКА!!! Число B не должно быть < 0");
        return false;
    }
    return true;
}

int FindPower(int a, int b)
{
    int power = 1;
    for (int i = 0; i < b; i++)
    {
        power *= a;
    }
    return power;
}
System.Console.WriteLine("Input number A -> ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number B -> ");
int b = Convert.ToInt32(Console.ReadLine());
if (ValidPower(b))
{
    System.Console.WriteLine($"{a} in power {b} is -> {FindPower(a, b)}");
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Create(int number)
{
    if(number >= 0 && number <= 99999)
    {
        int num1 = (number / 10000) % 10;
        int num2 = (number / 1000) % 10;
        int num3 = (number / 100) % 10;
        int num4 = (number / 10) % 10;
        int num5 = (number % 10);
        number = num1 + num2 + num3 + num4 + num5;
        System.Console.WriteLine($"{num1} + {num2} + {num3} + {num4} + {num5} = {number}");
    }
}
System.Console.Write("Введите пятизначное число -> ");
int number = Convert.ToInt32(Console.ReadLine());
Create(number);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal elements of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal elements of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
PrintArray(CreateRandomArray(size, minValue, maxValue));


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Задача 1.  Напишите программу которая принимает на вход число 4 и выдет сумму чисел от 1 до 4
//7 -> 28
//4 -> 10
//8 -> 36

int FindSum (int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}

System.Console.WriteLine("input number: " );
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Sum of numbers at 1 from A -> {FindSum(a)}");

/////////
/// Напишите программу которая выводит масив из 8 элементов, заполненный нулями и единицами в Случайно порядке.
// (1,0,1,1,0,1,0,0)

int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i] + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minValue:");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maxValue:");
int maxValue = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateRandomArray(size, minValue, maxValue));


////////
//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36
int FindNumber(int a)
{
    int current = 0;
    for (int i = 1; a > 0; i++)
    {
        a = a/10;
        current = i;
    }
        return current;
}
System.Console.WriteLine("Введите число -> ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{a} -> {FindNumber(a)}");



//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

int FindFatrorial(int a)
{
    int f = 1;
    for (int i = 1; i <=a; i++)
    {
        f = f * i;

    }
    return f;
}

System.Console.WriteLine("Введите число ->");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{a} -> {FindFatrorial(a)}");
