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

        #region Task One
        static string[] LRucksack = new string[file.Length];
        static string[] RRucksack = new string[file.Length];
        static int totalPiroityPartOne = 0;
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
                                    totalPiroityPartOne += valueofcharacter;
                                }
                                else
                                {
                                    valueofcharacter = characterFound - 96;
                                    totalPiroityPartOne += valueofcharacter;
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
            Console.WriteLine("The total piroity is: " + totalPiroityPartOne);
        }
        #endregion
        #region Task Two
        static int totalPiroityPartTwo = 0;
        static void sortStrings()
        {
            string word1;
            string word2;
            string word3;
            bool foundinword = false;
            char characterFound;
            int valueofcharacter;
            for (int currentWords = 0; currentWords < file.Length; currentWords+=3)
            {
                word1 = file[currentWords];
                word2 = file[currentWords+1];
                word3 = file[currentWords+2];
                foreach (char word1char in word1)
                {
                    foreach (char word2char in word2)
                    {
                        if (word1char == word2char)
                        {
                            foreach (char word3char in word3)
                            {
                                if (word2char == word3char)
                                {
                                    if (foundinword == false)
                                    {
                                        characterFound = word1char;
                                        foundinword = true;
                                        if (characterFound >= 65 && characterFound <= 90)
                                        {
                                            valueofcharacter = characterFound - 38;
                                            totalPiroityPartTwo += valueofcharacter;
                                        }
                                        else
                                        {
                                            valueofcharacter = characterFound - 96;
                                            totalPiroityPartTwo += valueofcharacter;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                foundinword = false;
            }
        }
        static void taskTwoMain()
        {
            sortStrings();
            Console.WriteLine("The total piroity is: " + totalPiroityPartTwo);
        }
        #endregion

        static void Main(string[] args)
        {
            taskOneMain();
            taskTwoMain();

            Console.ReadLine();
        }
    }
}
