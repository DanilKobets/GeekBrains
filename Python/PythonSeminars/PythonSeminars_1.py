#Урок 1. Ввод-Вывод, операторы ветвления#

# #Задача 1, машина проезжает 700км в день нужно проехать 750 км (Остаток от деления ответ : 2)
import math
n = 700
m = 750
res = m/n
print(math.ceil((res))) #ceil - большую сторону

#Задача 1
n = int(input("n :")) #700
m = int(input("m :")) #750

print((m +(n - 1)) // n) #750 (700 - 1) // 700
print(f"{(-m)//n * (-1)}") #Вариант 2
# -5 / 2 = 2,5 -> -3 (Округляет в большую сторону)



#ЗАДАЧА 2
# В некоторой школе решили набрать три новых математических класса и оборудовать кабинеты для них новыми партами. За каждой партой может сидеть два учащихся. Известно количество учащихся в каждом из трех классов. Выведите наименьшее число парт, которое нужно приобрести для них.
# Input: 20 21 22(ввод чисел НЕ в одну строку)
# Output: 32

a = int(input('Введите кол-во уч.в классе А:'))
b = int(input('Введите кол-во уч.в классе Б:'))
v = int(input('Введите кол-во уч.в классе В:'))

res = (((-a)//2) + ((-b)//2) + ((-v)//2)) * (-1)
print(f'{res} парт нужно приобрести')


#ЗАДАЧА 3
# Дано натуральное число. Требуется определить, является ли год с данным номером високосным. Если год является високосным, то выведите YES, иначе выведите NO. Напомним, что в соответствии с григорианским календарем, год является високосным, 
# если его номер кратен 4, но не кратен 100, а также если он кратен 400.
# Input: 2016
# Output: YES
# elif:

n = int(input("Введите год : "))

if ((n % 4 == 0) and (n % 100 != 0)) or (n % 400 == 0):
    print ("Високосным год:", n)
else:
    print("Год не високосным", n)


