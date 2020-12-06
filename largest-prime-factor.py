# first I want to get all the prime numbers into a list
num = 13195
prime_numbers = []
for x in range(2,1000):
    devisible_list = []
    for y in range(2,x+1):
        if(x==y):
            if(len(devisible_list) == 0):
                prime_numbers.append(x)
        elif(x%y == 0):
            devisible_list.append(y)
        else:
            pass

# next I want to go through all the possible factors with that list... 
# this is going to suck
mult = 1
for prime_number in prime_numbers:
    mult = prime_number * mult
    print(mult)
    if(mult==num):
        print("holy shit!!")
