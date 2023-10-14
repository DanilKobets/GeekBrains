package Seminar2;

import java.io.FileWriter;
import java.io.IOException;
import java.util.logging.FileHandler;
import java.util.logging.Handler;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;

public class task_4 {
    static Logger logger = Logger.getAnonymousLogger();
    /*
    Напишите метод который составит строку состоящую из 100 повторений слова TEST и метод,
    который запишет эту строку в простой текстовый, файл обработайте исключения.
     */
    public static void main(String[] args){
        String logPath = "JavaHomeAndWork/src/Seminar2/log.txt"; // Путь логера
        String filePath = "JavaHomeAndWork/src/Seminar2/test.txt";
        String s = "TEST";
        int count = 5;
        createLogger(logPath); //создания логгера
        String temp = repeat(s, count);
        writeToFile(filePath, temp);
        closeLogger(); // закрытие логгера
    }
    static String repeat(String s, int n){
        return s.repeat(n);
    }

    static void createLogger(String logPath){
        SimpleFormatter formatter = new SimpleFormatter();
        FileHandler handler = null;
        try {
            handler = new FileHandler(logPath, true);
            handler.setFormatter(formatter);
            logger.addHandler(handler);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
    static void closeLogger() {
        Handler[] handlers = logger.getHandlers();
        for (Handler handler : handlers){
            handler.close();
        }
    }


    static void writeToFile(String filePath, String s) {
        try {
            FileWriter writer = new FileWriter(filePath, true);
            writer.write(s); // добовляет в буфер
            writer.write("\n");
            writer.flush(); // сохраняет в файл из буфера
//            writer.close(); // закрывает файл
            logger.info("Запись в файл выполнина успешно"); //LOGGER
        }catch (Exception e){ //ловим ошибки
            e.printStackTrace(); // показывает какая ошибка
            System.out.println("Запись не удалась");
            logger.warning("Запись не удалась");
//        }finally { // в любом случае выполняет

        }
    }
}
