package HomeWork3.Q3;


// Напишите функцию analyzeNumbers, которая принимает на вход целочисленный список arr и:
// Сортирует его по возрастанию и выводит на экран
// Находит минимальное значение в списке и выводит на экран - Minimum is {число}
// Находит максимальное значение в списке и выводит на экран - Maximum is {число}
// Находит среднее арифметическое значений списка и выводит на экран - Average is =  {число}
// Напишите свой код в методе analyzeNumbers класса Answer. Метод analyzeNumbers принимает на вход один параметр:
// Integer[] arr - список целых чисел
//
// Пример
//
// arr = new Integer[]{4, 2, 7, 5, 1, 3, 8, 6, 9};
// analyzeNumbers(arr)
//
// [1, 2, 3, 4, 5, 6, 7, 8, 9]
// Minimum is 1
// Maximum is 9
// Average is = 5

import java.util.Arrays;
import java.util.ArrayList;

class Answer {
    public static void analyzeNumbers(Integer[] arr) {
        ArrayList<Integer> ints = new ArrayList<>(Arrays.asList(arr));
        ints.sort(Integer::compareTo); // сортировка списка по возрастанию
        System.out.println(ints); // вывод списка на экран
        System.out.println("Minimum is " + ints.get(0)); // нахождение минимального значения в списке и вывод на экран
        System.out.println("Maximum is " + ints.get(ints.size()-1)); // нахождение максимального значения в списке и вывод на экран

        int sum = 0;
        for(int i : ints){ // вычисление суммы всех элементов списка
            sum += i;
        }
        System.out.println("Average is = " + sum / ints.size()); // вычисление среднего арифметического значений списка и вывод на экран
    }
}


// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Printer{
    public static void main(String[] args) {
        Integer[] arr = {};

        if (args.length == 0) {
            // При отправке кода на Выполнение, вы можете варьировать эти параметры
            arr = new Integer[]{4, 2, 7, 5, 1, 3, 8, 6, 9};
        }
        else{
            arr = Arrays.stream(args[0].split(", "))
                    .map(Integer::parseInt)
                    .toArray(Integer[]::new);
        }

        Answer ans = new Answer();
        ans.analyzeNumbers(arr);
    }
}