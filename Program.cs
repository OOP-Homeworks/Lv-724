
﻿using System;
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

    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfShapes = new List<Shape>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Which figure do you choose? \n1.Circle or \n2.Square?");
                var userInput = Console.ReadKey().KeyChar;
                if (userInput == '1')
                {
                    Console.WriteLine("Give me a length of the radius");
                    var length = Console.ReadLine();
                    Console.WriteLine("Give me a name");
                    var name = Console.ReadLine();
                    var shape = new Circle(name, int.Parse(length));
                    listOfShapes.Add(shape);

                }
                else
                {
                    Console.WriteLine("Give me a length of the side");
                    var length = Console.ReadLine();
                    Console.WriteLine("Give me a name");
                    var name = Console.ReadLine();
                    var shape = new Square(name, int.Parse(length));
                    listOfShapes.Add(shape);

                }
            }

            foreach (var item in listOfShapes)
            {
                Console.WriteLine($"{item.Name}");
                item.Area();
                item.Perimeter();
            }

            var biggest = listOfShapes.OrderByDescending(e => e.Perimeter1)
                .First();
            Console.WriteLine($"{biggest.Name} is the biggest {biggest.Perimeter1}");

            listOfShapes = listOfShapes.OrderBy(e => e.Area1)
                .ToList();
            foreach (var item in listOfShapes)
            {
                Console.WriteLine($"Sorted by area : {item.Area1}");
            }
            Console.ReadKey();

        }
    }

