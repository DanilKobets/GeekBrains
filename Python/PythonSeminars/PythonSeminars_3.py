# Урок 3. Списки и словари
#Задача 1
# Дан список чисел. Определите, сколько в нем встречается различных чисел.
# Input: [1, 1, 2, 0, -1, 3, 4, 4]
# Output: 6

#Метод срез#
arr = [1, 1, 2, 0, -1, 3, 4, 4]
count = 0
for i in range(len(arr)):
    if(arr[i]) not in arr[:i]:
        count += 1
print(count)

#Метод множество#
arr = [1, 1, 2, 0, -1, 3, 4, 4]
arr = set(arr) #set убирает повторяющие числа
print(len(arr))

метод множеств в строку#
answer = list(set(arr)) #в строку
print(answer)

#Метод списками#
my_list = [1, 1, 2, 0, -1, 3, 4, 4]
alredy_seen = []

for item in my_list: #пробигается по списку mylist
    if item not in alredy_seen: #не входит ли наш элемент в списко alredy_seen
        alredy_seen.append(item) #append (добавить элемент)
print(my_list)
print(alredy_seen)

#Метод списками +brake +else (без not in, и in)#
my_list = [1, 1, 2, 0, -1, 3, 4, 4]
alredy_seen = []

for i in range(len(my_list)):
    for j in range(len(alredy_seen)):
        if my_list[i] == alredy_seen[j]:
            break
    else:
        alredy_seen.append(my_list[i])
print(len(alredy_seen))


#Задача 2
# Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на K элементов вправо, K – положительное число.
# Input: [1, 2, 3, 4, 5] k = 3
# Output: [3, 4, 5, 1, 2]
# Примечание: Пользователь может вводить значения списка или список задан изначально.
arr = [1, 2, 3, 4, 5]
k = 3
k = k % len(arr)

#Вариант 1 #Срез
answer = []
answer.append(arr[k-1:])
answer.append(arr[:k-1])
print(arr[k-1:] + arr[:k-1])

#Вариант 2
answer = []
j = 0
for i in range(len(arr)):
    if i + k <= len(arr):
        answer.append(arr[i + k - 1])
    else:
        answer.append(arr[j])
        j += 1
print(answer)

#Вариант 3 #варинт с вводом pop,insert
my_list = [1, 2, 3, 4, 5]
k = int(input('-> '))
for _ in range(k):
    last_item = my_list.pop() #pop() Метод pop удаляет элемент по индексу и возвращает его. Если не указывать параметры, то будет удален последний элемент
    my_list.insert(0, last_item) #insert Чтобы добавить элемент в список Python по индексу, нужно использовать метод insert ()

print(my_list)

############
#Совари (3)#
#Списки и словари / достаем значение
my_dict = {
    142342: 'Стол',
    534534: 'Диван',
    142342: {
        'name': 'Кресло',
        'count': 10,
        'color': 'Зеленое',
        'info': [1, 4, 2]
    }
}

print(my_dict[142342]['info'][-1]) #из 142342 / info достаем последнее значение


#Списки и словари / kay и val
my_dict = {
    142342: 'Стол', #142342 - ключ / стол - значения
    534534: 'Диван',
    149342: {
        'name': 'Кресло',
        'count': 10,
        'color': 'Зеленое',
        'info': [1, 4, 2]
    }
}

for key, val in my_dict.items():
    print(key, '---', val) #key значение / val - вложение


#Задача 3#
# Напишите программу для печати всех уникальных значений в словаре.
# Input: [{"V": "S001"}, {"V": "S002"}, {"VI": "S001"}, {"VI": "S005"}, {"VII": "S005"}, {"V":"S009"}, {"VIII":"S007"}]
# Output: {'S005', 'S002', 'S007', 'S001', 'S009'}

#Вариант 1
list_items = [
    {"V": "S001",
    "V": "S002",
    "VI": "S001",
    "VI": "S005",
    "VII": "S005",
    "V":"S009",
    "VIII":"S007"}
]
new_list = []
for i in range(len(list_items)):
    for value in list_items[i].values():
        new_list.append(value)
print(new_list)

#Вариант 2
all_dicts = [{"V": "S001"}, {"V": "S002"}, {"VI": "S001"}, \
{"VI": "S005"}, {"VII": "S005"}, {"V":"S009"}, {"VIII":"S007"}]
all_vals = []
for small_dict in all_dicts:
    for val in small_dict.values():
        if val not in all_vals:
            all_vals.append(val)
print(all_vals)

#Задача 4
# Дан массив, состоящий из целых чисел. Напишите программу, которая подсчитает количество элементов массива, больших предыдущего (элемента с предыдущим номером)
# Input: [0, -1, 5, 2, 3]
# Output: 2
# Пояснение: (-1 < 5, 2 < 3)

my_arr = [0, -1, 5, 2, 3]
count = 0
for i in range(1, len(my_arr)):
    if my_arr[i] > my_arr[i -1]:
        count += 1
print(count)


