package Seminar2;

public class task_1 {
    /*
    Напишите метод, который сжимает строку
    Пример: вход aaaabbbcdd
    результат: a4b3cd2
     */
    public static void main(String[] args){
        String x = "aaaabbbcdd";
        System.out.println(list(x));
    }
    static String list(String x) {
        StringBuilder stringBuilder = new StringBuilder();
        int count = 1;
        for (int i = 0; i < x.length() - 1; i++) {
            if (x.charAt(i) == x.charAt(i + 1)) {
                count += 1;
            } else {
                stringBuilder.append(x.charAt(i));
                    if (count != 1)
                stringBuilder.append(count);
                    count = 1;
            }

        }
        stringBuilder.append(x.charAt(x.length()-1));
        if (count != 1)
            stringBuilder.append(count);
        return stringBuilder.toString();
    }
}
