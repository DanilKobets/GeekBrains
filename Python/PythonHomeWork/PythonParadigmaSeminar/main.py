def sum_imperative(n):
    total = 0
    for i in range(1, n+1):
        total += i
    return total

result = sum_imperative(5)
print(result) # Вывод: 15