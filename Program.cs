using System;

namespace HM._6._3.Dima
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the 10 numbers");
                Console.Write("the start=");
                int start = Convert.ToInt32(Console.ReadLine());
                Console.Write("number1=");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("number2=");
                if (number1 < start)
                {
                    throw new Exception("number1 must be > start");
                }
                int number2 = Convert.ToInt32(Console.ReadLine());
                if (number1 > number2)
                {
                    throw new Exception("number1 must be < number2");
                }
                Console.Write("number3=");
                int number3 = Convert.ToInt32(Console.ReadLine());
                if (number2 > number3)
                {
                    throw new Exception("number2 must be < number3");
                }
                Console.Write("number4=");
                int number4 = Convert.ToInt32(Console.ReadLine());
                if (number3 > number4)
                {
                    throw new Exception("number3 must be < number4");
                }
                Console.Write("number5=");
                int number5 = Convert.ToInt32(Console.ReadLine());
                if (number4 > number5)
                {
                    throw new Exception("number4 must be < number5");
                }
                Console.Write("number6=");
                int number6 = Convert.ToInt32(Console.ReadLine());
                if (number5 > number6)
                {
                    throw new Exception("number5 must be < number6");
                }
                Console.Write("number7=");
                int number7 = Convert.ToInt32(Console.ReadLine());
                if (number6 > number7)
                {
                    throw new Exception("number6 must be < number7");
                }
                Console.Write("number8=");
                int number8 = Convert.ToInt32(Console.ReadLine());
                if (number7 > number8)
                {
                    throw new Exception("number7 must be < number8");
                }
                Console.Write("number9=");
                int number9 = Convert.ToInt32(Console.ReadLine());
                if (number8 > number9)
                {
                    throw new Exception("number8 must be < number9");
                }
                Console.Write("the end=");
                int end = Convert.ToInt32(Console.ReadLine());
                Console.Write("number10=");
                int number10 = Convert.ToInt32(Console.ReadLine());
                if (number9 > number10)
                {
                    throw new Exception("number9 must be < number10");
                }
                if (number10 > end)
                {
                    throw new Exception("number10 must be < end");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static int ReadNumber(int start, int end)
        {
            return start;
            return end;

        }
    }
}
// Якщо маєте можливість, то скиньте, яким б мав бути правильний код до цього завдання