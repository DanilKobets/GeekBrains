# Изменение регистра символов в строках
name = "ada love lace"
print(name.title())  # изменение регистра 1-й буквы в словах

name = "Ada Love lACe"
print(name.upper())  # изменение к верхнему регистру в словах
print(name.lower())  # изменение к нижнему регистру в словах

# Конкатенация (объединение строк)
first_name = "ada"
last_name = "lovelace"
full_name = first_name + " " + last_name
print(full_name)  # объединяет 1-е и 2-е имя

first_name = "ada"
last_name = "lovelace"
full_name = first_name + " " + last_name
print("Hello, " + full_name.title() + "!")  # объединяет 1-е и 2-е имя, изменяя регистр 1-й буквы в словах

first_name = "ada"
last_name = "lovelace"
full_name = first_name + " " + last_name
message = "Hello, " + full_name.title() + "!"
print(message)  # тоже самое + сохраняет в переменную

# Табуляции и разрывы строк
print("Python")
print("\tPython")  # Для табуляции используется комбинация символов \t
print("Languages:\nPython\nC\nJavaScript")  # Разрывы строк добавляются с помощью комбинации символов \n
print("Languages:\n\tPython\n\tC\n\tJavaScript")  # табуляция и разрывы строк

# Удаление пропусков
first_name = "вася   "
first_name = first_name.rstrip()  # метод rstrip() удаление пропусков справа
last_name = "  пупкин  "  # метод lstrip() удаление пропусков слева
last_name = last_name.strip()  # метод strip() удаление пропусков справа и слева
full_name = first_name + " " + last_name
message = "Hello, " + full_name.title() + "!"
print(message)

