#Урок 5. Рекурсия и алгоритмы

# ПРО ФУНКЦИИ:
# Можно окрыть книгу "Byte of Python" и найти главу про функции, там очень хорошо раскрыта эта тема.
# Можно посмотреть о функциях тут: https://www.youtube.com/watch?v=DJAlfolEv9A
# О переменных количествах аргументов (*args, **kwargs): https://stepik.org/lesson/372076/step/1?unit=359630
# О тайп-хинтингах: https://proglib.io/p/annotacii-tipov-v-python-vse-chto-nuzhno-znat-za-5-minut-2022-01-30
# Всемогущие декораторы: https://www.youtube.com/watch?v=Va-ovLxHmus&t=2s
# Про генераторы: https://ru.hexlet.io/courses/python-declarative-programming/lessons/generator-functions/theory_unit
# Декораторы (начинаем с замыканий и дальше по плейлисту до декораторов включительно): https://www.youtube.com/watch?v=lA979PBb0TY

#Задача 1
# Последовательностью Фибоначчи называется
# последовательность чисел a0
# , a1
# , ..., an
# , ..., где
# a0
# = 0, a1
# = 1, ak
# = ak-1 + ak-2 (k > 1).
# Требуется найти N-е число Фибоначчи
# Input: 7
# Output: 21
#[]- список
#(,) - картеж

#Вариант 1
def fib(n):
    if n in (0,1):
        return 1
    else:
        return fib(n-1)+fib(n-2)
n = int(input())
print(fib(n))

#Вариант 2
def fib(n):
    if n in [0, 1]:
        return 1
    return fib(n-1) + fib(n-2)
n = int(input())
for i in range(1, n+1):
    print(fib(i), end=' ') #end=' ' - выввод в строку

#Задача 2
# Хакер Василий получил доступ к классному журналу и
# хочет заменить все свои минимальные оценки на
# максимальные. Напишите программу, которая
# заменяет оценки Василия, но наоборот: все
# максимальные – на минимальные.
# Input: 5 -> 1 3 3 3 4
# Output: 1 3 3 3 1

#Вариант 1
# m = list(map(int, input().split())) -сло.
n = [1, 3, 3, 3, 4]
print(n)

def func(n):
    maxx = max(n)
    minn = min(n)
    for i in range(len(n)):
        if n[i] == maxx:
            n[i] = minn
    return n

print(func(n))
# print(sorted(n)) #сортировка


#Вариант 2
def grade(n=[]):
    max_1 = max(n)
    min_1 = min(n)

    for i in range(len(n)):
        if n[i] == max_1:
            n[i] = min_1
    return (n)

print(grade(n=[1,3,3,3,4]))

#Задача 3
# Напишите функцию, которая принимает одно число и
# проверяет, является ли оно простым
# Напоминание: Простое число - это число, которое
# имеет 2 делителя: 1 и n(само число)
# Input: 5
# Output: yes

#Вариант 1
def func(n):
    for i in range(2, n):
        if n % i == 0:
            return "целое" #no
    return "простое" #yes
n = int(input())
print(func(n))

#Вариант 2
def func(n):
    for i in range(2, n // 2 + 1):
        if n % i == 0:
            return "целое"
    return "простое"
n = int(input())
print(func(n))

#Задача 4
# Дано натуральное число N и
# последовательность из N элементов.
# Требуется вывести эту последовательность в
# обратном порядке.
# Примечание. В программе запрещается
# объявлять массивы и использовать циклы
# (даже для ввода и вывода).
# Input: 2 -> 3 4
# Output: 4 3


#Вариант 1
def revers_(n): #кол-во чисел
    number = input() #ввод
    if n != 1: #Пока n != 1 (кол-во чисел польз.)
        revers_(n - 1) #сохраняет и выводит в обратном порядке
    print(number, end=' ')

n = int(input("Введите кол-во цифр -> "))

revers_(n)

#Вариант 2
def revers_(n):
    number = input()
    if n == 1:
        return number
    return revers_(n - 1) + ' ' + number #number + число что ввёл пользователь / revers_(n - 1) запрос след. числа

n = int(input())

print(revers_(n))

