from Numbers import *


def get_bin_nums(size):
    bin_nums = []
    for i in range(size):
        num = int(input("Enter a number: "))
        bin_nums.append(NumberBinary(num))

    return bin_nums


def get_oct_nums(size):
    oct_nums = []
    for i in range(size):
        num = int(input("Enter a number: "))
        oct_nums.append(NumberOctal(num))

    return oct_nums


def print_numbers(nums, pre_print=""):
    print(pre_print)
    for num in nums:
        print(num, end="\t")
    print()


def get_int_nums(bin_nums: list[NumberBinary], oct_nums: list[NumberOctal]):
    int_nums = []
    for num in bin_nums:
        int_nums.append(num.to_int())
    for num in oct_nums:
        int_nums.append(num.to_int())

    return int_nums
