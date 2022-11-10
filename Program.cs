using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01_tast_01
{
    class Program1
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Task 1");
            Console.Write("Enter text= ");
            string text = Console.ReadLine();
            int counter_a = 0;
            int counter_o = 0;
            int counter_u = 0;
            int counter_i = 0;
            int counter_e = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='a')
                {
                    counter_a++;
                }
                if (text[i] == 'o')
                {
                    counter_o++;
                }
                if (text[i] == 'e')
                {
                    counter_e++;
                }
                if (text[i] == 'u')
                {
                    counter_u++;
                }
                if (text[i] == 'i')
                {
                    counter_i++;
                }
            }
            Console.WriteLine("Leter a was used {0} times",counter_a);
            Console.WriteLine("Leter e was used {0} times", counter_e);
            Console.WriteLine("Leter u was used {0} times", counter_u);
            Console.WriteLine("Leter i was used {0} times", counter_i);
            Console.WriteLine("Leter o was used {0} times", counter_o);
            Console.ReadKey();
            
            Console.WriteLine("Task 4");
            Console.Write("Enter the number of month =  ");
            int month = Convert.ToInt32(Console.ReadLine());
            int days = 0;
           if((month == 1) ||(month == 3) || (month == 5) || (month == 7) || (month == 8) || (month == 10) || (month == 12))
            {
                days = 31;
            }
            else if ((month == 4) || (month == 6) || (month == 9) || (month == 11))
                {
                    days = 30;
                }
            else if (month ==2)
            {
                Console.Write("Enter the number of year =  ");
                int year = Convert.ToInt32(Console.ReadLine());
                if ((year%4==0)&&(year%100!=0) || (year % 100 == 0) && (year % 400 == 0))
                {
                    days = 29;
                }
                else
                {
                    days = 28;
                }
            }
            Console.WriteLine("Days at this month ={0}", days);
            Console.ReadKey();
            
             Console.WriteLine("Task 3");

                 Console.Write("Enter 10 numbers ");
            int sum = 0, dob=1, cout=0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("x =  ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num>=0 && i<5)
                {
                    sum = sum + num;
                }
                if(num<0 && i < 5)
                {
                    cout++;

                }
                if (num>+0 && i > 5)
                {
                    dob = dob * num;
                   
                }
            }
            if (cout!=0)
            {
                Console.WriteLine("Sum first 5 mubbers is = {0}",sum);
            }
            else
            {
                Console.WriteLine("One of the first 5 mubbers is negativ");
                Console.WriteLine("product of last 5 element is = {0}",dob);

            }
            Console.ReadKey();
            


        }
    }

}


