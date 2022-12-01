using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Shape> shapes = new List<Shape>();

            bool ifTrue = true;


            for (int i = 0; i < 2; i++)
            {
            start:
                Console.Write("Enter the name of shapes (circle or square): ");
                string nameOfShapes = Console.ReadLine();
                if (nameOfShapes == "circle")
                {
                startR:
                    try
                    {
                        Console.Write("Enter the radius: ");
                        double radiusCircle = Convert.ToDouble(Console.ReadLine());
                        if (radiusCircle <= 0)
                        {
                            goto startR;
                        }

                        shapes.Add(new Circle("circle", radiusCircle));

                        ifTrue = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid number!");
                        goto startR;
                    }

                }
                if (nameOfShapes == "square")
                {
                startS:
                    try
                    {
                        Console.Write("Enter the side: ");
                        double sideSquare = Convert.ToDouble(Console.ReadLine());
                        if (sideSquare <= 0)
                        {
                            goto startS;
                        }

                        shapes.Add(new Square("square", sideSquare));
                        ifTrue = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid number!");
                        goto startS;
                    }

                }
                if (ifTrue)
                {
                    Console.WriteLine("There isn't such shapes!");
                    goto start;
                }
            }

            double buff=0;

            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Print();
            }
            Console.WriteLine("------------");
            for (int i = 1; i < shapes.Count; i++)
            {

                if (shapes[i].Perimeter() > shapes[i - 1].Perimeter())
                {
                    buff = shapes[i].Perimeter();


                }
                else
                {
                    buff = shapes[0].Perimeter();
                }
            }
            Console.WriteLine("The largest perimetr is: {0} ",buff);
            Console.WriteLine("------------");
            shapes.Sort();
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Print();
            }
        }

    }
}
