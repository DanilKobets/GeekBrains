package HomeWork1.Q2;
//Напишите функцию printPrimeNums, которая выведет на экран все простые числа в промежутке от 1 до 1000, каждое на новой строке.
//Напишите свой код в методе printPrimeNums класса Answer.
//Пример
//1
//2
//3
//5
//7
//11
//...
class Answer {
    public void printPrimeNums(){
        // Напишите свое решение ниже
                for (int i = 1; i <= 1000; i++) {
                    boolean isPrime = true;

                    for (int j = 2; j < i; j++) {
                        if (i % j == 0) {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime) {
                        System.out.println(i);
                    }
                }
            }
        }


// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Printer{
    public static void main(String[] args) {

        Answer ans = new Answer();
        ans.printPrimeNums();
    }
}