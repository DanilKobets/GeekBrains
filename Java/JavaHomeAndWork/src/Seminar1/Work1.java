package Seminar1;
//        Дан массив двоичных чисел, например [1,1,0,1,1,1], вывести максимальное количество подряд идущих 1.
public class Work1 {
    public static void main(String[] args) {
        int[] arr = {1,1,0,1,1,1,};
        int count = 0;
        int max = 0;
        for (int i = 0; i < arr.length; i++){
            if (arr[i] == 1){
                count++;
                if (max < count) {
                    max = count;
                }
            }
            else {
                count = 0;
            }
        }
        System.out.println("Answer: " + max);
    }
}
