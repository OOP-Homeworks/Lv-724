using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HW9
{
    class Program
    {

        public static void textParser()
        {
            string path = @"C:\Users\V\Desktop\С#\1\Seletskiy_Homeworks\Seletskiy_Homeworks\HW9\input.txt";
            string[] text = File.ReadAllLines(path);
            using (StreamReader sw = new StreamReader(path, false))
            {
                int totalSymbolCount = 0;
                foreach (string i in text)
                {
                    totalSymbolCount += i.Length;
                }
                Console.WriteLine("Total symbol count equals {0}", totalSymbolCount);

                var theLongestLine = text.OrderByDescending(a => a.Length).First().ToString();
                var theShortestLine = text.OrderBy(a => a.Length).First().ToString();

                Console.WriteLine("The longest line is that one {0}, \nthe shortest is this one: {1}", theLongestLine, theShortestLine);

                Console.WriteLine("The line which consist of word var (spoiler: I used none of these):");
                var line = from x in text where x.Contains("var") select x;
                foreach (var item in line)
                {
                    Console.WriteLine(item);
                }

            }
        }

        static void Main(string[] args)
        {
            List<Shape> myList = new List<Shape>();
            int switchFlag = 0;
            while (switchFlag != -1)
            {
                switch (switchFlag)
                {
                    case 0:
                        Console.WriteLine("Enter 1 to enter a circle, 2 to enter a square or -1 to end the input:");
                        switchFlag = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 1:
                        Console.WriteLine("Enter the name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the radius:");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        myList.Add(new Circle(name, radius));
                        Console.WriteLine("Enter 1 to enter a circle, 2 to enter a square or -1 to end the input:");
                        switchFlag = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Enter the name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter the side:");
                        double side = Convert.ToDouble(Console.ReadLine());
                        myList.Add(new Square(name, side));
                        Console.WriteLine("Enter 1 to enter a circle, 2 to enter a square or -1 to end the input:");
                        switchFlag = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Enter 1 or 2. -1 exits the loop");
                        break;
                }
            }

            string path = @"C:\Users\V\Desktop\С#\1\Seletskiy_Homeworks\Seletskiy_Homeworks\HW9\writeHere.txt";
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                foreach (Shape shape in myList)
                {
                    if (shape.Area() >= 10 && shape.Area() <= 100)
                    {
                        sw.WriteLine("Name: {0}, value of area: {1}", shape.Name, shape.Area());
                    }
                    if (shape.Name.Contains("a"))
                    {
                        sw.WriteLine("Name: {0}", shape.Name);
                    }
                }

                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].Perimeter() < 5)
                    {
                        myList.Remove(myList[i]);
                    }
                    Console.WriteLine("Shape {0} with a perimeter of {1};", myList[i].Name, myList[i].Perimeter());
                }
            }

            textParser();
        }
    }
}
