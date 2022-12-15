namespace Homework_8
{
    public class Square : Shape
    {
        private int _side;

        public Square(string name, int side) : base(name)
        {
            _side = side;
        }

        public override void Area()
        {
            base.Area1 = _side * _side;
            Console.WriteLine($"Area of square is : {base.Area1}");
        }

        public override void Perimeter()
        {
            base.Perimeter1 = 4 * _side;
            Console.WriteLine($"Perimeter of square is : {base.Perimeter1}");
        }
    }
}
