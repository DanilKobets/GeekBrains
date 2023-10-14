package Seminar3;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Random;



public class Main5 {
    /*
Заполнить список названиями планет Солнечной системы в произвольном порядке с повторениями.
Вывести название каждой планеты и количество его повторений в списке.
     */
    public static void main(String[] args) {
        List <String> listPlanets = new ArrayList<>();
        listPlanets.add("Марс");
        listPlanets.add("Юпитер");
        listPlanets.add("Нептун");
        listPlanets.add("Земля");
        listPlanets.add("Венера");
        listPlanets.add("Сатурн");
        listPlanets.add("Уран");
        listPlanets.add("Меркурий");


        List<String> showPlanet = showPlanet(listPlanets, 15);
        System.out.println(showPlanet);
        for (String planet: listPlanets) {
            System.out.print(planet + ": ");
            System.out.println(Collections.frequency(showPlanet, planet));
        }
    }
    static List<String> showPlanet(List <String> listPlanets, int count){
        List <String> showPlanet = new ArrayList<>();
        Random random = new Random();
        for (int i = 0; i < count; i++) {
            String planeta = listPlanets.get(random.nextInt(listPlanets.size()));
            showPlanet.add(planeta);
        }
        return showPlanet;
    }
}