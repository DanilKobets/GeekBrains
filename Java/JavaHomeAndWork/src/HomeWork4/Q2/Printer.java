package HomeWork4.Q2;

import java.util.LinkedList;

/*
В классе MyQueue реализуйте очередь с помощью LinkedList со следующими методами:

enqueue() - помещает элемент в конец очереди
dequeue() - возвращает первый элемент из очереди и удаляет его
first() - возвращает первый элемент из очереди, не удаляя
getElements() - возвращает все элементы в очереди


Пример:

queue.enqueue(1);
queue.enqueue(10);
queue.enqueue(15);
queue.enqueue(5);
System.out.println(queue.getElements());
// [1, 10, 15, 5]

queue.dequeue();
queue.dequeue();
System.out.println(queue.getElements());
// [15, 5]

System.out.println(queue.first());
// 15
 */

class MyQueue<T> {
    private LinkedList<T> queue;

    public MyQueue() {
        queue = new LinkedList<>();
    }

    public void enqueue(T element) { //помещает элемент в конец очереди
        queue.addLast(element);
    }

    public T dequeue() { //возвращает первый элемент из очереди и удаляет его
        return queue.removeFirst();
    }

    public T first() { //возвращает первый элемент из очереди, не удаляя
        return queue.getFirst();
    }

    public LinkedList<T> getElements() { //возвращает все элементы в очереди
        return queue;
    }
}

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Printer {
    public static void main(String[] args) {
        MyQueue<Integer> queue;
        queue = new MyQueue<>();

        if (args.length == 0) {
            // При отправке кода на Выполнение, вы можете варьировать эти параметры
            queue.enqueue(1);
            queue.enqueue(10);
            queue.enqueue(15);
            queue.enqueue(5);
        } else {
            queue.enqueue(Integer.parseInt(args[0]));
            queue.enqueue(Integer.parseInt(args[1]));
            queue.enqueue(Integer.parseInt(args[2]));
            queue.enqueue(Integer.parseInt(args[3]));
        }

        System.out.println(queue.getElements());

        queue.dequeue();
        queue.dequeue();
        System.out.println(queue.getElements());

        System.out.println(queue.first());
    }
}