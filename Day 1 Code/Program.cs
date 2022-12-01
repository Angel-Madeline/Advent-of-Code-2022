using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_1_Code
{
    internal class Program
    {
        static string[] file = File.ReadAllLines("textfile.txt");

        static List<int> elfs = new List<int>();

        static void combinenums()
        {
            int currentelf = 0;
            for (int i = 0; i < file.Length; i++)
            {
                if (file[i] == "")
                {
                    elfs.Add(currentelf);
                    currentelf = 0;
                }
                else
                {
                    currentelf += int.Parse(file[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            combinenums();
            Console.WriteLine("elf with most calories is: " + elfs.Max());
            int top3cal = elfs.Max();
            for (int i = 0; i < 2; i++)
            {
                elfs.Remove(elfs.Max());
                top3cal += elfs.Max();
            }
            Console.WriteLine("the combined top 3 calories is: " + top3cal);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
