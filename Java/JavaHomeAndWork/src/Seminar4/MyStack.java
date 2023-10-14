package Seminar4;

public class MyStack {
    private String[] arr = new String[10];
    private int size = 0;

    public int size(){
        return size;
    }

    public boolean empty(){
        return size == 0;
    }

    public void push(String s){
        if (size >= arr.length){
            String[] arr2 = new String[arr.length * 2];
            System.arraycopy(arr, 0, arr2, 0, arr.length);
            arr = arr2;
        }
        arr[size++] = s;
    }

    public String peek(){
        return arr[size-1];
    }

    public String pop(){
        return arr[--size];
    }
}