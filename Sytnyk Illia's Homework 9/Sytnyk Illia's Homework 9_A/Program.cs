using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sytnyk_Illia_s_Homework_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Shapes = new List<Shape>();
            Shapes.Add(new Circle("сircle_1", 8.5));
            Shapes.Add(new Square("square_1", 15));
            Shapes.Add(new Circle("сircle_2", 4));
            Shapes.Add(new Square("square_2", 1));
            Shapes.Add(new Square("square_3", 7));
            Shapes.Add(new Circle("сircle_3", 9));

            string shapes_path = @"D:\\KPI\\Codes\\Softserves's homeworks\\Sytnyk Illia's Homework 9\shapes.txt";
            using (StreamWriter sw = new StreamWriter(shapes_path, false, System.Text.Encoding.Default))
            {
                var shapes = from s in Shapes
                            where s.Area() > 10 && s.Area() < 100
                            select s;
                foreach (var shape in shapes)
                    sw.WriteLine("Shape name: {0}\t\t Area: {1:F3}\t\t Perimeter: {2:F3}", shape.Name, shape.Area(), shape.Perimeter());
                //foreach (Shape s in Shapes)
                //{
                //    if (s.Area() > 10 && s.Area() < 100)
                //    {
                //        sw.WriteLine("Shape name: {0}\t\t Area: {1:F3}\t\t Perimeter: {2:F3}", s.Name, s.Area(), s.Perimeter());
                //    }
                //}
            }

            string letter_path = @"D:\\KPI\\Codes\\Softserves's homeworks\\Sytnyk Illia's Homework 9\letter_contains.txt";
            using (StreamWriter sw_2 = new StreamWriter(letter_path, false, System.Text.Encoding.Default))
            {
                char c = 'a';
                var shapes_2 = from s in Shapes
                             where s.Name.WordCount(c) > 0
                             select s;
                foreach (var shape in shapes_2)
                    sw_2.WriteLine("Shape name: {0}\t\t Area: {1:F3}\t\t Perimeter: {2:F3}", shape.Name, shape.Area(), shape.Perimeter());
                //foreach (Shape s in Shapes)
                //{
                //    char c = 'a';
                //    if (s.Name.WordCount(c) > 0)
                //    {
                //        sw_2.WriteLine("Shape name: {0}\t\t Area: {1:F3}\t\t Perimeter: {2:F3}", s.Name, s.Area(), s.Perimeter());
                //    }
                //}
            }

            var shapes_3 = from s in Shapes.ToList()
                           where s.Perimeter() < 5
                           select s;
            foreach (var shape in shapes_3)
                Shapes.Remove(shape);
            foreach (Shape s in Shapes)
            {
                Console.WriteLine("Shape name: {0}\t\t Area: {1:F3}\t\t Perimeter: {2:F3}", s.Name, s.Area(), s.Perimeter());
            }

            //foreach (Shape s in Shapes.ToList())
            //{
            //    if (s.Perimeter() < 5)
            //    {
            //        Shapes.Remove(s);
            //    }
            //}
            //foreach (Shape s in Shapes)
            //{
            //    Console.WriteLine("Shape name: {0}\t\t Area: {1:F3}\t\t Perimeter: {2:F3}", s.Name, s.Area(), s.Perimeter());
            //}

            //for (int i = 0; i < Shapes.Count; i++)
            //{
            //    if (Shapes[i].Perimeter() < 5)
            //    {
            //        Shapes.Remove(Shapes[i]);
            //    }
            //    Console.WriteLine("Shape name: {0}\t\t Area: {1:F3}\t\t Perimeter: {2:F3}", Shapes[i].Name, Shapes[i].Area(), Shapes[i].Perimeter());
            //}
        }
    }
}
