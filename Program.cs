using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Output();

            Person person1 = new Person("Anton",2003);
            person1.Output();

            var persons = new Person[6];
            for (int i = 2; i < 6; i++)
            {
                persons[0] = person;
                persons[1] = person1;
                persons[i] = Person.Input(i);
            }
            for (int i = 0; i < 6; i++)
            {
                persons[i].Outputs();
            }
            Console.WriteLine("Pleace enter this year = ");
           int year = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 6; i++)
            {
                persons[i].Age(year);
                persons[i].Output();
            }

            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].BirthYear < 16)
                {
                    persons[i].Changename("Very Young");
                }
            }
            Console.WriteLine("  ");
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Output();
            }

            for (int i = 0; i < persons.Length - 1; i++)
            {
                if (persons[i].Name == persons[i + 1].Name)
                {
                    Console.WriteLine("{0} and {1} share a similar name.", persons[i], persons[i + 1]);
                }
            }
            Console.ReadKey();
        }
    }
}