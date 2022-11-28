using System;
using System.Collections.Generic;
using System.Text;

namespace HM5
{
    class Programmer : IDeveloper, IComparable
    {
        string language;
        public string Tool
        {
            set { language = value; }
            get { return language; }
        }

        public Programmer(string language)
        {
            this.language = language;
        }
        public static Programmer Input(int i)
        {
            Console.WriteLine($"{i + 1} enter your language");
            string language = Console.ReadLine();
            Programmer programmer1 = new Programmer(language);
            return programmer1;

        }
        public void Create()
        {
            Console.WriteLine($"The language is {this.language}");
        }
        public void Destroy()
        {
            if (language != "c#")
            {
                Console.WriteLine("your language isn't c# ");
            }
            else
            {
                Console.WriteLine("your language is c#");
            }
        }
        public Programmer() { }
        public int CompareTo(object o)
        {
            Programmer p = o as Programmer;
            if (p != null)
                return this.Tool.CompareTo(p.Tool);
            else
                throw new ArgumentException("Object is not a developer");
        }
    }
}
