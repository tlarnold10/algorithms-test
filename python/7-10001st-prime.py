import pdb

prime_numbers = []
num = 2 
while(len(prime_numbers) < 10001):
    for x in range(2,(num+1)):
        # pdb.set_trace()
        if(x%num == 0 and x == num):
            prime_numbers.append(num)
            break
        elif(num%x != 0):
            pass
        else:
            break
    num = num + 1
    print(prime_numbers)