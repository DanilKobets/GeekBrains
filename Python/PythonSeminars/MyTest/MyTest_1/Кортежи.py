# Кортежи (tuples) Элементы кортежа не могут изменяться
dimensions = (200, 50)  # определяется кортеж dimensions, при этом вместо квадратных скобок используются круглые
print(dimensions[0])  # каждый элемент кортежа выводится по отдельности
print(dimensions[1])

# Перебор всех значений в кортеже
dimensions = (200, 50)
for dimension in dimensions:
    print(dimension)

# Замена кортежа, Элементы не могут изменяться, но можоно присвоить новое значение переменной
dimensions = (200, 50)
print("Original dimensions:")
for dimension in dimensions:
    print(dimension)
dimensions = (400, 100)
print("\nModified dimensions:")
for dimension in dimensions:
    print(dimension)



