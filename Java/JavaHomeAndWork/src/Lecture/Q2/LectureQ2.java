/*
API для Строки
- concat() - объединение строк
- valueOf() - преобразует Object в строковое представление.
(завязан на toString())
- join() - объединяет набор строк в одну с учетом разделителя.
- charAt() - получение символа по индексу.
- indexOf() - первый индекс вхождения подстроки.
- lastIndexOf() - последний индекс вхождения подстроки.
- startsWith() / endsWith() = определяет, начинается/заканчивается
(ли строка с подстроки)
- replace() - замена одной подстроки на другую.
- trim() - удаляет начальные и конечные пробелы.
- substing() - возвращает подстроку см. аргументы
- toLowerCase() / toUpperCase() - возврает новую строку в нижнем/верхнем регистре.
- compareTo() - сравнивает две строки
- equals() - сравнивает строки с учётом регистра
- equalsIgnoreCae() - сравнивает строки без учета регистра.
- regionMatches() - сравнивает подстроки в строках.

string - много изменений
stringBuilder - много пребразований



////Работа с фаловой////
Работа с фаловой системой.Файлы.Ошибки
try{
    Код, в котором может появиться ошибка
} catch (Exception e) {
    Обработака, если ошибка случилась
}
finally{
    Код, который выполнится в любом случае
}
////Работа с фаловой////
- isHidden() - возвращает истину, если каталог или файл является скрытым.
- length() - возвращает размер файла в байтах.
- lastModifiend() - возвращает время последнего изменения файла или каталога.
- list() - возвращает массив файлов и подкаталогов, которые находятся в каталоге.
- listFiles() - возвращает массив файлов и подкаталогово, которые находятся в определенном каталоге.
- mkdir() - создает новый каталог.
- renameTo(File dest) - переименовывает файл или каталог.

////Логирование.Использование.Основы////
Использование
    logger logger = Logger.getLogger()
Уровни важности
    INFO, DEBUG, ERROR, WARNING и др.
Вывод
    ConsoleHandler info = new ConsoleHandler();
    log.addHandler(info);
Формат вывода: структурированный, абы как*
    XMLFormatter, SimpleFormatter
 */



package Lecture.Q2;

import java.io.IOException;
import java.util.logging.*;

public class LectureQ2 {
    public static void main (String[] args) throws IOException {
        Logger logger = Logger.getLogger(LectureQ2.class.getName());
//        ConsoleHandler ch = new ConsoleHandler();
//        logger.addHandler(ch);
        FileHandler fh = new FileHandler("log.xml");
        logger.addHandler(fh);

//        SimpleFormatter sFormat = new SimpleFormatter();
//        ch.setFormatter(sFormat);
        XMLFormatter xml = new XMLFormatter();
        fh.setFormatter(xml); //fh или ch

//        logger.setLevel(Level.INFO);
        logger.log(Level.WARNING, "Тестовое логирование 1");
        logger.info("Тестовое логирование 2");
    }
}
