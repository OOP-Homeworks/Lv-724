using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Person
    {
        private string name;
        private int birthYear;

        public string Name
        {
            get { return name; }
        }

        public int BirthYear
        {
            get { return birthYear; }
        }

        public Person()
        {
            name = "Max";
            birthYear = 2003;
        }


        public Person(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public static Person Input(int i)
        {
            Console.WriteLine($"Enter {i + 1} person name = ");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter {i + 1} person bithYear in format yyyy.mm.dd = ");
            int date = Convert.ToInt32(Console.ReadLine());
            Person person = new Person(name,date);
            return person;
            
        }
        public int Age(int year)
        {
            this.birthYear = year - birthYear;
           return (this.birthYear);
        }

        public void Output()
        {
            Console.WriteLine("Person name is - " + name + " with age - " + birthYear);
        }
        public void Outputs()
        {
            Console.WriteLine("Person name is - " + name + " with birthYear in - " + birthYear);
        }

        public void Changename(string y)
        {
            name = y;
        }
        public override string ToString()
        {
            return ("Person name is - " + name + " with age - " + birthYear);
        }

        public static bool operator ==(Person fist, Person second)
        {
            return (fist.name == second.name);
        }
        public static bool operator !=(Person fist, Person second)
        {
            return !(fist == second);
        }
    }
}
