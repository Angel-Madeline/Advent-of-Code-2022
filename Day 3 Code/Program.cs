using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_3_Code
{
    internal class Program
    {
        static string[] file = File.ReadAllLines("AoCday3.txt");
        static string[] LRucksack = new string[file.Length];
        static string[] RRucksack = new string[file.Length];
        static int totalpiroity = 0;
        #region Task One
        static void taskOneSplitSacks()
        {
            int middle = 0;
            for (int i = 0; i < file.Length; i++)
            {
                middle = file[i].Length / 2;
                LRucksack[i] = file[i].Substring(0, middle);
                RRucksack[i] = file[i].Substring(middle, middle);
            }
        }
        static void taskOneFindCommonChar()
        {
            char characterFound;
            int valueofcharacter;
            bool foundinword = false;
            for (int currentstring = 0; currentstring < file.Length; currentstring++)
            {
                foreach (char currentLRucksackchar in LRucksack[currentstring])
                {
                    foreach (char currentRRucksackchar in RRucksack[currentstring])
                    {
                        if (currentLRucksackchar == currentRRucksackchar)
                        {
                            if (foundinword == false)
                            {
                                characterFound = currentLRucksackchar;
                                foundinword = true;
                                if (characterFound >= 65 && characterFound <= 90)
                                {
                                    valueofcharacter = characterFound - 38;
                                    totalpiroity += valueofcharacter;
                                }
                                else
                                {
                                    valueofcharacter = characterFound - 96;
                                    totalpiroity += valueofcharacter;
                                }
                            }
                        }
                    }
                }
                foundinword = false;
            }
        }
        static void taskOneMain()
        {
            taskOneSplitSacks();
            taskOneFindCommonChar();
            Console.WriteLine("The total piroity is: " + totalpiroity);
        }
        #endregion

        static void taskTwo()
        {

        }
        static void Main(string[] args)
        {
            taskOneMain();

            

            Console.ReadLine();
        }
    }
}
