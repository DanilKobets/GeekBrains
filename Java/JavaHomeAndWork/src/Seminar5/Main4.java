//package Seminar5;
//
//import java.awt.*;
//import java.util.ArrayList;
//import java.util.Comparator;
//import java.util.TreeMap;
//
///*
//    Взять набор строк, например,=
//
//    Мороз и солнце день чудесный
//    Еще ты дремлешь друг прелестный
//    Пора красавица проснись.
//
//    Написать метод, который отсортирует эти строки(СЛОВА) по длине с помощью TreeMap.
//    Строки с одинаковой длиной не должны “потеряться”.
// */
//public class Main4 {
//    public static void main(String[] args) {
//        TreeMap<Integer, List<String>> map = new TreeMap<>(Comparator.reverseOrder());
//        String s = "Мороз и солнце день чудесный\n" +
//                "Еще ты дремлешь друг прелестный\n" +
//                "Пора красавица проснись.";
//        s = s.replace("\n", " ");
//        s = s.replace(".", "");
//        String[] words = s.split(" ");
//        for (String word : words) {
//            int len = word.length();
//            if (map.containsKey(len)) {
//                List<String> list = map.get(len);
//                list.add(word);
//            } else {
//                List<String> list = new ArrayList<>();
//                list.add(word);
//                map.put(len, list);
//            }
//        }
//
//        System.out.println(map);
//    }
//}
