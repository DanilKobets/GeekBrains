# '''Задача 22: Даны два неупорядоченных набора целых чисел (может быть, с повторениями).
# Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
# Пользователь вводит 2 числа. n - кол-во элементов первого множества. m - кол-во элементов второго множества.
# Затем пользователь вводит сами элементы множеств.
# 11 6
# 2 4 6 8 10 12 10 8 6 4 2
# 3 6 9 12 15 18
# 6 12'''


n = (int(input("Введите N кол-во элементов первого множества: ")))
num1=[] 
for i in range(n):
    num = int(input("Введите число -> "))
    num1.append(num) 
print(num1)

m = (int(input("Введите M кол-во элементов второго множества: ")))
num2 = []
for i in range(m):
    num = int(input("Введите число -> "))
    num2.append(num)
print(num2)

num_check = []

for i in num1:
    for j in num2:
        if i == j and i not in num_check:
            num_check.append(i)
            print(i)


# Задача 24: В фермерском хозяйстве в Карелии выращивают чернику. 
# Она растёт на круглой грядке, причём кусты высажены только по окружности. 
# Таким образом, у каждого куста есть ровно два соседних. Всего на грядке растёт N кустов.
# Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло 
# различное число ягод — на i-ом кусте выросло ai ягод.
# В этом фермерском хозяйстве внедрена система автоматического сбора черники. 
# Эта система состоит из управляющего модуля и нескольких собирающих модулей. 
# Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, 
# собирает ягоды с этого куста и с двух соседних с ним.
# Напишите программу для нахождения максимального числа ягод, 
# которое может собрать за один заход собирающий модуль, 
# находясь перед некоторым кустом заданной во входном файле грядки.

from random import randint
num_ber = (int(input("Введите максимальное кол-во ягод на одном кусте: ")))
list_ber = list(randint(1, num_ber) for i in range(int(input("Введите кол-во кустов: "))))
print(list_ber)
a = int(input("Введите № куста: "))
berries = 0
if a == 1:
    berries = list_ber[0] + list_ber[1] + list_ber[-1]
elif a == len(list_ber):
    berries = list_ber[-2] + list_ber[-1] + list_ber[0]
else:
    berries = list_ber[a-1] + list_ber[a-2] + list_ber[a]
print(berries, 'ягод')