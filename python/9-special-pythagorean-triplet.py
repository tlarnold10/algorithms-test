final = 1000
var_a = 0
var_b = 0
var_c = 0

for x in range(1,final):
    a = x
    print("a: " + str(a))
    for y in range(1,final):
        b = y
        for z in range(1,final):
            c = z
            if((a**2) + (b**2) == (c**2)) and ((a+b+c) == 1000):
                print(a)
                print(b)
                print(c)
                print(final)
                print(str(a*b*c))
                sys.exit()

