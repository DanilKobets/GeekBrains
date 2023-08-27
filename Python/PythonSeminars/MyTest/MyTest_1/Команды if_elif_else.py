# Команды if
# Простой пример
cars = ['audi', 'bmw', 'subaru', 'toyota']  # есть список машин
for car in cars:
    if car == 'bmw':
        print(car.upper())  # значение 'bmw' должно записываться в верхнем регистре
    else:
        print(car.title())  # остальные значения первая буква в верхнем регистре
# Проверка равенства
car = 'bmw'
if car == 'bmw':
    print(car)
# Проверка равенства без учета регистра
car = 'Audi'
if car.lower() == 'audi':  # проверяем в нижнем регистре
    print(car)
# Проверка неравенства
requested_topping = 'mushrooms'
if requested_topping != 'anchovies':
    print("Hold the anchovies!")
# Сравнения чисел
age = 18
if age == 18:  # проверяем равенство
    print(age)
answer = 17
if answer != 42:  # проверяем неравенство
    print("That is not the correct answer. Please try again!")

# Проверка нескольких условий
# Использование and для проверки нескольких условий, два условия истинны одновременно
age_0 = 22
age_1 = 18
if age_0 >= 21 and age_1 >= 21:
    print("одному из вас нет 21 года")  # одно условие неистинно
age_1 = 22
if age_0 >= 21 and age_1 >= 21:
    print("ура вам обоим есть 21 год")  # оба условия истинны

# Использование or для проверки нескольких условий,хотя бы одно условие истинно
age_0 = 22
age_1 = 18
if age_0 >= 21 or age_1 >= 21:
    print("\nодному из вас нет 21 года")  # хотя бы одно условие истинно

# Проверка вхождения значений в список
requested_toppings = ['mushrooms', 'onions', 'pineapple']
if 'mushrooms' in requested_toppings:
    print(requested_toppings)
if 'pepperoni' in requested_toppings:
    print(requested_toppings)
else:
    print('pepperoni'+' no in the requested_toppings')
# Проверка отсутствия значения в списке
banned_users = ['andrew', 'carolina', 'david']
user = 'marie'
if user not in banned_users:
    print(user.title() + ", you can post a response if you wish.")

# Простые команды if
age = 19
if age >= 18:
    print("\nYou are old enough to vote!")
    print("Have you registered to vote yet?")
# Команды if-else
# существуют всего две возможные ситуации
age = 17
if age >= 18:
    print("\nYou are old enough to vote!")
    print("Have you registered to vote yet?")
else:
    print("\nSorry, you are too young to vote.")
    print("Please register to vote as soon as you turn 18!")
# Цепочки if-elif-else
# существуют более двух возможных ситуаций
age = 19
if age < 4:
    print("\nYour admission cost is $0.")
elif age < 18:
    print("\nYour admission cost is $5.")

else:
    print("\nYour admission cost is $10.")
# тоже самое только иначе
age = 12
if age < 4:
    price = 0
elif age < 18:
    price = 5
else:
    price = 10
print("\nYour admission cost is $" + str(price) + ".")
# Серии блоков elif
age = 67
if age < 4:
    price = 0
elif age < 18:
    price = 5
elif age < 65:
    price = 10
else:
    price = 5
print("\nВаша плата составит $" + str(price) + ".")
# тоже самое только иначе
age = 68
if age < 4:
    price = 0
elif age < 18:
    price = 5
elif age < 65:
    price = 10
elif age >= 65:
    price = 5
print("Ваша плата составит $" + str(price) + ".")

# Проверка нескольких условий
requested_toppings = ['mushrooms', 'extra cheese']
if 'mushrooms' in requested_toppings:
    print("\nAdding mushrooms.")
if 'pepperoni' in requested_toppings:
    print("\nAdding pepperoni.")
if 'extra cheese' in requested_toppings:
    print("Adding extra cheese.")
print("Finished making your pizza!")
# Множественные списки
print("\n")
available_toppings = ['mushrooms', 'olives', 'green peppers', 'pepperoni', 'pineapple', 'extra cheese']
requested_toppings = ['mushrooms', 'french fries', 'extra cheese']
for requested_topping in requested_toppings:
    if requested_topping in available_toppings:
        print("Adding " + requested_topping + ".")
    else:
        print("Sorry, we don't have " + requested_topping + ".")
print("\nFinished making your pizza!")






