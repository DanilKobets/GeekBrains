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

