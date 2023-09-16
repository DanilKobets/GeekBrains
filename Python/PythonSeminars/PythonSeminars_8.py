#Урок 8. Работа с файлами

# Оформление тайп-хинтингов: https://vk.com/wall-176970991_565
# Try/except: https://pythonworld.ru/tipy-dannyx-v-python/isklyucheniya-v-python-konstrukciya-try-except-dlya-obrabotki-isklyuchenij.html
# Ребята, ниже интересные ссылки с разбором некоторых проектов. Берите интересующие и атакуйте)
# Визуализация звуков (прикольно для плеера): https://vk.com/wall-79831840_59594
# Как превратить код на Python в .exe: https://vk.com/@we_use_python-prevraschaem-kod-na-python-v-ispolnyaemyi-exe-fail
# Превращение голоса в текст: https://vk.com/wall-174948538_4183
# https://vk.com/@we_use_python-uchimsya-sozdavat-pakety-python
# Работа с крутой библиотекой Selenium. Очень полезный инструмент, позволяет работать с баузером (парасить, автоматизировать действия и т.д.): https://vk.com/wall-79831840_58984
# Крутая библиотека для работы с интерфейсами (PyQt): https://vk.com/wall-79831840_58959
# Нейронка, которая знакомиться с девушками в Тиндере XD: https://vk.com/wall-194576836_13051
#Custontkinter: https://github.com/TomSchimansky/CustomTkinter
#Потрясающие интерфейсы на Python: https://www.youtube.com/@WandersonItsMe/featured


#Кейсы
a = 243653

match a:
    case 1:
        print('111')
    case 2:
        print('222')
    case _:
        print('Not found')

#открытие файла
from pathlib import Path #создания файла

file_path = Path('data_file.txt')
f = open(file_path, 'a') #append - добовляем в конец файла
#with open (file_path, 'a') as file_data: #без close #w - создать a-добавить r - считать файл
f.write('Hellow, World!') #\nHellow, World! - с новой строки
# for line in file_data: #пробежать построчно по файлу
    #print(line)
###
#with open (file_path 'r') as file_data: #считать файлы
#print(file_data.readline())
f.close()

# import os #Сепаратор с / \ мак на вин
# file_path = 'info' + os.sep + 'data_file.txt'
# print(os.sep)


#Задача 1
# Создать телефонный справочник с
# возможностью импорта и экспорта данных в
# формате .txt. Фамилия, имя, отчество, номер
# телефона - данные, которые должны находиться
# в файле.
# 1. Программа должна выводить данные
# 2. Программа должна сохранять данные в
# текстовом файле
# 3. Пользователь может ввести одну из
# характеристик для поиска определенной
# записи(Например имя или фамилию
# человека)
# 4. Использование функций. Ваша программа
# не должна быть линейной

from sys import argv
import os
#интерфейс
def Interfeis_contact(telefon_list_name_file = 'book.txt'):
    Interfeis_contact = int(input('\n1 - Для поиска\n2 - для добовления\n3 - все контакты\n4 - удалить все контакты\n0 - выйти\n -> '))
    while Interfeis_contact != 0:
        if Interfeis_contact == 1:
            Find_contact()
        elif Interfeis_contact == 2:
            write_Contact()
        elif Interfeis_contact == 3:
            Print_contacts()
        else :
            delate_contact() 
        Interfeis_contact = int(input('\n1 - Для поиска\n2 - для добовления\n3 - все контакты\n4 - удалить все контакты\n0 - выйти\n -> '))    


#добавить контакт
def write_Contact(telefon_list_name_file = 'book.txt'):
    with open(telefon_list_name_file, 'a', encoding='UTF-8') as telefon_list:
        last_name = input('Введите имя: ')
        first_name = input('Введите фамилию: ')
        patronymic = input('Введите отчество: ')
        telefon = input('Введите телефон: ')
        while len(telefon) != 11 or not telefon.isdigit():
            print('Вы ввели неправльный телефон!')
            telefon = input('Введите телефон: ')
        telefon_list.write('\n'+last_name + ',' + first_name + ',' + patronymic + ',' + telefon)

#найти контакт
def Find_contact(telefon_list_name_file = 'book.txt'):
    with open(telefon_list_name_file, 'r', encoding='UTF-8') as telefon_list:
        find_name = input('Поисик: ')
        lines = telefon_list.readlines()
        none_contact = True
        for i in lines:
            if find_name in i:
                print('Контакт найден: ', i, end = '')
                none_contact = False
        if none_contact:
            print('Контакт не найден')
            print()

#Все контакты
def Print_contacts(telefon_list_name_file = 'book.txt'):
    with open(telefon_list_name_file, 'r', encoding='UTF-8') as telefon_list:
        lines = telefon_list.readlines()
        for i in lines:
                print(i, end = '')
                
def delate_contact(telefon_list_name_file = 'book.txt'):
    with open(telefon_list_name_file, 'w', encoding='UTF-8') as telefon_list:
        delate_cont = telefon_list.truncate()
    print(f'Вы удилили все контакты, теперь их - {delate_cont}')
    


Interfeis_contact()


                    