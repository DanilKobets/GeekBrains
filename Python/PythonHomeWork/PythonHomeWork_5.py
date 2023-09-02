# Напишите функцию f, которая на вход принимает два числа a и b, и возводит число a в целую степень b с помощью рекурсии.
# Функция не должна ничего выводить, только возвращать значение.
# Пример:
# a = 3; b = 5 -> 243 (3⁵)
# a = 2; b = 3 -> 8 

# a = 3
# b = 5
def f(a, b):
    if b < 2:
        return a
    return a * f(a, b - 1)
# print(f(a, b))



# Задача 28: Напишите рекурсивную функцию sum(a, b),
#            возвращающую сумму двух целых неотрицательных чисел.
#            Из всех арифметических операций допускаются только +1 и -1. Также нельзя использовать циклы.
#            # *Пример:* 2 2
#                        4

# a = 3
# b = 5
# print(sum(a, b))
def sum(a, b):
    if b < 1:
        return 1
    return a + sum(1, b - 1)