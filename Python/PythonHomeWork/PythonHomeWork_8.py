#Дз
# Задача 38: Дополнить телефонный справочник возможностью изменения и удаления данных. 
# Пользователь также может ввести имя или фамилию, и 
# Вы должны реализовать функционал для изменения и удаления данных

from sys import argv
import os
#интерфейс
def Interfeis_contact(telefon_list_name_file = 'book.txt'):
    Interfeis_contact = int(input('\n1 - Для поиска\n2 - для добовления\n3 - Удалить контакт\n4 - Изменить контакт\n5 - Удалить все контакты\n6 - Показать все контакты\n0 - выйти\n -> '))
    while Interfeis_contact != 0: #0 - выйти
        if Interfeis_contact == 1: #Поиск
            Find_contact()
        elif Interfeis_contact == 2: #Добавить контакт
            write_Contact()
        elif Interfeis_contact == 3: #Удалить контакт
            delete_contact()
        elif Interfeis_contact == 4: #Изменить контакт
            update_contact()
        elif Interfeis_contact == 5: #Удалить все контакты
            delate_contact_all()  
        else :
            Print_contacts()  #Показать все контакты
        Interfeis_contact = int(input('\n1 - Для поиска\n2 - для добовления\n3 - Удалить контакт\n4 - Изменить контакт\n5 - Удалить все контакты\n6 - Показать все контакты\n0 - выйти\n -> '))    


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
                
def delate_contact_all(telefon_list_name_file = 'book.txt'):
    with open(telefon_list_name_file, 'w', encoding='UTF-8') as telefon_list:
        delate_cont = telefon_list.truncate()
    print(f'Вы удилили все контакты, теперь их - {delate_cont}')
    
def delete_contact(telefon_list_name_file = 'book.txt'):
    with open(telefon_list_name_file, 'r', encoding='UTF-8') as telefon_list:
        lines = telefon_list.readlines()
    
    contacts = []
    for line in lines:
        contacts.append(line.strip().split(','))
    
    find_name = input('Введите имя контакта, который нужно удалить: ')
    
    new_contacts = []
    for contact in contacts:
        if contact[0].lower() != find_name.lower():
            new_contacts.append(contact)
    
    with open(telefon_list_name_file, 'w', encoding='UTF-8') as telefon_list:
        for contact in new_contacts:
            telefon_list.write(','.join(contact) + '\n')
    
    print('Контакт удален')
    
def update_contact(telefon_list_name_file = 'book.txt'):
    with open(telefon_list_name_file, 'r', encoding='UTF-8') as telefon_list:
        lines = telefon_list.readlines()
    
    contacts = []
    for line in lines:
        contacts.append(line.strip().split(','))
        
    find_name = input('Введите имя контакта, который нужно изменить: ')
    
    new_contacts = []
    for contact in contacts:
        if contact[0].lower() == find_name.lower():
            new_first_name = input('Введите новое имя: ')
            new_last_name = input('Введите новую фамилию: ')
            new_patronymic = input('Введите новое отчество: ')
            new_telefon = input('Введите новый телефон: ')
            while len(new_telefon) != 11 or not new_telefon.isdigit():
                print('Вы ввели неправильный телефон!')
                new_telefon = input('Введите новый телефон: ')
            new_contacts.append([new_last_name, new_first_name, new_patronymic, new_telefon])
        else:
            new_contacts.append(contact)
    
    with open(telefon_list_name_file, 'w', encoding='UTF-8') as telefon_list:
        for contact in new_contacts:
            telefon_list.write(','.join(contact) + '\n')
    
    print('Контакт изменен')

Interfeis_contact()