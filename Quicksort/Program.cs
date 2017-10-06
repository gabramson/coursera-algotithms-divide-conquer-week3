using QuicksorterLib;
using System;
using System.IO;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            var leftQuicksorter = new LeftQuicksorter<int>();
            ProcessFile(leftQuicksorter, @"Quicksort.txt");
            Console.WriteLine($"Left: {leftQuicksorter.Comparisons}");

            var rightQuicksorter = new RightQuicksorter<int>();
            ProcessFile(rightQuicksorter, @"Quicksort.txt");
            Console.WriteLine($"Right: {rightQuicksorter.Comparisons}");

            var midQuicksorter = new MidQuicksorter<int>();
            ProcessFile(midQuicksorter, @"Quicksort.txt");
            Console.WriteLine($"Mid: {midQuicksorter.Comparisons}");

            Console.ReadKey();
        }

        static void ProcessFile(Quicksorter<int> quicksorter, string filename)
        {
            string line;
            using (StreamReader srStreamRdr = new StreamReader(filename))
            {
                while ((line = srStreamRdr.ReadLine()) != null)
                {
                    quicksorter.Add(int.Parse(line));
                }
            }
            quicksorter.Sort();
        }
    }

}
