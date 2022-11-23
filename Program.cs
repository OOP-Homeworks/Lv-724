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

            List<INomer> numlist = new List<INomer>();
        start:
            Console.Write("Enter start numer -");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end number -");
            int end = Convert.ToInt32(Console.ReadLine());
            if ((start > end) || ((end - start)<10)) { throw new ApplicationException("end must beb > start more than 10"); }
        odn:

            try
            {
                Console.Write("Enter 1 of 10 numbers between start and end =");
                int num = Convert.ToInt32(Console.ReadLine());
                if ((num > end) || (start > num) || (num==start) || (num == end)) { throw new SystemException(); }
                numlist.Add(new Number(num));
                int a = num;
            ds:
                for (int i = 1; i < 10; i++)
                {
                    Console.Write("Enter {0} of 10 numbers between start and end =",i+1);
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    if ((num1 < a) || (num1 > end) || (num1 == a)) { throw new Exception(); }
                    numlist.Add(new Number(num1));
                    a = num1;


                }
                for (int i = 0; i < numlist.Count; i++)
                {
                    numlist[i].ToString();
                }
            }
            catch (SystemException x)
            {
                Console.WriteLine("num must be b > start and < end ");
                goto odn;

            }

            catch (ApplicationException x)
            {
                Console.WriteLine(x.Message);
                goto start;

            }
            catch (Exception ap)
            {
                Console.WriteLine("num must be biger > elier number and < end ");
                goto odn;

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