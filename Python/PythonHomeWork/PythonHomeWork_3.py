#ЗАДАЧА1
# Требуется вычислить, сколько раз встречается некоторое число k в массиве list_1.
# Найдите количество и выведите его.
# Пример:

# list_1 = [1, 2, 3, 4, 5]
# k = 3
# # 1
count = list_1.count(k)
print(count)


#ЗАДАЧА2
# Требуется найти в массиве list_1 самый близкий по величине элемент к заданному числу k и вывести его.
# Пример:
# list_1 = [2, 4, 6, 8, 10]
# k = 11

number = 0
for i in range(len(list_1)):
    if list_1[i] == k:
        number = k
        break
    elif list_1[i] == k + 1:
        number = k + 1
    elif list_1[i] == k - 1:
        number = k - 1
print(number)


# вариант 2

m = abs(k - list_1[0])  # модуль числа
number = list_1[0]
for i in range(1, len(list_1)):
    if m > abs(list_1[i] - k):
        m = abs(list_1[i] - k)
        number = list_1[i]
print(number)



#ЗАДАЧА3

# В настольной игре Скрабл (Scrabble) каждая буква имеет определенную ценность.

# В случае с английским алфавитом очки распределяются так:

# A, E, I, O, U, L, N, S, T, R – 1 очко;
# D, G – 2 очка;
# B, C, M, P – 3 очка;
# F, H, V, W, Y – 4 очка;
# K – 5 очков;
# J, X – 8 очков;
# Q, Z – 10 очков.
# А русские буквы оцениваются так:

# А, В, Е, И, Н, О, Р, С, Т – 1 очко;
# Д, К, Л, М, П, У – 2 очка;
# Б, Г, Ё, Ь, Я – 3 очка;
# Й, Ы – 4 очка;
# Ж, З, Х, Ц, Ч – 5 очков;
# Ш, Э, Ю – 8 очков;
# Ф, Щ, Ъ – 10 очков.
# Напишите программу, которая вычисляет стоимость введенного пользователем слова k и выводит его. Будем считать, что на вход подается только одно слово, которое содержит либо только английские, либо только русские буквы.

# Пример:


# k = 'ноутбук'
# # 12

#Ввод
list_letters = {1:"AEIOULNSTRАВЕИНОРСТ",
                2:"DGДКЛМПУ",
                3:"BCMPБГЁЬЯ",
                4:"FHVWYЙЫ",
                5:"KЖЗХЦЧ",
                8:"JXШЭЮ",
                10:"QZФЩЪ"}

word = input("Введите слово: ").upper()
summ = 0
for i in word:
    for k, v in list_letters.items():
        if i in v:
            summ += k
print(f"Стоимость слова: {summ}")



#без ввода
k = 'ноутбук'
list_letters = {1:"AEIOULNSTRАВЕИНОРСТaeioulnstrавеинорст",
                2:"DGДКЛМПУdgдклмпу",
                3:"BCMPБГЁЬЯbcmpбгёья",
                4:"FHVWYЙЫfhvwyйы",
                5:"KЖЗХЦЧkжзхцч",
                8:"JXШЭЮjxшэю",
                10:"QZФЩЪqzфщъ"}


summ = 0
for i in k:
    for l, v in list_letters.items():
        if i in v:
            summ += l
print(summ)