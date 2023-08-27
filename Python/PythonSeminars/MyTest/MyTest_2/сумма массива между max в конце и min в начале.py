array = [11, 1, 13, 7, 6, 4, 89, 3, 14, 8, 20, 9, 85,88, 63]
size = len(array)
index = 0
iMax = 0
max = array[iMax]
iMin = 0
min = array[iMin]
sum = 0
while index < size:
    if min >= array[index]:  # ищем минимальное значение
        min = array[index]
        iMin = index
    elif max < array[index]:  # ищем максимальное значение
        max = array[index]
        iMax = index
    sum = sum + array[index]
    index += 1
temp = array[size - 1]  # переставляем max в конец массива
array[size - 1] = array[iMax]
array[iMax] = temp
temp = array[size - size]  # переставляем min в начало массива
array[size - size] = array[iMin]
array[iMin] = temp
print(sum)  # сумма всего массива
sum = sum - (max + min)
print(sum)  # сумма массива без (max + min)
print(array)
print(max)
print(min)