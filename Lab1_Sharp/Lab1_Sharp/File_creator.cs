using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Sharp
{
    internal class File_creator
    {
        public void Generate_file(string path)
        {
            bool check = true;
            string all = "";
            Console.WriteLine("Введите данные");
            while (check)
            {
                all = Console.ReadLine() + '\n';
                System.IO.File.AppendAllText(path, all);
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.F10)
                {
                    check = false;
                }
            }
        }
    }
}
