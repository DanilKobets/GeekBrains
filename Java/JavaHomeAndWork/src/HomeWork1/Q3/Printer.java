package HomeWork1.Q3;
//Реализуйте простой калькулятор
//Напишите класс Calculator, который будет выполнять математические операции (+, -, *, /)
//над двумя числами и возвращать результат. В классе должен быть метод calculate, который принимает оператор и значения
//аргументов и возвращает результат вычислений.
//При неверно переданном операторе, программа должна вывести сообщение об ошибке
//"Некорректный оператор: 'оператор'".
class Calculator {
    public int calculate(char op, int a, int b) {
        int result = 0;
        switch (op) {
            case '+':
                result = a + b;
                break;
            case '-':
                result = a - b;
                break;
            case '*':
                result = a * b;
                break;
            case '/':
                if (b != 0) {
                    result = a / b;
                } else {
                    System.out.println("Ошибка: деление на ноль");
                }
                break;
            default:
                System.out.println("Некорректный оператор: " + op);
        }
        return result;
    }
}

public class Printer {
    public static void main(String[] args) {
        int a = 0;
        char op = ' ';
        int b = 0;

        if (args.length == 0) {
            // При отправке кода на Выполнение, вы можете варьировать эти параметры
            a = 3;
            op = '+';
            b = 7;
        } else {
            a = Integer.parseInt(args[0]);
            op = args[1].charAt(0);
            b = Integer.parseInt(args[2]);
        }

        Calculator calculator = new Calculator();
        int result = calculator.calculate(op, a, b);
        System.out.println(result);
    }
}