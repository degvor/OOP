from Numbers import *
from Worker import  *

bin_nums_count = int(input("Enter number of binary numbers: "))
oct_nums_count = int(input("Enter number of octal numbers: "))

print("\nEnter numbers, that will be converted to binary")
bin_nums = get_bin_nums(bin_nums_count)
print("\nEnter numbers, that will be converted to octal")
oct_nums = get_oct_nums(oct_nums_count)

print_numbers(bin_nums, "\nBinary numbers")
print_numbers(oct_nums, "\nOctal numbers")

for num in bin_nums:
    num.num_up()

for num in oct_nums:
    num.num_down()

print_numbers(bin_nums, "\nBinary numbers after increment: ")
print_numbers(oct_nums, "\nOctal numbers after decrement: ")

int_nums = get_int_nums(bin_nums, oct_nums)
print(f"Min from all numbers: {min(int_nums)}")

