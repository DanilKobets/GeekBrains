package HomeWork6;

// Подумать над структурой класса Ноутбук для магазина техники - выделить поля и методы. Реализовать в java.
// Создать множество ноутбуков.
// Написать метод, который будет запрашивать у пользователя критерий (или критерии) фильтрации и выведет ноутбуки,
// отвечающие фильтру. Критерии фильтрации можно хранить в Map.

// Например:
// Введите цифру, соответствующую необходимому критерию:
// 1 - ОЗУ
// 2 - Объем ЖД
// 3 - Операционная система
// 4 - Цвет …

// Далее нужно запросить минимальные значения для указанных критериев - сохранить параметры фильтрации
// можно также в Map.
// Отфильтровать ноутбуки из первоначального множества и вывести проходящие по условиям.

// Работу сдать как обычно ссылкой на гит репозиторий

// Частые ошибки:
// 1. Заставляете пользователя вводить все существующие критерии фильтрации
// 2. Невозможно использовать более одного критерия фильтрации одновременно
// 3. При выборке выводятся ноутбуки, которые удовлетворяют только одному фильтру, а не всем введенным пользователем
// 4. Работа выполнена только для каких то конкретных ноутбуков, и если поменять характеристики ноутбуков
// или добавить еще ноутбук, то программа начинает работать некорректно.

import HomeWork6.Laptop;
import java.util.*;

    public class Main {
        public static void main(String[] args) {
            // Создание ноутбука
            Laptop laptop1 = new Laptop("Модель № 1", 8, 256, "Windows", "Black");
            Laptop laptop2 = new Laptop("Модель № 2", 16, 512, "MacOS", "Silver");
            Laptop laptop3 = new Laptop("Модель № 3", 8, 512, "Windows", "White");

            Set<Laptop> laptops = new HashSet<>();
            laptops.add(laptop1);
            laptops.add(laptop2);
            laptops.add(laptop3);

            // Фильтрация ноутбуков по заданным пользователем критериям.
            Map<Integer, Object> filterCriteria = new HashMap<>();
            Scanner scanner = new Scanner(System.in);

            System.out.println("Введите число, соответствующее критерию фильтра:");
            System.out.println("1 - RAM");
            System.out.println("2 - Storage");
            System.out.println("3 - Operating System");
            System.out.println("4 - Color");

            int criterion = scanner.nextInt();
            System.out.println("Введите минимальное значение для выбранного критерия:");
            Object value = null;

            switch (criterion) {
                case 1:
                    int minRam = scanner.nextInt();
                    value = minRam;
                    break;
                case 2:
                    int minStorage = scanner.nextInt();
                    value = minStorage;
                    break;
                case 3:
                    scanner.nextLine();
                    String os = scanner.nextLine();
                    value = os;
                    break;
                case 4:
                    scanner.nextLine();
                    String color = scanner.nextLine();
                    value = color;
                    break;
                default:
                    System.out.println("Выбран неверный критерий!");
                    return;
            }

            filterCriteria.put(criterion, value);
            Set<Laptop> filteredLaptops = filterLaptops(laptops, filterCriteria);

            System.out.println("Ваш список ноутбуков");
            for (Laptop laptop : filteredLaptops) {
                System.out.println("Model: " + laptop.getBrand() +
                        ", RAM: " + laptop.getRam() +
                        ", Storage: " + laptop.getStorage() +
                        ", OS: " + laptop.getOs() +
                        ", Color: " + laptop.getColor());
            }
        }

        public static Set<Laptop> filterLaptops(Set<Laptop> laptops, Map<Integer, Object> filterCriteria) {
            Set<Laptop> filteredLaptops = new HashSet<>(laptops);

            for (Map.Entry<Integer, Object> entry : filterCriteria.entrySet()) {
                int criterion = entry.getKey();
                Object value = entry.getValue();

                switch (criterion) {
                    case 1:
                        filteredLaptops.removeIf(laptop -> laptop.getRam() < (int) value);
                        break;
                    case 2:
                        filteredLaptops.removeIf(laptop -> laptop.getStorage() < (int) value);
                        break;
                    case 3:
                        filteredLaptops.removeIf(laptop -> !laptop.getOs().equalsIgnoreCase((String) value));
                        break;
                    case 4:
                        filteredLaptops.removeIf(laptop -> !laptop.getColor().equalsIgnoreCase((String) value));
                        break;
                    default:
                        System.out.println("Выбран неверный критерий!");
                        return filteredLaptops;
                }
            }

            return filteredLaptops;
        }
    }
