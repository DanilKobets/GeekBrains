#
# n = int(input())
#
# # Петя и Сережа сделали одинаковое количество журавликов
# num_pet_serg = n // 4
#
# # Катя сделала в два раза больше журавликов, чем Петя и Сережа вместе
# num_katya = 2 * (num_pet_serg + num_pet_serg)
#
# # Выводим результат
# print(num_pet_serg, num_katya, num_pet_serg)


# Вы пользуетесь общественным транспортом? Вероятно, вы расплачивались за проезд и получали билет с номером.
#
# Счастливым билетом называют такой билет с шестизначным номером, где сумма первых трех цифр равна сумме последних трех.
#
# Т.е. билет с номером 385916 – счастливый, т.к. 3+8+5=9+1+6.
#
# Вам требуется написать программу, которая проверяет счастливость билета с номером n и выводит на экран yes или no.
#
# Пример:
#
#
# n = 385916 -> yes
# n = 123456 -> no





#/////

#Задача 10: На столе лежат n монеток. Некоторые из них лежат вверх решкой, а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть, чтобы все монетки были повернуты вверх одной и той же стороной. Выведите минимальное количество монет, которые нужно перевернуть

# N = int(input('Введите количество монет '))
# orel = reshka = 0
# for i in range(N):
#     x = int(input('Орел(1) или решка(0)? '))
#     if x == 1:
#         orel += 1
#     else:
#         reshka += 1
# if orel < reshka:
#     print(f'Переверните {orel} монет с орла на решку, их меньше всего')
# elif orel == reshka:
#     print(f'Количество орлов и решек одинаково, по {orel} штук')
# else:
#     print((f'Переверните {reshka} монет с решки на орла, их меньше всего'))
    



#Задача 12: Петя и Катя – брат и сестра. Петя – студент, а Катя – школьница. Петя помогает Кате по математике. Он задумывает два натуральных числа X и Y (X,Y≤1000), а Катя должна их отгадать. Для этого Петя делает две подсказки. Он называет сумму этих чисел S и их произведение P. Помогите Кате отгадать задуманные Петей числа.


# def find_numbers(S, P):
#     for X in range(1, S+1):
#         if 1 <= S - X <= 1000:
#             Y = S - X
#             if X * Y == P:
#                 return X, Y
    
#     return None

# S = abs(int(input('Введите первое натуральное число X от 1 до 1000 ')))
# P = abs(int(input('Введите второе натуральное число Y от 1 до 1000 ')))
# numbers = find_numbers(S, P)
# print(numbers) 


#Задача 14: Требуется вывести все целые степени двойки (т.е. числа вида 2k), не превосходящие числа N.

# N = abs(int(input('Введите число N ')))
# stop = 0
# P = 2
# for i in range(N):
#     if stop != 1:
#         P = P ** i
#         if P <= N:
#             print(P, end=' ')
#             P = 2
#         else:
#             stop = 1
#     else:
#         i = N




#////




#По данному целому неотрицательному n вычислите значение n!. N! = 1 * 2 * 3 * … * N (произведение всех чисел от 1 до N) 0! = 1 Решить задачу используя цикл while

#fact = int(input("Введите число ->"))
#i = 1
#res = 1
#while i <= fact:
##    res *= i
#     res = res * i
#     i += 1
# print(res)


# Задача №11. Решение в группах
# Дано натуральное число A > 1. Определите, каким по
# счету числом Фибоначчи оно является, то есть
# выведите такое число n, что φ(n)=A. Если А не
# является числом Фибоначчи, выведите число -1.
# Input: 5
# Output: 6



# #
# a = int(input())

# i = 2
# fib_1 = 0
# fib_2 = 1

# while fib_2 < a:
#     fib_1, fib_2 = fib_2, fib_1 + fib_2

# # buff = fib_2
# # fib_2 = fib_1 + fib_2
# # fib_1 = buff

# i += 1

# if fib_2 == a:
#     print(i)
# else:
#     print(-1)


# Задача №13. Решение в группах
# Уставшие от необычно теплой зимы, жители решили узнать,
# действительно ли это самая длинная оттепель за всю историю
# наблюдений за погодой. Они обратились к синоптикам, а те, в
# свою очередь, занялись исследованиями статистики за
# прошлые годы. Их интересует, сколько дней длилась самая
# длинная оттепель. Оттепелью они называют период, в
# который среднесуточная температура ежедневно превышала
# 0 градусов Цельсия. Напишите программу, помогающую
# синоптикам в работе.
# Пользователь вводит число N – общее количество
# рассматриваемых дней (1 ≤ N ≤ 100). В следующих строках
# располагается N целых чисел.
# Каждое число – среднесуточная температура в
# соответствующий день. Температуры – целые числа и лежат в
# диапазоне от –50 до 50
# Input: 6 -> -20 30 -40 50 10 -10
# Output: 2


# range(5) -> 0, 1, 2, 3, 4
# range(5, 10) -> 5, 6, 7, 8, 9
# range(1, 10, 2) -> 1, 3, 5, 7, 9
# print(range(5))
#

# n = int(input())
# count = 0
# max_day = 0
# # -1 2 3 -4 5
# for _ in range(n):
# temp = int(input('temp: '))
# if temp > 0:
# count += 1
# if count > max_day:
# max_day = count
# if temp <= 0:
# count = 0

# print(max_day)






# n = int(input('Enter n:'))

# count = 0
# maximum = 0
# for i in range(n):
# temp = int(input('Enter temp: '))
# if temp > 0:
# count += 1
# else:
# maximum = count
# count = 0

# print("Ответ: ", maximum)




# Задача №15. Решение в группах
# 15. Иван Васильевич пришел на рынок и решил
# купить два арбуза: один для себя, а другой для тещи.
# Понятно, что для себя нужно выбрать арбуз
# потяжелей, а для тещи полегче. Но вот незадача:
# арбузов слишком много и он не знает как же выбрать
# самый легкий и самый тяжелый арбуз? Помогите ему!
# Пользователь вводит одно число N – количество
# арбузов. Вторая строка содержит N чисел,
# записанных на новой строчке каждое. Здесь каждое
# число – это масса соответствующего арбуза
# Input: 5 -> 5 1 6 5 9
# Output: 1 9

# n = int(input())
# arbuz = int(input('Вес первого арбуза -> '))
# max = arbuz
# min = arbuz
# for _ in range(n-1):
#     arbuz = int(input('Вес арбуза -> '))
#     if arbuz > max:
#         max = arbuz
#     if arbuz < min:
#         min = arbuz
# print (F'{max} {min}')






#Алгоритмы (сем2)

# def calc_count(sp):
# total = 0
# for item in sp:
# # if str(type(item)) == "<class 'list'>":
# if isinstance(item, list):
# total = total + calc_count(item)
# else:
# total += item
# return total



# count_angola = 18
# count_new_york = [20, [10, 7]]
# count_chicago = 15
# count_usa = [count_new_york,count_chicago ]
# count_all = [count_angola, count_usa]
# print(count_all)
# print(type(count_all))
# print(calc_count(count_all))


# 1.Написать алгоритм быстрого поиска (quicksort).

# Задание 4 (тайминг 15 минут)
# 1.После успешной сортировки массива на нем можно использовать бинарный
# поиск. Необходимо реализовать алгоритм бинарного поиска по
# элементам.
# 2.Стоит акцентировать внимание, что т.к. алгоритм использует подход
# «разделяй и властвуй», его удобно писать с помощью рекурсии.
# 3.Так что стоит акцентировать внимание на алгоритмическую сложность
# данного алгоритма, что его выполнение многократно быстрее простого
# перебора на больших массивах


# from random import randint
# from time import time


# # Генерация списка
# def list_gen(min_value=-5, max_value=5, lst_len=10):
#     return [randint(min_value, max_value) for i in range(lst_len)]


# # Текстовый разделитель
# def text_separator(message='', line_len=60):
#     part_line = int(line_len - len(message)) // 2 if int(line_len - len(message)) // 2 > 0 else 0
#     print(f"{'-' * part_line}{message}{'-' * part_line}")


# # Замер временных рамок
# def running_time(func, x):
#     starting = time()
#     returned_value = func(x)
#     duration = time() - starting
#     print(f'Выполнение за {duration} сек.')
#     if returned_value is not None:
#         return returned_value


# # Алгоритм: Сортировка пузырьком
# def bubble_sort(lst):
#     for i in range(len(lst)):
#         for j in range(len(lst) - 1 - i):
#             if lst[j] > lst[j + 1]:
#                 lst[j], lst[j + 1] = lst[j + 1], lst[j]
#     return lst


# # Алгоритм: Быстрая сортировка
# def quick_sort(lst):
#     if len(lst) <= 1:
#         return lst
#     pivot = lst[len(lst) // 2]
#     left = list(filter(lambda x: x < pivot, lst))
#     center = [i for i in lst if i == pivot]
#     right = list(filter(lambda x: x > pivot, lst))
#     return quick_sort(left) + center + quick_sort(right)


# # Алгоритм: Быстрая сортировка (вариант из stack overflow)
# # https://stackoverflow.com/questions/18262306/quicksort-with-python
# def sort(array):
#     """Sort the array by using quicksort."""
#     less = []
#     equal = []
#     greater = []
#     if len(array) > 1:
#         pivot = array[0]
#         for x in array:
#             if x < pivot:
#                 less.append(x)
#             elif x == pivot:
#                 equal.append(x)
#             elif x > pivot:
#                 greater.append(x)
#         return sort(less)+equal+sort(greater)
#     else:
#         return array


# # Алгоритм: Сортировка подсчетом
# def counting_sort(sp):
#     max_item = max(sp)
#     lst = [0 for _ in range(max_item + 1)]
#     for i in sp:
#         lst[i] = lst[i] + 1
#     index = 0
#     # for i in range(len(lst)):
#     #     for j in range(lst[i]):
#     #         sp[index]=i
#     #         index+=1
#     # Ушли от двух вложенных циклов следующим кодом
#     res_sp = []
#     for i in range(len(lst)):
#         if lst[i]:
#             res_sp.extend([i] * lst[i])
#     return res_sp


# # Алгоритм: Бинарный поиск (вариант с рекурсией, на вход требуется заранее отсортированный список)
# def binary_search_rec(lst, value, left, right):
#     if right < left:
#         return None
#     middle_point = (right - left) // 2 + left
#     if lst[middle_point] < value:
#         return binary_search_rec(lst, value, middle_point + 1, right)
#     elif lst[middle_point] > value:
#         return binary_search_rec(lst, value, left, middle_point - 1)
#     else:
#         return middle_point


# # Алгоритм: Бинарный поиск (вариант без рекурсии, на вход требуется заранее отсортированный список)
# def binary_search(in_list: list, value: int):
#     left = 0
#     right = len(in_list) - 1
#     current = (right + left) // 2
#     while in_list[current] != value:
#         if right < left:
#             return None
#         if in_list[current] < value:
#             left = current + 1
#         else:
#             right = current - 1
#         current = (right + left) // 2
#     return current


# # Тестирование алгоритмов
# text_separator(' Сортировка пузырьком ')
# my_list = list_gen(1, 10, 10_000)
# print(my_list) if len(my_list) <= 20 else print(f'Кол-во элементов {len(my_list):,}')
# running_time(bubble_sort, my_list)
# print(my_list) if len(my_list) <= 20 else None

# text_separator(' Быстрая сортировка ')
# my_list = list_gen(-100_000, 100_000, 1_000_000)
# print(my_list) if len(my_list) <= 20 else print(f'Кол-во элементов {len(my_list):,}')
# my_list_sorted = running_time(quick_sort, my_list)
# print(my_list_sorted) if len(my_list_sorted) <= 20 else None

# text_separator(' Быстрая сортировка (вариант из stackoverflow) ')
# my_list = list_gen(-100_000, 100_000, 1_000_000)
# print(my_list) if len(my_list) <= 20 else print(f'Кол-во элементов {len(my_list):,}')
# my_list_sorted = running_time(sort, my_list)
# print(my_list_sorted) if len(my_list_sorted) <= 20 else None

# text_separator(' Встроенная сортировка Python ')
# my_list = list_gen(-100_000, 100_000, 1_000_000)
# print(my_list) if len(my_list) <= 20 else print(f'Кол-во элементов {len(my_list):,}')
# my_list_sorted = running_time(sorted, my_list)
# print(my_list_sorted) if len(my_list_sorted) <= 20 else None

# text_separator(' Сортировка подсчетом ')
# sp = list_gen(-100_000, 100_000, 1_000_000)
# print(sp) if len(sp) <= 20 else print(f'Кол-во элементов {len(sp):,}')
# sp2 = running_time(counting_sort, sp)
# print(sp2) if len(sp2) <= 20 else None

# text_separator(' Бинарный поиск (с рекурсией) ')
# value_to_search = 0  # Искомое число
# print(my_list_sorted) if len(my_list_sorted) <= 20 else print(f'Кол-во элементов {len(my_list_sorted):,}')
# starting = time()
# i = binary_search_rec(my_list_sorted, value_to_search, 0, len(my_list_sorted) - 1)
# duration = time() - starting
# print(f'Искомое число {my_list_sorted[i]} найдено по индексу {[i]}.') if i else print('Искомое число не найдено.')
# print(f'Выполнение за {duration} сек.')

# text_separator(' Бинарный поиск (без рекурсии) ')
# value_to_search = 0  # Искомое число
# print(my_list_sorted) if len(my_list_sorted) <= 20 else print(f'Кол-во элементов {len(my_list_sorted):,}')
# starting = time()
# i = binary_search(my_list_sorted, value_to_search)
# duration = time() - starting
# print(f'Искомое число {my_list_sorted[i]} найдено по индексу {[i]}.') if i else print('Искомое число не найдено.')
# print(f'Выполнение за {duration} сек.')



##################################
# def counting_sort (arr):
#     min_value = min(arr)
#     max_value = max(arr)
#     range_values = max_value - min_value + 1
#     count = [0] * range_values
    
#     for num in arr:
#         count[num - min_value] += 1
    
#     sorted_arr = []
#     for i in range(range_values):
#         for _ in range(count[i]):
#             sorted_arr.append(i + min_value)
    
#     return sorted_arr

# # Пример использования:
# arr = [-5, -3, 2, 0, 1, 4, -1]
# sorted_arr = counting_sort(arr)
# print(arr)
# print("-"*50)
# print(sorted_arr)  # Вывод: [-5, -3, -1, 0, 1, 2, 4]

# print("-"*50)
# print("-"*50)

# import random

# def generate_list():
#     length = random.randint(5, 10)  # случайная длина списка от 5 до 10
#     min_value = random.randint(-100, 0)  # случайное минимальное значение от -100 до 0
#     max_value = random.randint(1, 100)  # случайное максимальное значение от 1 до 100
#     lst = [random.randint(min_value, max_value) for _ in range(length)]
#     return lst

# # Пример использования:
# lst = generate_list()
# print(lst)  # Вывод: случайный список чисел

# print("-"*50)
# print("-"*50)

# def choose_sorting_algorithm(lst):
#     if max(lst) - min(lst):
#         return "Counting Sort"
#     else:
#         return "Quick Sort"

# # Пример использования:
# sorting_algorithm = choose_sorting_algorithm(lst)
# print(sorting_algorithm)  # Вывод: "Counting Sort" или "Quick Sort"

# print("-"*50)
# print("-"*50)

# import time

# def sort_and_save_initial_order(lst, algorithm):
#     start_time = time.time()
    
#     if algorithm == "Counting Sort":
#         sorted_lst = counting_sort(lst)
#     else:
#         sorted_lst = quick_sort(lst)
    
#     elapsed_time = time.time() - start_time
#     return sorted_lst, elapsed_time

# # Пример использования:
# sorted_lst, elapsed_time = sort_and_save_initial_order(lst, sorting_algorithm)
# print(sorted_lst)  # Вывод: отсортированный список чисел
# print(elapsed_time)  # Вывод: время выполнения сортировки


# print("-"*50)
# print("-"*50)

# def binary_search(lst, target):
#     low = 0
#     high = len(lst) - 1
    
#     while low &lt;= high:
#         mid = (low + high) // 2
#         if lst[mid] == target:
#             return mid
#         elif lst[mid] &lt; target:
#             low = mid + 1
#         else:
#             high = mid - 1
    
#     return -1

# # Пример использования:
# target = int(input("Введите число: "))
# index = binary_search(sorted_lst, target)
# print(index)  # Вывод: индекс первого вхождения числа в отсортированном списке


# print("-"*50)
# print("-"*50)

# def find_original_indexes(lst, target):
#     indexes = []
#     for i, num in enumerate(lst):
#         if num == target:
#             indexes.append

##################################


# def heapify(arr, n, i):
#     largest = i
#     left = 2 * i + 1
#     right = 2 * i + 2
  
#     if left < n and arr[i] < arr[left]:
#         largest = left
  
#     if right < n and arr[largest] < arr[right]:
#         largest = right
  
#     if largest != i:
#         arr[i], arr[largest] = arr[largest], arr[i] # обмен элементов
  
#     heapify(arr, n, largest)
  
  
# def heap_sort(arr):
#     n = len(arr)
  
#     for i in range(n // 2 - 1, -1, -1):
#         heapify(arr, n, i)
  
#     for i in range(n-1, 0, -1):
#         arr[i], arr[0] = arr[0], arr[i] # обмен элементов
#         heapify(arr, i, 0)


# # Пример использования:

# print(heapify)
# arr = [12, 11, 13, 5, 6, 7]
# heap_sort(arr)
# print("Отсортированный массив:")
# print(arr)


# # Вывод:
# # Отсортированный массив:
# # [5, 6, 7, 11, 12, 13]


#######
# Реализация пирамидальной сортировки на Python

# Процедура для преобразования в двоичную кучу поддерева с корневым узлом i, что является индексом в arr[]. n - размер кучи
# def heapify(arr, n, i):
#     largest = i # Initialize largest as root
#     l = 2 * i + 1   # left = 2*i + 1
#     r = 2 * i + 2   # right = 2*i + 2

#   # Проверяем существует ли левый дочерний элемент больший, чем корень

#     if l < n and arr[i] < arr[l]:
#         largest = l

#     # Проверяем существует ли правый дочерний элемент больший, чем корень

#     if r < n and arr[largest] < arr[r]:
#         largest = r

#     # Заменяем корень, если нужно
#     if largest != i:
#         arr[i],arr[largest] = arr[largest],arr[i] # свап

#         # Применяем heapify к корню.
#         heapify(arr, n, largest)

# # Основная функция для сортировки массива заданного размера
# def heapSort(arr):
#     n = len(arr)

#     # Построение max-heap.
#     for i in range(n, -1, -1):
#         heapify(arr, n, i)

#     # Один за другим извлекаем элементы
#     for i in range(n-1, 0, -1):
#         arr[i], arr[0] = arr[0], arr[i] # свап 
#         heapify(arr, i, 0)

# # Управляющий код для тестирования
# arr = [ -10, 1, 134, 0, 6, 17]
# heapSort(arr)
# n = len(arr)
# print ("Sorted array is")
# print(arr)
# for i in range(n):
#     print ("%d" %arr[i]),






from random import randint
from time import time


# Генерация списка
def list_gen(min_value=-5, max_value=5, lst_len=10):
    return [randint(min_value, max_value) for i in range(lst_len)]


# Текстовый разделитель
def text_separator(message='', line_len=60):
    part_line = int(line_len - len(message)) // 2 if int(line_len - len(message)) // 2 > 0 else 0
    print(f"{'-' * part_line}{message}{'-' * part_line}")


# Замер временных рамок
def running_time(func, x):
    starting = time()
    returned_value = func(x)
    duration = time() - starting
    print(f'Выполнение за {duration} сек.')
    if returned_value is not None:
        return returned_value


# Алгоритм: Сортировка пузырьком
def bubble_sort(lst):
    for i in range(len(lst)):
        for j in range(len(lst) - 1 - i):
            if lst[j] > lst[j + 1]:
                lst[j], lst[j + 1] = lst[j + 1], lst[j]
    return lst


# Алгоритм: Быстрая сортировка
def quick_sort(lst):
    if len(lst) <= 1:
        return lst
    pivot = lst[len(lst) // 2]
    left = list(filter(lambda x: x < pivot, lst))
    center = [i for i in lst if i == pivot]
    right = list(filter(lambda x: x > pivot, lst))
    return quick_sort(left) + center + quick_sort(right)


# Алгоритм: Быстрая сортировка (вариант из stack overflow)
# https://stackoverflow.com/questions/18262306/quicksort-with-python
def sort(array):
    """Sort the array by using quicksort."""
    less = []
    equal = []
    greater = []
    if len(array) > 1:
        pivot = array[0]
        for x in array:
            if x < pivot:
                less.append(x)
            elif x == pivot:
                equal.append(x)
            elif x > pivot:
                greater.append(x)
        return sort(less)+equal+sort(greater)
    else:
        return array


# Алгоритм: Сортировка подсчетом
""" Не поддерживаются отрицательные значения """
def counting_sort(sp):
    max_item = max(sp)
    lst = [0 for _ in range(max_item + 1)]
    for i in sp:
        lst[i] = lst[i] + 1
    index = 0
    # for i in range(len(lst)):
    #     for j in range(lst[i]):
    #         sp[index]=i
    #         index+=1
    # Ушли от двух вложенных циклов следующим кодом
    res_sp = []
    for i in range(len(lst)):
        if lst[i]:
            res_sp.extend([i] * lst[i])
    return res_sp


# Алгоритм: Бинарный поиск (вариант с рекурсией, на вход требуется заранее отсортированный список)
def binary_search_rec(lst, value, left, right):
    if right < left:
        return None
    middle_point = (right - left) // 2 + left
    if lst[middle_point] < value:
        return binary_search_rec(lst, value, middle_point + 1, right)
    elif lst[middle_point] > value:
        return binary_search_rec(lst, value, left, middle_point - 1)
    else:
        return middle_point


# Алгоритм: Бинарный поиск (вариант без рекурсии, на вход требуется заранее отсортированный список)
def binary_search(in_list: list, value: int):
    left = 0
    right = len(in_list) - 1
    current = (right + left) // 2
    while in_list[current] != value:
        if right < left:
            return None
        if in_list[current] < value:
            left = current + 1
        else:
            right = current - 1
        current = (right + left) // 2
    return current


# Тестирование алгоритмов
text_separator(' Сортировка пузырьком ')
my_list = list_gen(1, 10, 10_000)
print(my_list) if len(my_list) <= 20 else print(f'Кол-во элементов {len(my_list):,}')
running_time(bubble_sort, my_list)
print(my_list) if len(my_list) <= 20 else None

text_separator(' Быстрая сортировка ')
my_list = list_gen(-100_000, 100_000, 1_000_000)
print(my_list) if len(my_list) <= 20 else print(f'Кол-во элементов {len(my_list):,}')
my_list_sorted = running_time(quick_sort, my_list)
print(my_list_sorted) if len(my_list_sorted) <= 20 else None

text_separator(' Быстрая сортировка (вариант из stack overflow) ')
my_list = list_gen(-100_000, 100_000, 1_000_000)
print(my_list) if len(my_list) <= 20 else print(f'Кол-во элементов {len(my_list):,}')
my_list_sorted = running_time(sort, my_list)
print(my_list_sorted) if len(my_list_sorted) <= 20 else None

text_separator(' Встроенная сортировка Python ')
my_list = list_gen(-100_000, 100_000, 1_000_000)
print(my_list) if len(my_list) <= 20 else print(f'Кол-во элементов {len(my_list):,}')
my_list_sorted = running_time(sorted, my_list)
print(my_list_sorted) if len(my_list_sorted) <= 20 else None

text_separator(' Сортировка подсчетом ')
sp = list_gen(1, 200_000, 1_000_000)
print(sp) if len(sp) <= 20 else print(f'Кол-во элементов {len(sp):,}')
sp2 = running_time(counting_sort, sp)
print(sp2) if len(sp2) <= 20 else None

text_separator(' Бинарный поиск (с рекурсией) ')
value_to_search = 0  # Искомое число
print(my_list_sorted) if len(my_list_sorted) <= 20 else print(f'Кол-во элементов {len(my_list_sorted):,}')
starting = time()
i = binary_search_rec(my_list_sorted, value_to_search, 0, len(my_list_sorted) - 1)
duration = time() - starting
print(f'Искомое число {my_list_sorted[i]} найдено по индексу {[i]}.') if i else print('Искомое число не найдено.')
print(f'Выполнение за {duration} сек.')

text_separator(' Бинарный поиск (без рекурсии) ')
value_to_search = 0  # Искомое число
print(my_list_sorted) if len(my_list_sorted) <= 20 else print(f'Кол-во элементов {len(my_list_sorted):,}')
starting = time()
i = binary_search(my_list_sorted, value_to_search)
duration = time() - starting
print(f'Искомое число {my_list_sorted[i]} найдено по индексу {[i]}.') if i else print('Искомое число не найдено.')
print(f'Выполнение за {duration} сек.')
