package Seminar3;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main4 {
    /*
Каталог товаров книжного магазина сохранен в виде двумерного списка List<ArrayList<String>> так, что на 0й позиции
каждого внутреннего списка содержится название жанра, а на остальных позициях - названия книг. Напишите метод для
заполнения данной структуры.
["роман", "войа и мир"]
["сказки", "колобок"]
     */
    public static void main(String[] args) {
        List<List<String>> shopBook = new ArrayList<>();
        addBook(shopBook, "роман", "война и мир");
        addBook(shopBook, "сказки", "колобок");
        addBook(shopBook, "сказки", "фея в стране чудес");
        addBook(shopBook, "сказки", "старик у моря");
        addBook(shopBook, "фентези", "гарри поттер");
        addBook(shopBook, "ужасы", "оно ");


        System.out.println(shopBook);

        List<String> list = new ArrayList<>(Arrays.asList("1", "2"));
    }

    static void addBook(List<List<String>> shopBook, String genre, String nameBook){
        for (int i = 0; i < shopBook.size(); i++) {
            List<String> curList = shopBook.get(i);
            String curGenre = curList.get(0);
            if (curGenre.equals(genre)){
                if (!curList.contains(nameBook)){
                    curList.add(nameBook);
                }
                return;
            }
        }
        List<String> list = new ArrayList<>();
        list.add(genre);
        list.add(nameBook);
        shopBook.add(list);
    }
}