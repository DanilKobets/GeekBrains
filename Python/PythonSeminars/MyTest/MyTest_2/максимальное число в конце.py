numbers = [2, 5, 13, 7, 6, 4]
size = len(numbers)
index = 0
max_idx = 0
max = numbers[max_idx]
while index < size:
    if numbers[index] > max:
        max_idx = index
        max = numbers[index]
    index += 1
numbers[max_idx] = numbers[size - 1]
numbers[size - 1] = max
print(numbers)