#Сортировка [] + [] + []
def quick_sort(array):
    if len(array) <= 1:
        return array
    else:
        privot = array[0]
    less = [i for i in array[1:] if i <= privot]
    great = [i for i in array[1:] if i > privot]
    return quick_sort(less) + [privot] +quick_sort(great)
print(quick_sort([14, 5, 9, 5, 3, 1, 66, 4, 333]))

#Сортировка слиянием
def merge_sort(nums):
    if len(nums) > 1:
        mid = len(nums) // 2
        left = nums [:mid]
        right = nums [mid:]
        merge_sort(left)
        merge_sort(right)
        i = j = k = 0
        while i < len(left) and j < len(right):
            if left [i] < right[j]:
                nums[k] = left[i]
                i += 1
            else:
                nums[k] = right[j]
                j += 1
            k += 1
        while i < len(left):
            nums[k] = left[i]
            i += 1
            k += 1
        while i < len(right):
            nums[k] = right[j]
            i += 1
            k += 1
list1 = [7, 5, 3, 5, 6, 7, 8, 9]
merge_sort(list1)
print(list1)
