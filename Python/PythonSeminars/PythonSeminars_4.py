#Урок 4. Словари, множества и профилирование

#пример функции split()
my_str = "hello, world"
print(my_str.split("l"))

#Задача 1
# Напишите программу, которая принимает на вход
# строку, и отслеживает, сколько раз каждый символ
# уже встречался. Количество повторов добавляется к
# символам с помощью постфикса формата _n.
# Input: a a a b c a a d c d d
# Output: a a_1 a_2 b c a_3 a_4 d c_1 d_1 d_2
# Для решения данной задачи используйте функцию
# .split()

#Вариант 1 (не очень)
my_string = 'a a a b c a a d c d d'
my_list = my_string.split()
my_dict = {}
for i in my_list:
    if i not in my_dict:
        my_dict[i] = 0
        print(i+' ',end='')
    else:
        print(i,end='')
        my_dict[i] += 1
    print('_' + str(my_dict[i]) +' ',end='')

#Вариант 2
start_str = 'a a a b c a a d c d d'.split()
print(start_str)
char_dict = {} #список
result_str = ''

for char in start_str: #char пробигаемся по списку
    if char not in char_dict: #если нет буквы в char_dict
        char_dict[char] = 1 #присваеваем значение char = 1
        result_str += f'{char} ' #выводим результат буквы без повтора
    else:
        result_str += f'{char}_{char_dict[char]} ' #выводим букву char + '_' + достаем счётчик буквы [char]
        char_dict[char] += 1 # +1 счётчик
print(result_str)


#Задача 2
# Пользователь вводит текст(строка). Словом считается
# последовательность непробельных символов идущих
# подряд, слова разделены одним или большим числом
# пробелов. Определите, сколько различных слов
# содержится в этом тексте.
# Input: She sells sea shells on the sea shore The shells
# that she sells are sea shells I'm sure.So if she sells sea
# shells on the sea shore I'm sure that the shells are sea
# shore shells
# Output: 13

text = "She sells sea shells on the sea shore The shells that she sells\
        are sea shells I'm sure.So if she sells sea shells on the sea shore\
        I'm sure that the shells are sea".lower() #lower () нижний регистр

text = set(text.split(' '))
print(len(text))
print(text)


#Задача 3
# Ваня и Петя поспорили, кто быстрее решит
# следующую задачу: “Задана последовательность
# неотрицательных целых чисел. Требуется определить
# значение наибольшего элемента
# последовательности, которая завершается первым
# встретившимся нулем (число 0 не входит в
# последовательность)”. Однако 2 друга оказались не
# такими смышлеными. Никто из ребят не смог до
# конца сделать это задание. Они решили так: у кого
# будет меньше ошибок в коде, тот и выиграл спор. За
# помощью товарищи обратились к Вам, студентам.

#Вариант 1
input_num = int(input("Введите число -> "))
max = input_num
while input_num != 0:
    input_num = int(input("Введите число ->"))
    if max < input_num:
        max = input_num
print(max)

#Вариант 2
n = int(input())
max_number = n
while n != 0:
    n = int(input())
    if max_number < n:
        max_number = n
print(max_number)

#Списко vs Массив
import time
start_time = time.time()
my_tuple = (1, 2, 3)
my_list = [1, 2, 3]
print(my_tuple.__sizeof__()) #__sizeof__ сколько памяти занимает
print(my_list.__sizeof__())

end_time = time.time() #подсчёт времяни
print(end_time - start_time)
