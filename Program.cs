using System;
using System.IO;
using System.Linq;

namespace HW9_Cherniak
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string path = @"C:\Users\Настася\Desktop\SoftServe Homework\task.txt";
			string[] task = File.ReadAllLines(@"C:\Users\Настася\Desktop\SoftServe Homework\task.txt");
			using (StreamReader sw = new StreamReader(path, false))
			{
				int result = 0;
				foreach (string i in task)
				{
					result += i.Length;
				}
				Console.WriteLine($"Amount of symbols in every rows: {result} ");
				Console.WriteLine("");

				var Long = task.OrderByDescending(a => a.Length).First().ToString();
				var Short = task.OrderBy(a => a.Length).First().ToString();

				Console.WriteLine($"Longest row is :'{Long}', ");
				Console.WriteLine($"Shortest row is :'{Short}', ");
				Console.WriteLine("");

				Console.WriteLine("The row that contains of word \"var\":");
				var row = from b in task
						   where b.Contains("var")
						   select b;
				foreach (var item in row)
				{
					Console.WriteLine(item);
				}
			}
		}
	}
}
