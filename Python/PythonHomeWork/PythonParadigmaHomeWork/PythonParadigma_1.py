# Императивное программирование:
# Задача 1: Подсчет суммы четных чисел от 1 до N. Напишите программу, используя цикл, которая находит сумму всех четных чисел в диапазоне от 1 до заданного числа N.

n = int(input("Введите значение N: "))

sum_even = 0

for i in range(1, n + 1):
    if i % 2 == 0:
        sum_even += i

print("Сумма четных чисел от 1 до", n, "равна", sum_even)


# Задача 2: Поиск наименьшего числа в списке. Напишите программу, которая находит наименьшее число в заданном списке с помощью цикла.

n = int(input("Введите кол-во чисел: "))
numbers = []

for i in range(n):
    num = int(input("Введите число: "))
    numbers.append(num)

min_num = numbers[0]

for num in numbers:
    if num < min_num:
        min_num = num

print(f"Наименьшее число: {min_num}")

# Декларативное программирование:
# Задача 3: Вычисление факториала числа. Напишите программу, которая находит факториал заданного числа N с использованием рекурсии или встроенных функций.

def factorial(n):
    if n == 0:
        return 1
    else:
        return n * factorial(n - 1)

n = int(input("Введите число: "))
result = factorial(n)
print("Факториал числа", n, "равен", result) 

# Задача 4: Поиск уникальных элементов в списке. Напишите программу, которая создает новый список, содержащий только уникальные элементы из исходного списка.

def find_unique_elements(lst):
    unique_lst = []  # создаем новый список для уникальных элементов
    for element in lst:  # перебираем элементы исходного списка
        if element not in unique_lst:  # если элемент еще не добавлен в уникальный список
            unique_lst.append(element)  # добавляем его в уникальный список
    return unique_lst

# пример использования функции
my_list = [1, 2, 3, 4, 2, 3, 5]
result = find_unique_elements(my_list)
print(result)  # вывод: [1, 2, 3, 4, 5]


