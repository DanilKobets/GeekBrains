#Урок 6. Повторение списков

def func(a=None):
    if a is None:
        a = []
    a.append(1)
    print(a)

func()
func()
func([4, 5, 6])

#Задача 1
# Даны два массива чисел. Требуется вывести те элементы
# первого массива (в том порядке, в каком они идут в первом
# массиве), которых нет во втором массиве. Пользователь вводит
# число N - количество элементов в первом массиве, затем N
# чисел - элементы массива. Затем число M - количество
# элементов во втором массиве. Затем элементы второго массива
# Ввод: Вывод:
# 7 3 3 2 12
# 3 1 3 4 2 4 12
# 6
# 4 15 43 1 15 1

#Вариант 1
def f(a = [],b = []):
    list1 = []
    for i in range(len(a)):
        if a[i] not in b:
            list1.append(a[i])
    return list1      

print(f([1,2,3,4], [1,66,6,5]))

#Вариант 2
def func_input(n):
    print("Вводим элементы нового списка")
    new_list =  []
    for i in range(int(n)):
        buffer = input("Введите новый элемент: ")
        new_list.append(buffer)
    return new_list

def func_sort(n_1,n_2):
    list_1 = set(func_input(n_1))
    list_2 = set(func_input(n_2))
    list_1 = list_1.difference(list_2) #intersection - повторяемые числа list_1 и list_2 #union - объединение #difference - вычитает пересеченые числа
    print(f"Результат операции: {list_1}")


n_1 = int(input("Введите количество элементов первого набора: "))
n_2 = int(input("Введите количество элементов второго набора: "))

func_sort(n_1,n_2)


#Вариант 3
def func(my_list, yours_list):
    answer = list()
    for value in my_list:
        if value not in yours_list:
            answer.append(value)
    return answer


first = int(input("Введите количество элементов первого множества: "))
my_list = list()

for i in range(first):
    value = int(input("Введите элемент первого  множества: "))
    my_list.append(value)

second = int(input("Введите количество элементов второго множества: "))
yours_list = list()

for i in range(second):
    value = int(input("Введите элемент второго  множества: "))
    yours_list.append(value)

print(func(my_list, yours_list))

#Вариант 4
def func(my_list, yours_list):
    answer = list()
    for value in my_list:
        if value not in yours_list:
            answer.append(value)
    return answer

def generation(m):
    my_list = list()
    for i in range(m):
        value = int(input("Введите элемент первого  множества: "))
        my_list.append(value)
    return my_list


m = int(input("Введите количество элементов первого множества: "))
my_list = generation(m)

k = int(input("Введите количество элементов второго множества: "))
yours_list = generation(k)
    
    
#Задача 2
# Дан массив, состоящий из целых чисел. Напишите
# программу, которая в данном массиве определит
# количество элементов, у которых два соседних и, при
# этом, оба соседних элемента меньше данного. Сначала
# вводится число N — количество элементов в массиве
# Далее записаны N чисел — элементы массива. Массив
# состоит из целых чисел.
# Ввод: Ввод:
# 5 5
# 1 2 3 4 5 1 5 1 5 1
# Вывод: Вывод:
# 0 2    


# #Вариант 1
def func(array):
    count = 0
    for i in range(1, len(array) - 1):
        if array[i - 1] < array[i] and array[i + 1] < array[i]:
            count += 1
    return count

array  = [1, 5, 1, 5, 1, 5, 2]
print(func(array))

# #Вариант 2
def func(array):
    count = 0
    for i in range(1, len(array) - 1):
        if array[i - 1] < array[i] > array[i + 1]:
            count += 1
    return count

array  = [1, 5, 1, 5, 1, 5, 2]
print(func(array))

#Задача 3
# Дан список чисел. Посчитайте, сколько в нем пар
# элементов, равных друг другу. Считается, что любые
# два элемента, равные друг другу образуют одну пару,
# которую необходимо посчитать. Вводится список
# чисел. Все числа списка находятся на разных
# строках.
# Ввод: Вывод:
# 1 2 3 2 3 2


#Вариант 1
def search_dbl(start_list):
    count = 0
    for i in range(len(start_list) - 1):
        for j in range(i+1, len(start_list)):
            if start_list[i] == start_list[j]:
                count += 1
    return count

start_list = [1, 2, 1, 2, 2, 3, 4]
print(search_dbl(start_list))

###
# count = 0
# for i in range(len(list_n)-1):
#     count +=  list_n[i+1:].count(list_n[i])
# print(count)
###

#Задача 4
# Два различных натуральных числа n и m называются
# дружественными, если сумма делителей числа n
# (включая 1, но исключая само n) равна числу m и
# наоборот. Например, 220 и 284 – дружественные числа.
# По данному числу k выведите все пары дружественных
# чисел, каждое из которых не превосходит k. Программа
# получает на вход одно натуральное число k, не
# превосходящее 105
# . Программа должна вывести все
# пары дружественных чисел, каждое из которых не
# превосходит k. Пары необходимо выводить по одной в
# строке, разделяя пробелами. Каждая пара должна быть
# выведена только один раз (перестановка чисел новую
# пару не дает).
# Ввод: Вывод:
# 300 220 284


#Вариант 1
def my_func(n):
    sum_dif = 0
    for i in range(1, n // 2 + 1):
        if n % i == 0:
            sum_dif += i
    return sum_dif
print(my_func(n))

k = 300
for i in range(1, k):
    n_1 = my_func(i)
    n_2 = my_func(n_1)
    if n_2 == i and  i != n_1 and n_2 < n_1:
        print(n_2, n_1)
    
#Вариант 2
def func(n):
    sum_mult= 0
    for k in range(1, n // 2 + 1):
        if n % k == 0:
            sum_mult += k
    return sum_mult


n = input("Введите число")
for i  in range(1, n):
    number_1 = func(i)
    for j in range(i+1,n):
        number_2 = func(j)
        if number_1 == number_2:
            print (number_1, number_2)

#Вариант 3
def get_summ(n):
    count = 0
    for i in range(1, n):
        if n % i == 0:
            count += i
    return count


k = 300
for num_1 in range(1, k):
    num_2 = get_summ(num_1)
    sum_del_num_2 = get_summ(num_2)
    
    if (num_1 == sum_del_num_2) and (num_1 != num_2) and (num_1 < num_2):
        print(num_1, num_2)