array = [11, 5, 15, 7, 6, 4, 2, 3, 14, 8, 9, 1]
size = len(array)
index = 0
iMax = 0
max = array[iMax]
iMin = 0
min = array[iMin]
while index < size:
    if min >= array[index]:
        min = array[index]
        iMin = index
    elif max < array[index]:
        max = array[index]
        iMax = index
    index += 1
if iMin > iMax:
    iMin, iMax = iMax, iMin
sum = 0
for i in range(iMin+1, iMax):
    sum += array[i]
print(sum)
print(array)
print(iMax)
print(iMin)