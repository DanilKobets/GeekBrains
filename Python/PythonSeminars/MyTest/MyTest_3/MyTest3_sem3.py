####################
list = [1, 1, 2, 0, -1, 3, 4, 4]

i = 1
count = 0
for i in range(len(list)):
    if list[i - 1] != list[i]:
        count +=1

print(f"Разлчиных чисел в списке: {count}")

