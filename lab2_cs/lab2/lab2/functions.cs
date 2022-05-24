using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace lab2
{
    public struct info
    {
        public string name,
            FormOfStudying,
            GroupName,
            DateOfBirth;
        public int GroupNumber;
        public double AverageMark;
    };
    public class create_info
    {
        public List<info> information()
        {
            Console.WriteLine("Enter amount of students:");
            string n = Console.ReadLine();
            int amount_of_students= Convert.ToInt32(n);
            List<info> list = new List<info>();
            info student_info;
            Console.Write("Enter the name of the group: ");
            string groupName = Console.ReadLine();
            for (int i = 0; i < amount_of_students; i++)
            {
                Console.Write("Student's name: ");
                student_info.name = Console.ReadLine();

                Console.Write("Date of Birth(DD.MM.YEAR): ");
                student_info.DateOfBirth = Console.ReadLine();

                Console.Write("Form of studying(full-time / distance learning): ");
                student_info.FormOfStudying = Console.ReadLine();

                Console.Write("Group number: ");
                student_info.GroupNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Average mark(0-100): ");
                student_info.AverageMark = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                student_info.GroupName = groupName;
                list.Add(student_info);
            }
            return list;
        }
        public void output_list(List<info> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Name: {list[i].name}, birthday: {list[i].DateOfBirth}, group: {list[i].GroupName}-{list[i].GroupNumber}, form of study: {list[i].FormOfStudying}, average mark: {list[i].AverageMark}");
            }
        }
        public int CreateBinaryFile(List<info> list, string fileName)
        {
            BinaryWriter BinaryFile;
            BinaryFile = new BinaryWriter(new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write));
            for (int i = 0; i < list.Count; i++)
            {
                BinaryFile.Write(list[i].name);
                BinaryFile.Write(list[i].DateOfBirth);
                BinaryFile.Write(list[i].FormOfStudying);
                BinaryFile.Write(list[i].GroupName);
                BinaryFile.Write(list[i].GroupNumber);
                BinaryFile.Write(list[i].AverageMark);
            }
            BinaryFile.Close();
            return list.Count;
        }
        public List<info> LowLevelStudents(string FileName, int AmountOfStudents)
        {
            List<info> MainList = new List<info>();
            List<info> InfoList = new List<info>();
            info StudentInfo;
            BinaryReader BinaryFileToRead;
            BinaryFileToRead = new BinaryReader(new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read));
            for (int i = 0; i < AmountOfStudents; i++)
            {
                StudentInfo.name = BinaryFileToRead.ReadString();
                StudentInfo.DateOfBirth = BinaryFileToRead.ReadString();
                StudentInfo.FormOfStudying = BinaryFileToRead.ReadString();
                StudentInfo.GroupName = BinaryFileToRead.ReadString();
                StudentInfo.GroupNumber = BinaryFileToRead.ReadInt32();
                StudentInfo.AverageMark = BinaryFileToRead.ReadDouble();
                InfoList.Add(StudentInfo);
            }
            double LowestAverageMark;
            int GroupNum;
            info LowestStudent;
            for (int i = 0; i < InfoList.Count;)
            {
                LowestAverageMark = InfoList[i].AverageMark;
                GroupNum = InfoList[i].GroupNumber;
                LowestStudent = InfoList[i];
                for(int j = 0; j < InfoList.Count;)
                {
                    if(InfoList[j].GroupNumber == GroupNum)
                    {
                        if(InfoList[j].AverageMark < LowestAverageMark)
                        {
                            LowestAverageMark = InfoList[j].AverageMark;
                            LowestStudent = InfoList[j];
                        }
                        InfoList.Remove(InfoList[j]);
                    }
                    else j++;
                }
                MainList.Add(LowestStudent);
            }
            return MainList;
        }
        public List<info> Identify(List<info> list)
        {
            List <info> list2 = new List<info>();
            Console.Write("Pick the average mark: ");
            double averageGrage = Convert.ToDouble(Console.ReadLine());
            for(int i = 0; i < list.Count;)
            {
                if(!(list[i].GroupNumber > 39 && list[i].GroupNumber < 50 && list[i].FormOfStudying == "full-time" && list[i].AverageMark > averageGrage) && list.Count() != 0)
                    list.Remove(list[i]);
                else i++;
            }

            if (list.Count() > 1)
            {
                list2 = list.OrderBy(i => i.name).ToList();
            }
            return list2;
        }
    }
}