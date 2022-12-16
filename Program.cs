using System;
using System.Collections.Generic;
using System.IO;

namespace HW7_Cherniak
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var way = @"C:\Users\Настася\Desktop\SoftServe Homework\phones.txt"; 
			var phoneBook = new Dictionary<string, string>();
			var sr = new StreamReader(way);

			while (!sr.EndOfStream)
			{
				string name = sr.ReadLine();
				string telephone = sr.ReadLine();
				phoneBook.Add(name, verify(telephone));
			}
			Console.WriteLine("Input the contact, which do you want to call : ");
			string contact = Console.ReadLine();

			try
			{
				Console.WriteLine("Calling {0}", phoneBook[contact]);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				sr.Close();
			}

			var sw = new StreamWriter(@"C:\Users\Настася\Desktop\SoftServe Homework\phones.txt");

			foreach (var couple in phoneBook)
			{
				sw.WriteLine($"{couple.Key}, {couple.Value}");
			}
			sr.Close();
			sw.Close();
			Console.ReadKey();
		}

		static string verify(string phone)
		{
			if (phone[0] == '3')
				phone = "+" + phone;
			if (phone[0] == '8')
				phone = "+3" + phone;
			if (phone[0] == '0')
				phone = "+38" + phone;
			return phone;
		}
	}
}

