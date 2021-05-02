sum = 0
array = [1, 2]
while(array[-1] < 4000000):
    array.append(array[-1] + array[-2]) 
print(array)
for x in array:
    if (x%2 == 0):
        sum = sum+x
print(sum)