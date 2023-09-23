package Seminar1;

import java.time.LocalTime;
import java.util.Scanner;
//s - строка d - диджитал
//В консоли запросить имя пользователя. В зависимости от текущего времени, вывести приветствие вида
//        "Доброе утро, <Имя>!", если время от 05:00 до 11:59
//        "Добрый день, <Имя>!", если время от 12:00 до 17:59;
//        "Добрый вечер, <Имя>!", если время от 18:00 до 22:59;
//        "Доброй ночи, <Имя>!", если время от 23:00 до 4:59

public class Main {
        public static void main(String[] args) {
                Scanner scanner = new Scanner(System.in);
                System.out.println("Как вас зовут?");
                String name = scanner.nextLine();
                System.out.println(hello(name));
        }

        static String hello(String name) {
                LocalTime time = LocalTime.now();
                int hour = time.getHour();
                String res;
                if (hour >= 5 && hour < 12) {
                        res = "Доброе утро, " + name + "!";
                } else if (hour >= 12 && hour < 18) {
                        res = "Добрый день, " + name + "!";
                } else if (hour >= 18 && hour < 23) {
                        res = "Добрый вечер, " + name + "!";
                } else {
                        res = "Доброй ночи, " + name + "!";
                }
                return res;
        }
}
