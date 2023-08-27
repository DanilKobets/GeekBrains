# Упорядочение списка
# Постоянная сортировка списка методом sort()
cars = ['bmw', 'audi', 'toyota', 'subaru']
cars.sort()
print(cars)  # в алфавитном порядке

cars = ['bmw', 'audi', 'toyota', 'subaru']
cars.sort(reverse=True)
print(cars)  # в обратном алфавитном порядке

# Временная сортировка списка функцией sorted()
cars = ['bmw', 'audi', 'toyota', 'subaru']
print("Here is the original list:")
print(cars)
print("\nHere is the sorted list:")
print(sorted(cars))  # в алфавитном порядке
print("\nHere is the original list again:")
print(cars)

# Вывод списка в обратном порядке
cars = ['bmw', 'audi', 'toyota', 'subaru']
print(cars)
cars.reverse()
print(cars)

# Определение длины списка
cars = ['bmw', 'audi', 'toyota', 'subaru']
len(cars)
print(len(cars))


