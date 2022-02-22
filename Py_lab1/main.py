import functions


print("Введите имя файла:")
name_file = input()
print("Введите имя файла:")
name_file1 = input()
print("Введите имя файла:")
name_file2 = input()
path = "E:\\Lab1_py\\" + name_file + ".txt"
path2 = "E:\\Lab1_py\\" + name_file1 + ".txt";
path3 = "E:\\Lab1_py\\" + name_file2 + ".txt";

functions.creating_main_file(path)
odd = functions.sort_of_files(path, path2, path3)
functions.show_file(path, name_file)
functions.show_file(path2, name_file1)
functions.show_file(path3, name_file2)
functions.sort_of_strings(path3, odd)
functions.show_file(path3, name_file2)




































# functions.creating_main_file(path)
# print("Введите текст: ")
# all = ""
# check1 = True
# while check1 == True:
#     event = keyboard.read_event()
#     all = input() + '\n'
#     file = open(path, 'a+')
#     file.write(all)
#     if event.event_type == keyboard.KEY_DOWN and event.name == 'ctrl':
#         print('ctrl was pressed')
#         check1 = False
#     file.close()
#
# sorting_text = []
# file = open(path, 'r')
# file2 = open(path2, 'a+')
# file3 = open(path3, 'a+')
# sorting_text = file.readlines()
# sorting_text_odd = []
# for i in range(0, len(sorting_text)):
#     if i % 2 == 0:
#         file3.write(sorting_text[i])
#         sorting_text_odd.append(sorting_text[i])
#     else:
#         file2.write(sorting_text[i])
# file.close()
# file2.close()
# file3.close()
#
# print("Сколько строк отсортировать:")
# n = int(input())
# sorting_text_1 = []
# for j in range(0, n):
#     sorting_text_1.append(sorting_text_odd[j])
# sorting_text_1.sort()
# for j in range(0, n):
#     sorting_text_odd[j] = sorting_text_1[j]
# file3 = open(path3, 'w+')
# for j in range(0,len(sorting_text_odd)):
#     file3.write(sorting_text_odd[j])
# file3.close()

































# print("Введите текст: ")
# all = ""
# check1 = True
# check2 = True
# while check1 == True:
#     event = keyboard.read_event()
#     all = input() + '\n'
#     file = open(path, 'a+')
#     file.write(all)
#     if event.event_type == keyboard.KEY_DOWN and event.name == 'ctrl':
#         print('ctrl was pressed')
#         check1 = False
#     file.close()
