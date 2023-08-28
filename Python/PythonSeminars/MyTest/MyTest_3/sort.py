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
