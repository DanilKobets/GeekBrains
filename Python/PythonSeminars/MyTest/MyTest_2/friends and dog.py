print("Сколько раз пробежит собака между двух друзей, идущих на встречу друг другу?")
count = 0  # количество раз пробежит собака
distance = 10000  # расстояние между друзьями
firstFriendSpeed = 1  # скорость первого друга
secondFriendSpeed = 2  # скорость второго друга
dogSpeed = 5  # скорость собаки
friend = 2  # от какого друга начинает бежать собака
while distance > 10:
        if friend == 1:
                time = distance / (firstFriendSpeed + dogSpeed)
                friend = 2
        else:
                time = distance / (secondFriendSpeed + dogSpeed)
                friend = 1
        distance = distance - (time * (firstFriendSpeed + secondFriendSpeed))
        count = count + 1
print("Собака пробежит", count, " раз")