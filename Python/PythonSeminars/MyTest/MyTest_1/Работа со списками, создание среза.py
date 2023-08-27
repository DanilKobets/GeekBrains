# Работа с частью списка
# Создание среза (slices)
players = ['charles', 'martina', 'michael', 'florence', 'eli']
print(players[0:3]) # следует задать индексы первого и последнего элементов

players = ['charles', 'martina', 'michael', 'florence', 'eli']
print(players[1:4]) # следует задать индексы первого и последнего элементов

players = ['charles', 'martina', 'michael', 'florence', 'eli']
print(players[:4]) # Если первый индекс среза не указан, то автоматически начинает срез от начала списка:

players = ['charles', 'martina', 'michael', 'florence', 'eli']
print(players[-3:])  # срез от конца списка

# Перебор содержимого среза
players = ['charles', 'martina', 'michael', 'florence', 'eli']
print("Here are the first three players on my team:")
for player in players[:3]:
    print(player.title())  # программа перебирает первых трех игроков и выводит их имена

# Копирование списка, созданием среза
my_foods = ['pizza', 'falafel', 'carrot cake']
friend_foods = my_foods[:]  # [:] срез, включающий весь исходный список
print("My favorite foods are:")
print(my_foods)
print("\nMy friend's favorite foods are:")
print(friend_foods)
# доказываем что это разные списки, добавим разные элементы
my_foods = ['pizza', 'falafel', 'carrot cake']
friend_foods = my_foods[:]  # если убрать срез [:], то будет один и тот же список, а не разные!!!
my_foods.append('cannoli')
friend_foods.append('ice cream')
print("My favorite foods are:")
print(my_foods)
print("\nMy friend's favorite foods are:")
print(friend_foods)

