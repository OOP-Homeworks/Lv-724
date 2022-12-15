using System;

namespace HW6_Cherniak_Part2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Input two double numbers");
				Console.Write("First number : ");
				double firstNumber = Convert.ToDouble(Console.ReadLine());
				Console.Write("Second number : ");
				double secondNumber = Convert.ToDouble(Console.ReadLine());
				if (firstNumber > secondNumber)
				{
					throw new Exception("Second number must be bigger than first number");
				}
				if (secondNumber == 0)
				{
					throw new DivideByZeroException();
				}
				Console.WriteLine("{0} / {1} = {2}", secondNumber, firstNumber, secondNumber / firstNumber);
			}
			catch (FormatException exeption)
			{
				Console.WriteLine(exeption.Message);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
