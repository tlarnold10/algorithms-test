sum_of_squares = 0
square_of_sums = 0
diff = 0

for x in range(1,101):
    sum_of_squares = sum_of_squares + (x**2)
    square_of_sums = square_of_sums + x

square_of_sums = square_of_sums**2
diff = (square_of_sums) - sum_of_squares
print(square_of_sums)
print(sum_of_squares)
print(diff)