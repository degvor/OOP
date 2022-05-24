import pickle


class Student:
    def __init__(self, name, birthday, group_name, group_number, form_study, mark):
        self.name = name
        self.birthday = birthday
        self.group_name = group_name
        self.group_number = group_number
        self.form_study = form_study
        self.mark = mark


def create_readable(path):
    student_list = []
    with open(path, 'rb') as file:
        list_s = pickle.load(file)

    for student in list_s:
        student_list.append(student)
    return student_list


def creating_list_of_students(path):
    n = int(input("Enter amount of students: "))
    group_name = input('Enter the name group: ')
    students_list = list()
    for i in range(n):
        print(f"Student number {i + 1}")
        name = input('Enter name of student: ')
        birthday = input('Enter the date of birth: ')
        group_number = input('Enter number of group: ')
        form_study = input('Enter form of study (full-time / distance learning): ')
        mark = input('Enter average mark of student: ')
        student = Student(name, birthday, group_name, group_number, form_study, mark)
        students_list.append(student)
    with open(path, 'ab+') as file:
        pickle.dump(students_list, file)
    return students_list


def worst_students(students_list):
    worst_mark_students = []

    while len(students_list) > 0:
        worst_mark = students_list[0].mark
        group_number = students_list[0].group_number
        worst_student = students_list[0]
        j = 0
        while j < len(students_list):
            if students_list[j].group_number == group_number:
                if students_list[j].mark <= worst_mark:
                    worst_mark = students_list[j].mark
                    worst_student = students_list[j]
                students_list.remove(students_list[j])
            else:
                j += 1
        worst_mark_students.append(worst_student)
    return worst_mark_students


def output_info_student(Students):
    for i in range(len(Students)):
        print(f'Name: {Students[i].name}, birthday: {Students[i].birthday}, group: {Students[i].group_name}-{Students[i].group_number}, form of study: {Students[i].form_study}, average mark: {Students[i].mark}')


def sorted_file(student_list, path2):
    n = float(input('Enter average mark: '))
    i = 0
    while i < len(student_list):
        if int(student_list[i].group_number) <= 39 or int(student_list[i].group_number) >= 50 or student_list[i].form_study != "full-time" or float(student_list[i].mark) < n and len(student_list) != 0:
            student_list.pop(i)
        else:
            i += 1

    if len(student_list) > 1:
        for i in range(len(student_list)):
            for j in range(i + 1, len(student_list)):
                if student_list[i].name[0] > student_list[j].name[0]:
                    student_list[i], student_list[j] = student_list[j], student_list[i]

    with open(path2, 'ab+') as file:
        pickle.dump(student_list, file)
    return student_list
