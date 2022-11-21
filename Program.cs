using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06_tast_06
{
    class Program
    {
         static void Main(string[] args)
        {
        start:
            try
            {
                Console.WriteLine("Enter int one -");
                double one = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter int two -");
                double two = Convert.ToDouble(Console.ReadLine());
                if (two == 0) { throw  new DivideByZeroException(); }
                Console.WriteLine("{0}/{1}={0} ",one, two, Div(one, two));
                if (one < two) { throw new ApplicationException(" one must be >b"); }
                Console.WriteLine("{0}/{1}={0} ", one, two, Div(one, two));
            }
            catch (DivideByZeroException rx)
            {
                Console.WriteLine(rx.Message);
                goto start;
               
            }
            catch (FormatException x)
            {
                Console.WriteLine(x.Message);
                goto start;

            }
            catch (ApplicationException ap)
            {
                Console.WriteLine(ap.Message);
                goto start;

            }
            finally
            {
                Console.WriteLine("The End");
                Console.WriteLine("________");
            }
        }
        private static double Div(double a, double b)
        {
            return a / b;
        }

    }
}