using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter name of First file");
            string path1 = Console.ReadLine();
            Console.WriteLine("Enter name of Second file:");
            string path2 = Console.ReadLine();
            
            create_info createInfo = new create_info();
            List<info> list_of_students1 = createInfo.information();
            List<info> list_of_students2 = list_of_students1;
            Console.WriteLine("All students:");
            createInfo.output_list(list_of_students1);
            
            int amount_of_students = createInfo.CreateBinaryFile(list_of_students1, path1);
            
            List<info> lowest = createInfo.LowLevelStudents(path1, amount_of_students);
            Console.WriteLine("Lowest mark students: ");
            createInfo.output_list(lowest);
            
            List<info> sorted_list = createInfo.Identify(list_of_students2);
            Console.WriteLine("4-th grade students:");
            createInfo.output_list(sorted_list);
            int stud = createInfo.CreateBinaryFile(sorted_list, path2);
            Console.ReadLine();
        }
    }
}