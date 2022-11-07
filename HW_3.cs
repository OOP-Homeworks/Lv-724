using System;

namespace lecure_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //task a
            Console.WriteLine("Enter string:");
            string str = Convert.ToString(Console.ReadLine());
            int count = 0;
            foreach (char x in str)
            {
                if (x=='a'|| x=='o' || x=='e' || x=='i' || x=='u')
                {
                    count++;
                }
            }
            Console.WriteLine($"number of vowels: {count}");
            
            //task b
            Console.WriteLine("Enter number of month:");
            int month = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter year:");
            int year  = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"days in month: {DateTime.DaysInMonth(year,month)}");
            
            //task c
            int[] nums= new int[10];
            Console.WriteLine("enter 10 numbers: ");
            int sum = 0;
            long product = 0;
           
            for (int i = 0; i < 10; i++)
            {
                int x = Convert.ToInt16(Console.ReadLine());
                nums[i] = x;
                if( i <= 4)
                {
                    if (nums[i] < 0 )
                    {
                        sum = 0;
                        i = 4;
                        product = 1;
                    }
                    else
                    {
                        sum += nums[i];
                    }
                }
                if(i>4)
                {
                    product *= nums[i];
                }
            }
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"product:{product}");
        }
    }
}