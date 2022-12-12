using System;
using System.Collections.Generic;
using System.IO;

namespace HM7.Dima
{
    class Program
    {
        static void Main(string[] args)
        {
            string phones = @"D:\c#\softserve\for 7 hm\phones.txt"; ;
            string phoneBook = @"D:\c#\softserve\for 7 hm\phoneBook.txt";
            int i = 0;
            Dictionary<string, string> Note = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader(phones, System.Text.Encoding.Default))
            {
                using (StreamWriter wr = new StreamWriter(phoneBook, false, System.Text.Encoding.Default))
                    while (i <= 9)
                {
                    string[] thing = sr.ReadLine().Split(",");
                    Note.Add(thing[0], thing[1]);
                    wr.WriteLine(thing[1]);
                    i++;
                }
            }
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
           foreach (KeyValuePair<string, string> c in Note)
            {
                if (c.Value == name)
                {
                    Console.WriteLine($"the {c.Value} number is {c.Key}");
                }
                if (c.Key.StartsWith("8"))
                {
                    Console.WriteLine($"The true {c.Value} number is +3{c.Key} instead {c.Key}");
                }
            }
        }
    }
}
