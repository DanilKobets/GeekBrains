// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"
///РЕКУРСИЯ

void PrintNum(int num)
{
    if(num>=1)
    {
        System.Console.Write(num + ", ");
        PrintNum(num-1);

    }
}
System.Console.WriteLine("Input num");
int num = Convert.ToInt32(Console.ReadLine());

PrintNum(num);
System.Console.WriteLine();

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void NaturalNumber(int a, int b)
{
    System.Console.WriteLine(SumMN(a - 1, b));
}

int SumMN(int a, int b)
{
    int res = a;
    if (a == b)
        return 0;
    else
    {
        a++;
        res = a + SumMN(a, b);
        return res;
    }
}

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
NaturalNumber(a, b);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

void AkkermanFunction(int m, int n)
{

    System.Console.Write($"Akkerman Function ({m},{n}) -> {Akkerman(m, n)}");
    System.Console.WriteLine();
}

System.Console.WriteLine("Input M");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m, n);