using System;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace Lab6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree(-8);
            int[] massiv = new[] {-1, 5, -7, 8 ,9};
            foreach (var item in massiv)
            {
                tree.Insert(item);
            }

            Console.WriteLine(tree.PreorderTraverse());
            Console.WriteLine(tree.CountNegative());
            Console.WriteLine(tree.CountPositive());
            Console.ReadLine();
        }
    }
}