using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Sharp
{
    internal class Display
    {
        public void PrintFromFile(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            Console.WriteLine($"\nFile name is {path}");
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
        }
    }
}
