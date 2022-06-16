using System;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace Lab6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Node:");
            int n = Convert.ToInt32(Console.ReadLine());
            Tree tree = new Tree(n);
            Console.WriteLine("Enter value of numbers to enter into Three:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] massiv = new int [m];
            Console.WriteLine($"Enter {m} nums:");
            for (int i = 0; i < m; i++)
            {
                massiv[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in massiv)
            {
                tree.Insert(item);
            }
            Console.WriteLine("Node:");
            Console.WriteLine(tree.PreorderTraverse());
            Console.WriteLine("Negative numbers of Three: ");
            Console.WriteLine(tree.CountNegative());
            Console.WriteLine("Positive numbers of Three: ");
            Console.WriteLine(tree.CountPositive());
            Console.ReadLine();
        }
    }
}