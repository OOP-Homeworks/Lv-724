using System;
using System.Reflection.Emit;
using System.Threading;

namespace DudnykHW5
{
    internal class Program
    {
        static void Main()
        {
            // Task 1, 2
            int firstVal, secondVal;

            Begining:
            try 
            { 
                Console.Write("Enter first number: ");
                firstVal = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                secondVal = Convert.ToInt32(Console.ReadLine());
                if (secondVal == 0) 
                    throw new DivideByZeroException();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                goto Begining;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto Begining;
            }


            Console.WriteLine(Div(firstVal, secondVal));


        // Task 3
            label2: 
            int start, end;
            Console.Write("Enter start number: ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end number: ");
            end = Convert.ToInt32(Console.ReadLine());

            try
            {
                int[] array = ReadNumber(start, end);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto label2;
            }

            Console.WriteLine("All good");
          
        }

        static double Div(int firstVal, int secondVal)
        {
            return (double) firstVal / secondVal;
        }

        static int[] ReadNumber (int start, int end)
        {
            int arrSize = end - start;
            if (arrSize < 10)
                throw new Exception ("There is no room for 10 integer numbers to be in range");

            int[] array = new int [arrSize];

            for (int i = 0; i < arrSize; i++)
            {                
                Console.Write($"Enter the {i} integer: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

                if (array[i] < start || array[i] > end)
                {
                    throw new Exception("Out of bounds, try again");
                }

                if ((i > 0) && (array[i] < array[i - 1]))
                {
                    throw new Exception("This number is smaller than previous, must be bigger");
                }

            }

            return array;
            
        }
    }
}
