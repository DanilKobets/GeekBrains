############################
# my_list = [1, 1, 2, 0, -1, 3, 4, 4]
# already_seen = []

# for item in my_list:
#     if item not in already_seen:
#         already_seen.append(item)

# print(len(already_seen))
############################################////////////
# Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на K элементов вправо, K – положительное число.
# Input: [1, 2, 3, 4, 5] k = 3
# Output: [3, 4, 5, 1, 2]
# arr = [1, 2, 3, 4, 5]
# k = 3
# for i in range(k):
#     arr.insert(0, arr[len(arr)-1])
#     arr.pop(len(arr)-1)
#     print(arr)
#Срезы
# # k = 2
# # -5 -4 -3 -2 -1
# # 0 1 2 3 4
# my_list = [1, 2, 3, 4, 5]
# # 3, 4, 5, 1, 2
# # 4, 5, 1, 2, 3

# k = int(input('-> '))
# k %= len(my_list)

# print(my_list[-k:] + my_list[:-k])
############################
#СПИСки
# my_dict = {
    # 142342: 'Стол',
    # 534534: 'Диван',
    # 142342: {
        # 'name': 'Кресло',
        # 'count': 10,
        # 'color': 'Зеленое',
        # 'info': [1, 4, 2]
    # }
# }

# print(my_dict[142342]['info'][-1])
############################
# my_dict = {
#     142342: 'Стол',
#     534534: 'Диван',
#     149342: {
#         'name': 'Кресло',
#         'count': 10,
#         'color': 'Зеленое',
#         'info': [1, 4, 2]
#     }
# }

# for key, val in my_dict.items():
# print(key, '---', val)
#############################
# Напишите программу для печати всех уникальных значений в словаре.
# Input: [{"V": "S001"}, {"V": "S002"}, {"VI": "S001"}, {"VI": "S005"}, {"VII": "S005"}, {"V":"S009"}, {"VIII":"S007"}]
# Output: {'S005', 'S002', 'S007', 'S001', 'S009'}

list = {
    "V": "S001",
    "V": "S002",
    "VI": "S001",
    "VI": "S005",
    "VII": "S005",
    "V":"S009",
    "VIII":"S007"
}
new_list = []
for i in range(len(list)):
    for value in list[i].values():
        new_list.append(value)
print (new_list)
############################//////////###
#СРЕЗЫ
# 0 1 2 3 4
# arr = [1, 2, 3, 4, 5]

# arr[1:3] -> [2, 3]
# arr[:3] -> [1, 2, 3]
# arr[2:] -> [3, 4, 5]
# arr[:] -> [1, 2, 3, 4, 5]
# arr[::2] -> [1, 3, 5]    
############################
# arr = [1, 2, 1, 2, 0, -1, -2, -1, -3]
# count = 0
# for i in range(len(arr)):
#     if (arr[i]) not in arr[:i]:
#         count += 1
        
# print(count)

# arr = set(arr)
# print(len(arr))

####################
# Требуется вычислить, сколько раз встречается некоторое число k в массиве list_1.

# Найдите количество и выведите его.


# list_1 = [1, 2, 3, 4, 5]
# k = 3

# count = list_1.count(k)
# print(count)
####################
# list = [1, 1, 2, 0, -1, 3, 4, 4]

# i = 1
# count = 0
# for i in range(len(list)):
#     if list[i - 1] != list[i]:
#         count +=1

# print(f"Разлчиных чисел в списке: {count}")

####################
# Требуется найти в массиве list_1 самый близкий по величине элемент к заданному числу k и вывести его.
# list_1 = [1, 2, 3, 4, 5]
# k = 6
# for i in range(len(list_1)):
#     if list_1[i] > list_1[k]:
#         max = list_1[i]
# else:
#     list_1[k] < list_1[i]
#     min = list_1[i]
# print(max, min, list_1[k], list_1[i])

####################
# def find_closest_element(list_1, k):
#     closest_element = list_1[0]
#     closest_difference = abs(k - list_1[0])
    
#     for element in list_1:
#         difference = abs(k - element)
#         if difference < closest_difference:
#             closest_difference = difference
#             closest_element = element
    
#     return closest_element

# list_1 = [1, 2, 3, 4, 5]
# k = 6

# closest_element = find_closest_element(list_1, k)
# print(closest_element)

