
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>(9);
            FileInfo phonesFile = new FileInfo(@"C:\Users\Dell\Desktop\phones.txt");
            using (StreamReader sr = new StreamReader(phonesFile.FullName, System.Text.Encoding.Default))
            {
                string[] str = new string[9];
                string[] Name = new string[9];
                string[] Number = new string[9];
                string temp = "";
                for (int i = 0; i < 9; i++)
                {
                    str[i] = File.ReadLines(@"C:\Users\Dell\Desktop\phones.txt").Skip(i).First();
                    temp = str[i];
                    for (int k = 0; k < temp.Length; k++)
                    {
                        if (char.IsLetter(temp[k]))
                        {
                            Name[i] = Name[i] + temp[k].ToString();
                        }
                        else if (temp[k] == ' ')
                        {
                            continue;
                        }
                        else
                        {
                            Number[i] = Number[i] + temp[k];
                        }
                    }
                    //Console.WriteLine(Number[i] + " " + Name[i]);
                    PhoneBook.Add(Name[i], Number[i]);
                }
            }
            Console.Write("Enter the name to find a phone number:");
            string name = Convert.ToString(Console.ReadLine());
            bool found = true;
            foreach (KeyValuePair<string, string> keyValue in PhoneBook)
            {
                if (keyValue.Key == name)
                {
                    Console.WriteLine($"Name = {keyValue.Key} Phone number: {keyValue.Value}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Name is not found");
            }

            string writePath = @"C:\Users\Dell\Desktop\Phones1.txt";
            using (StreamWriter writer = new(writePath, true, System.Text.Encoding.Default))
            {
                foreach (KeyValuePair<string, string> keyValue in PhoneBook)
                {
                    writer.WriteLine(keyValue.Value);
                }
            }

            string writePath1 = @"C:\Users\Dell\Desktop\New.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(writePath1, false, System.Text.Encoding.Default))
                {
                    foreach (KeyValuePair<string, string> keyValue in PhoneBook)
                    {
                        if (!keyValue.Key.StartsWith("+3"))
                        {
                            writer.WriteLine("+3" + keyValue.Key + " " + keyValue.Value);
                        }
                        else
                        {
                            writer.WriteLine(keyValue.Key + " " + keyValue.Value);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}