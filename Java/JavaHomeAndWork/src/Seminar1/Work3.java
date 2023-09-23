package Seminar1;
//Во фразе "Добро пожаловать на курс по Java" переставить слова в обратном порядке.
public class Work3 {
    public static void main(String[] args){
        String line = "Добро пожаловать на курс по Java";
        String[] words = line.split(" ");
        String res = "";
        for (int i = words.length - 1; i >= 0; i--){
            res += words[i];
            res += " ";
        }
        System.out.println(res.trim());
    }
}

// fori (быстро пишет)
// sout (быстро пишет)
