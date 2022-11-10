using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01_tast_01
{
    struct Dog
    {
        public string name;
        public string mark;
        public int age;
        public override string ToString()
        {
            return string.Format( "MyDog = ({0},{1},{2})",name, mark, age);
        }
    };
    class Program1
    {
        enum Errors { Not_Found=404, Bad_Request=400, Unauthorized=401,Payment_Required=402, Forbidden=403 };
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.Write("Enter first number= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number= ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third number= ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((a > -5 && a < 5) && (b > -5 && b < 5) && (c > -5 && c < 5) ? "All is Ok!" : "Uncorrect numbers");
            Console.ReadKey();

            Console.WriteLine("Task 2");
            Console.Write("Enter first number= ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number= ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number= ");
            int third = Convert.ToInt32(Console.ReadLine());
            int max, min;
            Console.Write("max = ");
            Console.Write((first > second && first > third) ? max = first :
                (second > first && second > third) ? max = second :
                (third > first && third > second) ? max = third:"ok");
            Console.Write("min = ");
            Console.Write((first < second && first < third) ? min = first :
               (second < first && second < third) ? min = second :
               (third < first && third < second) ? min = third : "ok");
            Console.ReadKey();

            Console.Write("Task 3");
            Console.WriteLine("Some Errors: ");
            Console.WriteLine("400 = {0}",Errors.Bad_Request);
            Console.WriteLine("401 = {1}", Errors.Unauthorized);
            Console.WriteLine("402 = {2}", Errors.Payment_Required);
            Console.WriteLine("403 = {3}", Errors.Forbidden);
            Console.WriteLine("404 = {1}", Errors.Not_Found);
            Console.ReadKey();

            Console.WriteLine("Task 4");
            Dog MyDog;
            MyDog.age = 3;
            MyDog.name = "Demon  ";
            MyDog.mark = "Hasky  ";
            Console.WriteLine(MyDog);
            Console.ReadKey();
            

        }
    }
    

}