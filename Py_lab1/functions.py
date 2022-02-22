import keyboard

def creating_main_file(path):
    print("Введите текст: ")
    all = ""
    check1 = True
    while check1 == True:
        event = keyboard.read_event()
        all = input() + '\n'
        file = open(path, 'a+')
        file.write(all)
        if event.event_type == keyboard.KEY_DOWN and event.name == 'ctrl':
            print('Entering of text is ended')
            check1 = False
        file.close()

def sort_of_files(path, path2, path3):
    sorting_text = []
    file = open(path, 'r')
    file2 = open(path2, 'a+')
    file3 = open(path3, 'a+')
    sorting_text = file.readlines()
    sorting_text_odd = []
    for i in range(0, len(sorting_text)):
        if i % 2 == 0:
            file3.write(sorting_text[i])
            sorting_text_odd.append(sorting_text[i])
        else:
            file2.write(sorting_text[i])
    return sorting_text_odd
    file.close()
    file2.close()
    file3.close()

def sort_of_strings(path3, sorting_text_odd):
    print("Сколько строк отсортировать:")
    n = int(input())
    sorting_text_1 = []
    for j in range(0, n):
        sorting_text_1.append(sorting_text_odd[j])
    sorting_text_1.sort()
    for j in range(0, n):
        sorting_text_odd[j] = sorting_text_1[j]
    file3 = open(path3, 'w+')
    for j in range(0, len(sorting_text_odd)):
        file3.write(sorting_text_odd[j])
    file3.close()

def show_file(path, name):
    file = open(path, "r")
    buff = file.readlines()
    print("File content of ", name)
    for i in range(0, len(buff)):
        print(buff[i])
    file.close()