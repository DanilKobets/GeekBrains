def filter_even_imperative(numbers):
    even_numbers = []
    for num in numbers:
        if num % 2 == 0:
            even_numbers.append(num)
    return even_numbers

numbers = [1, 2, 3, 4, 5, 6, 7, 8]
even_numbers = filter_even_imperative(numbers)
print(even_numbers)  # Вывод: [2, 4, 6, 8]