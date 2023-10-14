package Seminar2;

public class task_3 {
    /*
    Напишите метод, который принимает на вход сроку String и определяет является ли
    строка палиндромом (возвращает boolean Значение)
    Полидром - слово или фраза которые одинаково читаются слева на право и справа наллево.
     */
    public static void main(String[] args){
        String x = "потоп";
        if(polidrom(x)){
            System.out.println("Является полидромом");
        }
        else{
            System.out.println("не Является полидромом");
        }
    }
    static boolean polidrom(String x){
        x = x.toLowerCase();
        char [] sum = x.toCharArray();
        for (int i = 0; i < sum.length / 2; i++) {
            if (sum[i] != sum[sum.length-1-i])
                return false;
        }
        return true;
    }

    //Варинт 2
    static boolean polidromV2(String x){
        String s1 = x.toLowerCase();
        StringBuilder res = new StringBuilder(s1);
        String s2 = res.reverse().toString();
        return s1.equals(s2); //Сравнение строк
    }
}
