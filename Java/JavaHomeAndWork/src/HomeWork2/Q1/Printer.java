/*
Дана строка sql-запроса:
select * from students where "
Сформируйте часть WHERE этого запроса, используя StringBuilder. Пример данных для фильтрации приведены ниже в
виде json-строки. Если значение null, то параметр не должен попадать в запрос.
Пример:
{"name": "Ivanov", "country": "Russia", "city": "Moscow", "age": "null"}
Напишите свой код в методе answer класса Answer. Метод answer принимает на вход два параметра:
String QUERY - начало SQL-запроса
String PARAMS - JSON с параметрами

 */

package HomeWork2.Q1;


class Answer {
    public static StringBuilder answer(String QUERY, String PARAMS){
        // Напишите своё решение ниже
        StringBuilder myQuery = new StringBuilder(QUERY);
        String clearParams = PARAMS.replaceAll("[\\[\\{\",\\}]", "").replaceAll(":", " ");

        String[] convertParams = clearParams.split(" ");
        int count = 0;
        for (int i = 0; i < convertParams.length; i += 2) {
            if (!convertParams[i + 1].contains("null")) {
                if (count != 0) {
                    myQuery.append(" and ").append(convertParams[i]).append("='").append(convertParams[i + 1]).append("'");
                    count++;
                } else {
                    myQuery.append(convertParams[i]).append("='").append(convertParams[i + 1]).append("'");
                    count++;
                }
            }
        }
        return myQuery;
    }
}

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Printer{
    public static void main(String[] args) {
        String QUERY = "";
        String PARAMS = "";

        if (args.length == 0) {
            // При отправке кода на Выполнение, вы можете варьировать эти параметры
            QUERY = "select * from students where ";
            PARAMS = "{\"name\":\"Ivanov\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"} ";
        }
        else{
            QUERY = args[0];
            PARAMS = args[1];
        }

        Answer ans = new Answer();
        System.out.println(ans.answer(QUERY, PARAMS));
    }
}