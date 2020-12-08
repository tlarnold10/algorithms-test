num = 20
not_found = True
while(not_found):
    num = num + 1
    for x in range(1,21):
        if(num%x == 0 and x != 20):
            not_found = True
        elif(x==20):
            not_found = False
        else:
            break
print(num)