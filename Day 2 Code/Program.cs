using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day2
{
    internal class Program
    {
        static string[] file = File.ReadAllLines("AoCday2.txt");
        static int totalTaskOne = 0;
        static int totalTaskTwo = 0;
        static void taskOne()
        {
            string oppenment = "";
            string player = "";
            for (int round = 0; round < file.Length; round++)
            {
                oppenment = file[round].Substring(0, 1);
                player = file[round].Substring(2, 1);

                switch (oppenment)
                {
                    case "A":
                        switch (player)
                        {
                            case "X": 
                                totalTaskOne+= 4;
                                break;
                            case "Y": 
                                totalTaskOne+= 8;
                                break;
                            default:
                                totalTaskOne+= 3;
                                break;
                        }
                        break;
                    case "B":
                        switch (player)
                        {
                            case "X": 
                                totalTaskOne+= 1;
                                break;
                            case "Y": 
                                totalTaskOne+= 5;
                                break;
                            default: 
                                totalTaskOne+= 9;
                                break;
                        }
                        break;
                    default:
                        switch (player)
                        {
                            case "X": 
                                totalTaskOne+= 7;
                                break;
                            case "Y": 
                                totalTaskOne+= 2;
                                break;
                            default: 
                                totalTaskOne+= 6;
                                break;
                        }
                        break;
                }
            }
        }
        static void taskTwo()
        {
            string oppenment = "";
            string player = "";
            for (int round = 0; round < file.Length; round++)
            {
                oppenment = file[round].Substring(0, 1);
                player = file[round].Substring(2, 1);

                switch (oppenment)
                {
                    case "A":
                        switch (player)
                        {
                            case "X":
                                totalTaskTwo += 3;
                                break;
                            case "Y":
                                totalTaskTwo += 4;
                                break;
                            default:
                                totalTaskTwo += 8;
                                break;
                        }
                        break;
                    case "B":
                        switch (player)
                        {
                            case "X":
                                totalTaskTwo += 1;
                                break;
                            case "Y":
                                totalTaskTwo += 5;
                                break;
                            default:
                                totalTaskTwo += 9;
                                break;
                        }
                        break;
                    default:
                        switch (player)
                        {
                            case "X":
                                totalTaskTwo += 2;
                                break;
                            case "Y":
                                totalTaskTwo += 6;
                                break;
                            default:
                                totalTaskTwo += 7;
                                break;
                        }
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            taskOne(); taskTwo();
            Console.WriteLine("The total for the first task is: " + totalTaskOne);
            Console.WriteLine("The total for the second task is: " + totalTaskTwo);
            Console.ReadLine();
        }
    }
}