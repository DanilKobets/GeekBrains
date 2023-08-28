#По данному целому неотрицательному n вычислите значение n!. N! = 1 * 2 * 3 * … * N (произведение всех чисел от 1 до N) 0! = 1 Решить задачу используя цикл while

fact = int(input("Введите число ->"))
i = 1
res = 1
while i <= fact:
#    res *= i
    res = res * i
    i += 1
print(res)


# Задача №11. Решение в группах
# Дано натуральное число A > 1. Определите, каким по
# счету числом Фибоначчи оно является, то есть
# выведите такое число n, что φ(n)=A. Если А не
# является числом Фибоначчи, выведите число -1.
# Input: 5
# Output: 6
#
a = int(input())

i = 2
fib_1 = 0
fib_2 = 1

while fib_2 < a:
    fib_1, fib_2 = fib_2, fib_1 + fib_2

# buff = fib_2
# fib_2 = fib_1 + fib_2
# fib_1 = buff

i += 1

if fib_2 == a:
    print(i)
else:
    print(-1)







# Задача №15. Решение в группах
# 15. Иван Васильевич пришел на рынок и решил
# купить два арбуза: один для себя, а другой для тещи.
# Понятно, что для себя нужно выбрать арбуз
# потяжелей, а для тещи полегче. Но вот незадача:
# арбузов слишком много и он не знает как же выбрать
# самый легкий и самый тяжелый арбуз? Помогите ему!
# Пользователь вводит одно число N – количество
# арбузов. Вторая строка содержит N чисел,
# записанных на новой строчке каждое. Здесь каждое
# число – это масса соответствующего арбуза
# Input: 5 -> 5 1 6 5 9
# Output: 1 9

n = int(input())
arbuz = int(input('Вес первого арбуза -> '))
max = arbuz
min = arbuz
for _ in range(n-1):
    arbuz = int(input('Вес арбуза -> '))
    if arbuz > max:
        max = arbuz
    if arbuz < min:
        min = arbuz
print (F'{max} {min}')



# # Отсортированный массив
def heapify(arr, n, i):
    largest = i
    left = 2 * i + 1
    right = 2 * i + 2
  
    if left < n and arr[i] < arr[left]:
        largest = left
  
    if right < n and arr[largest] < arr[right]:
        largest = right
  
    if largest != i:
        arr[i], arr[largest] = arr[largest], arr[i] # обмен элементов
  
    heapify(arr, n, largest)
  
  
def heap_sort(arr):
    n = len(arr)
  
    for i in range(n // 2 - 1, -1, -1):
        heapify(arr, n, i)
  
    for i in range(n-1, 0, -1):
        arr[i], arr[0] = arr[0], arr[i] # обмен элементов
        heapify(arr, i, 0)


# Пример использования:

print(heapify)
arr = [12, 11, 13, 5, 6, 7]
heap_sort(arr)
print("Отсортированный массив:")
print(arr)


# Вывод:
# Отсортированный массив:
# [5, 6, 7, 11, 12, 13]


