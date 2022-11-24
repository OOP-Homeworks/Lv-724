using System;
using System.Collections.Generic;

namespace Sytnyk_Illia_s_Homework_5
{
    interface IDeveloper
    {
        string Tool { get; set; }
        void Create();
        void Destroy();
    }

    class Programmer : IDeveloper, IComparable
    {
        private string language;
        public Programmer(string language)
        {
            this.language = language;
        }
        public string Tool
        {
            get { return language; }
            set { language = value; }
        }
        public void Create()
        {
            Console.WriteLine($"Create Programmer with code on {language} language");
        }
        public void Destroy()
        {
            Console.WriteLine($"Destroy Programmer with code on {language} language");
        }
        public int CompareTo(object o)
        {
            Programmer p = o as Programmer;
            Builder b = o as Builder;
            if (p != null)
                return this.Tool.CompareTo(p.Tool);
            else if (b != null)
                return this.Tool.CompareTo(b.Tool);
            else return 0;
        }
    }

    class Builder : IDeveloper, IComparable
    {
        private string tool;
        public Builder(string tool)
        {
            this.tool = tool;
        }
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }
        public void Create()
        {
            Console.WriteLine($"Create Builder with {tool} tool"); ;
        }
        public void Destroy()
        {
            Console.WriteLine($"Destroy Builder with {tool} tool");
        }

        public int CompareTo(object o)
        {
            Builder b = o as Builder;
            Programmer p = o as Programmer;
            if (b != null)
                return this.Tool.CompareTo(b.Tool);
            else if (p != null)
                return this.Tool.CompareTo(p.Tool);
            else return 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            List<IDeveloper> dev_list = new List<IDeveloper>();
            dev_list.Add(new Programmer("C#"));
            dev_list.Add(new Programmer("C++"));
            dev_list.Add(new Programmer("C"));
            dev_list.Add(new Programmer("Python"));
            dev_list.Add(new Builder("Laptop"));
            dev_list.Add(new Builder("Personal Computer"));
            dev_list.Add(new Builder("MacBook"));

            for (int i = 0; i < dev_list.Count; i++)
            {
                dev_list[i].Create();
                dev_list[i].Destroy();
            }

            dev_list.Sort();
            Console.WriteLine("\nSorted:\n");
            for (int i = 0; i < dev_list.Count; i++)
            {
                Console.WriteLine(dev_list[i].Tool);
            }
            Console.ReadKey();


            //Task 2
            Console.WriteLine("------------------------------");
            Console.WriteLine("\nTask 2:\n");

            Dictionary<uint, string> contacts_list = new Dictionary<uint, string>();
            contacts_list.Add(1, "Illia");
            contacts_list.Add(2, "Yulia");
            contacts_list.Add(3, "Denis");
            contacts_list.Add(4, "Eva");
            contacts_list.Add(5, "Petro");
            contacts_list.Add(6, "Sofia");
            contacts_list.Add(7, "Mykyta");

            Console.Write("Enter the person`s ID to find his/her name in contacts list: ");
            uint cor_name = Convert.ToUInt32(Console.ReadLine());
            bool find = false;

            foreach (KeyValuePair<uint, string> kvp in contacts_list)
            {
                if (cor_name == kvp.Key)
                {
                    Console.WriteLine($"\nPerson`s ID is {kvp.Key} and name is {kvp.Value}");
                    find = true;
                }
            }

            if (find == false)
                Console.WriteLine("Person isn`t found");
        }
    }
}
