using System;
using System.IO;
using System.Linq;

namespace Sytnyk_Illia_s_Homework_9_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\KPI\Codes\Softserves's homeworks\Sytnyk Illia's Homework 9_B\Some_text.txt";
            string[] all_lines = File.ReadAllLines(path);
            int all_symbols = 0;
            int max_symbols = 0;
            int min_symbols = 999;
            for (int i = 0; i < all_lines.Length; i++)
            {
                Console.WriteLine($"The line {i+1} has got {all_lines[i].Length} symbols");
                all_symbols += all_lines.Length;
                if (all_lines[i].Length > max_symbols) { max_symbols = all_lines[i].Length; }
                if (all_lines[i].Length < min_symbols) { min_symbols = all_lines[i].Length; }
            }
            Console.WriteLine($"\nAll symbols in the file = {all_symbols} symbols");
            Console.WriteLine($"The longest line has got {max_symbols} symbols");
            Console.WriteLine($"The shortest line has got {min_symbols} symbols");
            Console.WriteLine("\nThe row(s) that contains of word (string): ");
            var row = from r in all_lines
                      where r.Contains("string")
                      select r;
            foreach (var str in row)
            {
                Console.WriteLine(str);
            }

            //foreach (string line in all_lines)
            //{
            //    Console.WriteLine($"The line has got {line.Length} symbols");
            //    all_symbols += line.Length;
            //}

            //foreach (string line in all_lines)
            //{
            //    if (line.Length > max_symbols)
            //    {
            //        max_symbols = line.Length;
            //    }
            //}

            //foreach (string line in all_lines)
            //{
            //    if (line.Length < min_symbols)
            //    {
            //        min_symbols = line.Length;
            //    }
            //}
        }
    }
}