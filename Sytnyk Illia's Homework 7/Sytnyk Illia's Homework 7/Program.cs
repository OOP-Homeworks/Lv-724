using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Sytnyk_Illia_s_Homework_7
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            string readPath = @"D:\KPI\Codes\Softserves's homeworks\Sytnyk Illia's Homework 7\Contacts_List.txt";
            string writePath = @"D:\KPI\Codes\Softserves's homeworks\Sytnyk Illia's Homework 7\Phones.txt";
            string newFile = @"D:\KPI\Codes\Softserves's homeworks\Sytnyk Illia's Homework 7\New.txt";

            try
            {
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                    {
                        using (StreamWriter sw_new = new StreamWriter(newFile, false, System.Text.Encoding.Default))
                        {
                            int i = 0;
                            while (i < 9)
                            {
                                string[] input = sr.ReadLine().Split(';');
                                PhoneBook.Add(input[0], input[1].ToLower()); //приводимо імена до нижнього регистру для кращого пошуку
                                sw.WriteLine(input[0]);

                                sw_new.WriteLine(Correct_Number(input[0])); //змінюємо на новий формат +380...
                                i++;
                            }
                        }
                    }
                }

            Find_Contact:
                Console.Write("Enter the name in contact list: ");
                string ContactName = Convert.ToString(Console.ReadLine()).ToLower(); //приводимо ім'я, яке шукаємо, до нижнього регистру для кращого пошуку
                bool Contact_found = false;
                foreach (KeyValuePair<string, string> keyValue in PhoneBook)
                {
                    if (keyValue.Value == ContactName)
                    {
                        Console.WriteLine($"Phone number of the contact: {keyValue.Key}");
                        Contact_found = true;
                    }
                }
                if (Contact_found == false)
                {
                    Console.WriteLine($"Any ---{ContactName.ToUpper()}--- in contact list");
                    Console.WriteLine("Try find contact again :)\n");
                    goto Find_Contact;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            static string Correct_Number(string phone_number)
            {
                switch (phone_number[0])
                {
                    case '3': phone_number = "+" + phone_number; break;
                    case '8': phone_number = "+3" + phone_number; break;
                    case '0': phone_number = "+38" + phone_number; break;
                }
            return phone_number;
            }
        }
    }
}
