# сумма квадратов четных чисел
def filter_even_imperative(numbers):
    sum = 0
    for num in numbers:
        if num % 2 == 0:
            sum = sum + num * num
    return sum


numbers = [1, 2, 3, 4, 5, 6, 7, 8]

print(filter_even_imperative(numbers))  # Вывод: [2, 4, 6, 8]