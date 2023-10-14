package Seminar6;
/*
    1. Продумайте структуру класса Кот. Какие поля и методы будут актуальны для приложения, которое является
    а) информационной системой ветеринарной клиники
    б) архивом выставки котов
    в) информационной системой Театра кошек Ю. Д. Куклачёва
    Можно записать в текстовом виде, не обязательно реализовывать в java.
 */
import java.util.HashSet;
import java.util.Set;

public class Main3 {
    public static void main(String[] args) {
        Set<Cat> set = new HashSet<>();

        Cat cat1 = new Cat();
        cat1.setName("Барсик");
        cat1.setAge(10);
        cat1.setPoroda("Перситский");
        cat1.setNameOwner("Иван Иванович");

        Cat cat2 = new Cat();
        cat2.setName("Милка");
        cat2.setAge(5);
        cat2.setPoroda("Шотландская");
        cat2.setNameOwner("Тимофей Арестович");

        Cat cat3 = new Cat();
        cat3.setName("Василиса");
        cat3.setAge(9);
        cat3.setPoroda("Бенгальская");
        cat3.setNameOwner("Екатирина Труфина");

        Cat cat4 = new Cat();
        cat4.setName("Барсик");
        cat4.setAge(10);
        cat4.setPoroda("Перситский");
        cat4.setNameOwner("Марк петрович");

        Cat cat5 = new Cat();
        cat5.setName("Дворняга");
        cat5.setAge(8);
        cat5.setPoroda("Дворняга");
        cat5.setNameOwner("Ничейная");

        set.add(cat1);
        set.add(cat2);
        set.add(cat3);
        set.add(cat4);
        set.add(cat5);

        System.out.println(cat1.equals(cat4));
        printSet(set);
        System.out.println();
        findByAge(set, 9);
    }

    static void findByAge(Set<Cat> cats, int age){
        for (Cat cat: cats){
            if (cat.getAge() >= age){
                System.out.println(cat);
            }
        }
    }

    static void printSet(Set<Cat> set){
        for (Cat cat: set){
            System.out.println(cat);
        }
    }
}