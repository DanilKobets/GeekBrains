import random
print ("ИГРА В КОНФЕТЫ")
print (" ")
print ("***********************************************")
print ("Правила игры: ")
print ("Перед вами лежит 2021 конфета. Вы поочерёдно с компьютером берёте произвольное число конфет от 1 до 28. Тот, кто возьмёт последнюю конфету - проиграл. Победителю достаются все конфеты! Вы ходите первым. Да начнётся битва!!!")
print ("***********************************************")
print (" ")

# Инициализация переменных
resultCandies = 2021
yourCandies = 0
compCandies = 0
compChoise = 0
yourChoise = 0
stage = 1

while (resultCandies > 0):
  # Начало игры
  if (stage % 2 != 0):
    print ("ХОД # ", stage)
    print ("Перед вами конфет: ", resultCandies)
    print ("Ваш ход: ")
    # Ожидаем ввода цифры с клавы
    yourChoise = int(input ())

  # Проверяем, что введено не больше 28
    while (yourChoise > 28):
      print ("Какой хитрый! Возьмите не более 28 конфет: ")
      # Ожидаем ввода цифры с клавы
      yourChoise = int(input ())

    yourCandies = yourCandies + yourChoise
    resultCandies = resultCandies - yourChoise
    print (" ")
    winner1 = 0
    winner2 = 1
  else:
    print ("ХОД # ", stage)
    print ("Перед вами конфет: ", resultCandies)
    print ("Ход компьютера: ")
    # Запускаем генератор случайных чисел в диапаоне 1 - 28
    compChoise = random.randrange (2, 28, 1)
    if (resultCandies == 1):
      compChoise = 1
    else:
      if (resultCandies < 28):
        compChoise = random.randrange (1, resultCandies, 1)
    print (compChoise)
    compCandies = compCandies + compChoise
    resultCandies = resultCandies - compChoise
    print (" ")
    winner1 = 1
    winner2 = 0
  stage = stage + 1
if (winner1 == 1):
  print ("CONGRATULATIONS! YOU ARE WINNER!!!")
else:
  print ("GAME OVER")