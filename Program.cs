namespace Homework_8
{
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
}