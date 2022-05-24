
import functions


path1 = input('Enter name of First file: ')
path2 = input('Enter name of Second file: ')

list_of_students = functions.creating_list_of_students(path1)
print('All students:')
functions.output_info_student(list_of_students)

readable_list_1 = functions.create_readable(path1)

worst_students = functions.worst_students(readable_list_1)
print('Worst student of each group: ')
functions.output_info_student(worst_students)

readable_list_2 = functions.create_readable(path1)

sorted_list_students = functions.sorted_file(readable_list_2, path2)
print('Sorted 4-th grade students: ')
functions.output_info_student(sorted_list_students)


