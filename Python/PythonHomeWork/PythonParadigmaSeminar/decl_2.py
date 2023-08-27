def filter_even_declarative(numbers):
    return list(filter(lambda x: x % 2 
    == 0, numbers))

numbers = [1, 2, 3, 4, 5, 6, 7, 8]
even_numbers = filter_even_declarative(numbers)
print(even_numbers)  # Вывод: [2, 4, 6, 8] 