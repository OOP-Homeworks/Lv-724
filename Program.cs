using System;
using System.Collections.Generic;

namespace HomeWork5._2.Dima
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> catalogue = new Dictionary<uint, string>();
            catalogue.Add(11, "Julia");
            catalogue.Add(12, "Ivan");
            catalogue.Add(13, "Dima");
            catalogue.Add(14, "Petro");
            catalogue.Add(15, "Ivanka");
            catalogue.Add(16, "Zorana");
            catalogue.Add(17, "Veronika");
            Console.WriteLine("Enter the ID");
            string numbers = Console.ReadLine();
            uint number = Convert.ToUInt32(numbers);
            foreach (char c in catalogue.Keys)
            {
                if (c == number)
                {
                    Console.WriteLine($"The name is {catalogue[c]}");
                }
                else if (c != number)
                {
                    Console.WriteLine("No name with such ID");
                }
                //Я зробив, що на всі інші ID пише "No name with such ID", а щоб просто виводилось, якщо нема такого ID не додумався
            }
        }
    }
}
