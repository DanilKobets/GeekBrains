# Задача 34:  Винни-Пух попросил Вас посмотреть, есть ли в его стихах ритм. 
# Поскольку разобраться в его кричалках не настолько просто, насколько легко он их придумывает, 
# Вам стоит написать программу. Винни-Пух считает, что ритм есть, если число слогов (т.е. число гласных букв) 
# в каждой фразе стихотворения одинаковое. Фраза может состоять из одного слова, если во фразе несколько слов, 
# то они разделяются дефисами. Фразы отделяются друг от друга пробелами. Стихотворение  Винни-Пух вбивает в программу
# с клавиатуры. В ответе напишите “Парам пам-пам”, если с ритмом все в порядке и “Пам парам”, если с ритмом все не в порядке

# *Пример:*

# **Ввод:** пара-ра-рам рам-пам-папам па-ра-па-да    
#     **Вывод:** Парам пам-пам  

#Вариант 1
rhymes = 'пара-ра-рам рам-пам-папам па-ра-па-дам'
# аеёиоуыэюя
def vinni(vinni_pyx):
    phrase_vinni = [[glas for glas in vinni if glas in 'аеёиоуыэюя']for vinni in (vinni_pyx.split())]
    return 'Парам пам-пам' if len(set(map(lambda count: len(count), phrase_vinni))) == 1 else 'Пам парам'

print(vinni(rhymes))


#Вариант 2 
def func(str):
    str = str.lower().split(' ')
    my_list = list()
    for word in str:
        result = 0
        for i in word:
            if i in vowels:
                result += 1
        my_list.append(result)
    return len(my_list) == my_list.count(my_list[0])


vowels = ['a', 'e', 'i', 'o', 'u', 'y', 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я']
str = input('Введите кричалку Винни-Пуха: ')
if func(str):
    print('Парам пам-пам')
else:
    print('Пам парам')


# Задача 36: Напишите функцию print_operation_table(operation, num_rows=6, num_columns=6), 
# которая принимает в качестве аргумента функцию, вычисляющую элемент по номеру строки и столбца. 
# Аргументы num_rows и num_columns указывают число строк и столбцов таблицы, которые должны быть распечатаны.
# Нумерация строк и столбцов идет с единицы (подумайте, почему не с нуля). 
# Примечание: бинарной операцией называется любая операция, у которой ровно два аргумента, как, например, у операции умножения.

# *Пример:*

# **Ввод:** `print_operation_table(lambda x, y: x * y) ` 
# **Вывод:**
# 1 2 3 4 5 6

# 2 4 6 8 10 12
# 3 6 9 12 15 18
# 4 8 12 16 20 24
# 5 10 15 20 25 30
# 6 12 18 24 30 36


#Вариант 1

def print_operation_table(operation, num_rows=6, num_columns=6):
    row_list, colum_list = [x for x in range(1, num_rows + 1)], [y for y in range(1, num_columns + 1)] #создание сетки
    finish_list = [[operation(row, col) for row in row_list] for col in colum_list] #
    for row in finish_list:
        print(row)
print_operation_table(lambda x, y: x * y) 


#Вариант 2
def print_operation_table(operation, num_rows=6, num_columns=6):
    a = [[operation(i, j) for j in range(1, num_columns + 1)] for i in range(1, num_rows + 1)]
    for i in a:
        print(*[f'{x: > 3}' for x in i])

print_operation_table(lambda x, y: x * y)


# Решение без магических чисел. Так-то оно получше будет...
def print_operation_table(operation):
    a = [[operation(i, j) for j in range(1, columns + 1)] for i in range(1, rows + 1)]
    for i in a:
        print(*[f'{x:>3}' for x in i])


rows = int(input('Введите количество строк: '))
columns = int(input('Введите количество столбцов: '))
print_operation_table(lambda x, y: x * y)