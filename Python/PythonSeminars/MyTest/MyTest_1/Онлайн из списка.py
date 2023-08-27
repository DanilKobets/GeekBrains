# показываем кто в онлайн из списка зарегистрированных
names_list = ['anton', 'serg', 'kris', 'vasya', 'ksusha', 'admin']
names_onlain = ['anton', 'kris', 'ksusha', 'admin']
if names_onlain:  # проверяем что список не пуст
    for onlain_name in names_onlain:
        if onlain_name == 'admin':  # отсылаем админу отдельное сообщение
            print("\nHello  " + onlain_name + " would you like to see a status report?.")
        else:
            if onlain_name in names_onlain:  # отсылаем сообщение всем остальным
               print("Hello " + onlain_name.title() + " thank you for logging in again.")
else:
    print("We need to find some users!")  # отправляем сообщение если список пуст
       

