package Seminar3;

import java.util.ArrayList;
import java.util.Iterator;

public class Main3 {
    /*
Создать список типа ArrayList
Поместить в него как строки, так и целые числа.
Пройти по списку, найти и удалить целые числа.
 */
    public static void main(String[] args) {
        ArrayList<Object> myList = new ArrayList<>();
        myList.add(1);
        myList.add(9);
        myList.add("hello");
        myList.add(1.5);
        myList.add("88");
        System.out.println(myList);
//        ver1(myList);
        ver2(myList);
        System.out.println(myList);
    }

    private static void ver2(ArrayList<Object> myList) {
        Iterator iterator = myList.iterator();
        while (iterator.hasNext()){
            Object o = iterator.next();
            if (o instanceof Integer){
                iterator.remove();
            }
        }
//        myList.removeIf(o -> o instanceof Integer);
    }
    // ctrl + alt + m
    private static void ver1(ArrayList<Object> myList) {
        for (int i = 0; i < myList.size(); i++) {
            Object o = myList.get(i);
            if (o instanceof Integer){
                myList.remove(i);
                i--;
            }
        }
    }
}