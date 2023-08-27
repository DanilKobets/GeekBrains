// Сортировка Выбором

/*
2 7 0 3 -5 12 8

-5 7 0 3 2 12 8

-5 0 7 3 2 12 8

-5 0 2 3 7 12 8

-5 0 2 3 7 12 8

-5 0 2 3 7 12 8

-5 0 2 3 7 8 12
*/
// char f()  // -> функция
// {
//     return '1';
// }

// void v()  // -> процедура
// {
//     Console.WriteLine("Hello, world!");
// }

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11); // [-10; 10]
}


int[] SortVibor(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int min = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[min])
            {
                min = j;
            }
        }
        int temp = array[min];
        array[min] = array[i];
        array[i] = temp;
    }
    return array;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Конечныый массив: [{string.Join(", ", SortVibor(array))}]");