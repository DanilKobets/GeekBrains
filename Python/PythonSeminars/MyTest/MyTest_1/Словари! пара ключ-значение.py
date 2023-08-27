# словари!!! пара «ключ—значение»
# Обращение к значениям в словаре
alien_0 = {'color': 'green', 'points': 5}  # словарь
new_points = alien_0['points']  # извлекаем значение 'points' и сохраняем в new_points
print("You just earned " + str(new_points) + " points!")  # выводим значение new_points
# Чтобы получить значение, связанное с ключом, укажите имя словаря, а затем ключ в квадратных скобках:
# alien_0 = {'color': 'green'}
# print(alien_0['color'])

# Добавление новых пар «ключ—значение»
alien_0 = {'color': 'green', 'points': 5}
print(alien_0)
alien_0['x_position'] = 0
alien_0['y_position'] = 25
print(alien_0)

# Создание пустого словаря
print("\n")
alien_0 = {}
alien_0['color'] = 'green'
alien_0['points'] = 5
print(alien_0)

# Изменение значений в словаре
alien_0 = {'color': 'green'}
print("\nThe alien is " + alien_0['color'] + ".")
alien_0['color'] = 'yellow'  # меняем значение в словаре
print("The alien is now " + alien_0['color'] + ".")

# пример сложнее
# определяется словарь с исходной позицией (координаты x и y) и скоростью 'medium'
alien_0 = {'x_position': 0, 'y_position': 25, 'speed': 'medium'}
print("\nOriginal x-position: " + str(alien_0['x_position']))
# Пришелец перемещается вправо.Вычисляем величину смещения на основании текущей скорости.
if alien_0['speed'] == 'slow':
    x_increment = 1
elif alien_0['speed'] == 'medium':
    x_increment = 2
else:
    x_increment = 3  # Пришелец двигается быстро.
# Новая позиция равна сумме старой позиции и приращения.
alien_0['x_position'] = alien_0['x_position'] + x_increment
print("New x-position: " + str(alien_0['x_position']))

# Удаление пар «ключ—значение»
alien_0 = {'color': 'green', 'points': 5}
print(alien_0)
del alien_0['points']  # удаляем пару ключ значение
print(alien_0)

# Словарь с однотипными объектами
favorite_languages = {
    'jen': 'python',
    'sarah': 'c',
    'edward': 'ruby',
    'phil': 'python',
    }
print("Sarah's favorite language is " +
      favorite_languages['sarah'].title() +
      ".")
# Перебор словаря

# Перебор всех пар «ключ—значение», метод items(),
# все данные из словаря этого пользователя
user_0 = {
    'username': 'efermi',
    'first': 'enrico',
    'last': 'fermi',
    }
for key, value in user_0.items():
    print("\nKey: " + key)
    print("Value: " + value)
# еще пример
favorite_languages = {
    'jen': 'python',
    'sarah': 'c',
    'edward': 'ruby',
    'phil': 'python',
    }
print("\n")
for name, language in favorite_languages.items():
    print(name.title() + "'s favorite language is " +
          language.title() + ".")

# Перебор всех ключей в словаре, Метод keys()
# вы не собираетесь работать со всеми значениями в словаре
favorite_languages = {
    'jen': 'python',
    'sarah': 'c',
    'edward': 'ruby',
    'phil': 'python',
    }
print("\n")
for name in favorite_languages.keys():  # аналогично for name in favorite_languages:
    print(name.title())
# еще пример, выведем для пары друзей сообщение о выбранном ими языке
favorite_languages = {
    'jen': 'python',
    'sarah': 'c',
    'edward': 'ruby',
    'phil': 'python',
    }
print("\n")
friends = ['phil', 'sarah']  # список друзей, для которых должно выводиться сообщение
for name in favorite_languages.keys():  # В цикле выводится имя очередного участника опроса
    print(name.title())
    if name in friends:  # проверяет, входит ли текущее имя в список друзей.
        print(" Hi " + name.title() +
              ", I see your favorite language is " +
              favorite_languages[name].title() + "!")  # выводится специальное приветствие

# может использоваться для проверки, участвовал ли конкретный человек в опросе
favorite_languages = {
    'jen': 'python',
    'sarah': 'c',
    'edward': 'ruby',
    'phil': 'python',
    }
print("\n")
if 'erin' not in favorite_languages.keys():
    print("Erin, please take our poll!")  # Так как ключ в списке отсутствует, программа выводит сообщение

# Упорядоченный перебор ключей словаря
# Для получения упорядоченной копии ключей можно воспользоваться функцией sorted()
favorite_languages = {
    'jen': 'python',
    'sarah': 'c',
    'edward': 'ruby',
    'phil': 'python',
    }
print("\n")
for name in sorted(favorite_languages.keys()):  # список всех ключей в словаре и отсортировать его
    print(name.title() + ", thank you for taking the poll.")

# Перебор всех значений в словаре
# метод values() для получения списка значений без ключей
# без проверки на возможные повторения
favorite_languages = {
    'jen': 'python',
    'sarah': 'c',
    'edward': 'ruby',
    'phil': 'python',
    }
print("\n")
print("The following languages have been mentioned:")
# for читает каждое значение из словаря и сохраняет его в переменной language
for language in favorite_languages.values():
    print(language.title())

# список выбранных языков без повторений, можно воспользоваться множеством (set)
favorite_languages = {
    'jen': 'python',
    'sarah': 'c',
    'edward': 'ruby',
    'phil': 'python',
    }
print("\n")
print("The following languages have been mentioned:")
# создается не содержащий дубликатов список множеством (set)
for language in set(favorite_languages.values()):
    print(language.title())

