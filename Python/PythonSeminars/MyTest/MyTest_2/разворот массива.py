array = [1, 2, 3, 4, 5, 6, 7, 8, 9]
size = len(array)
temp = 0
for i in range(size // 2):
    temp = array[i]
    array[i] = array[size - i - 1]
    array[size - i - 1] = temp
print(array)