using System;

namespace _4HW_Cherniak
{
	class Program
	{
		static void Main(string[] args)
		{
			var persons = new Person[6];
			for (int i = 0; i < persons.Length; i++)
			{
				persons[i] = Person.Input(i);
			}
			for(int i = 0; i < persons.Length; i++)
			{
				var age = persons[i].Age();
				Console.WriteLine($"{persons[i].Name} is {age} years old");	
			}
			for (int i = 0; i < persons.Length; i++)
			{
				int age = persons[i].Age();
				persons[i].ChangeName(age);
			}
			for (int i = 0; i < persons.Length; i++)
			{
				persons[i].Output();
			}
			for (int i = 0; i < persons.Length; i++)
			{
				for	(int j = i + 1; j < persons.Length; j++)
				{
					if (persons[i] == persons[j])
					{
						Console.WriteLine($"{persons[i].Name} and {persons[j].Name} are equals");
					}
				}
			}
			Console.ReadKey();
		}
	}
}
