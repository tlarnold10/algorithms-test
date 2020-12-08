product_array = []
pal_list=[]
max = 0
for x in range(100,1000):
    for y in range(100,1000):
        product_array.append(x*y)
for num in product_array:
    string_num = str(num)
    if(string_num == string_num[::-1]):
        pal_list.append(num)
for z in pal_list:
    if(z>max):
        max = z

print(max)