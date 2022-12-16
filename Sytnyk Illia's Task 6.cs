using System;

namespace Sytnyk_Illia_s_Task_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        start:
            try
            {
                Console.WriteLine("Enter 2 integer numbers (first number > 10): ");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                if (a == 0) { throw new ArgumentNullException("First number can`t be 0"); }
                if (a <= 10) { throw new ApplicationException("First number should be > 10"); }
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                if (b == 0) { throw new DivideByZeroException(); }
                Console.WriteLine("{0} / {1} = {2}", a, b, Div_d(a, b));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                goto start;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto start;
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
                goto start;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                goto start;
            }
            finally
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Program is complete!");
                Console.WriteLine("--------------------\n");
            }
            Console.ReadKey();

            static double Div_d(double num1, double num2)
            {
                return num1 / num2;

            }

        }
    }
}