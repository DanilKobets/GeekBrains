# цикл for Перебор всего списка
magicians = ['alice', 'david', 'carolina']
for magician in magicians:
    print(magician)

magicians = ['alice', 'david', 'carolina']
for magician in magicians:
    print(magician.title() + ", that was a great trick!")

magicians = ['alice', 'david', 'carolina']
for magician in magicians:
    print(magician.title() + ", that was a great trick!")
    print("I can't wait to see your next trick, " + magician.title() + ".\n")
print("Thank you, everyone. That was a great magic show!")

# Создание числовых списков
# Функция range()

for value in range(1, 5):
    print(value)
# Использование range() для создания числового списка
numbers = list(range(1, 6))
print(numbers)
# построение списка четных чисел
even_numbers = list(range(2, 11, 2))  # 2 нач знач,11 кон знач, 2 увеличивает на...
print(even_numbers)
# список квадратов всех целых чисел от 1 до 10
squares = []  # создается пустой список с именем squares
for value in range(1, 11):  # перебирает все значения
    square = value**2  # степень числа и сохранение в переменную square
    squares.append(square)  # каждое новое значение square присоединяется к списку squares
print(squares)
# тоже самое только без переменной square, записывается сразу в value
squares = []
for value in range(1, 11):
    squares.append(value**2)
print(squares)

# Простая статистика с числовыми списками
digits = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0]
min = min(digits)
print(min)
max = max(digits)
print(max)
sum = sum(digits)
print(sum)

# Генераторы списков
squares = [value**2 for value in range(1, 11)]
print(squares)  # value**2 квадрат числа

squares = [value for value in range(1, 48, 2)]
print(squares)  # нечетные числа в списке

squares = [value for value in range(0, 48, 2)]
print(squares)  # четные числа в списке
