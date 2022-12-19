using System;

namespace Sytnyk_Illia_s_Homework_6
{
    internal class Program
    {

        public static void Main()
        {
        Start_program:
            try
            {
                Console.Write("Enter start number: ");
                int start = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter finish number: ");
                int finish = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
                if (start >= finish) { throw new Exception("Start number can`t be > than finish number"); }
                const int ARRAY_AMOUNT = 12;
                int[] numbers = new int[ARRAY_AMOUNT];
                ReadNumber(start, finish, numbers);
                PrintArray(numbers);
                Console.ReadKey();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start_program;
            }
        }

        public static void ReadNumber(int first, int end, int[] nums)
        {
            const int TEN_NUMBERS = 10;
            nums[0] = first;
            nums[11] = end;
            for (int i = 1; i <= TEN_NUMBERS; i++)
            {
            ErorFind:
                try
                {
                    Console.Write($"Enter {i} number: ");
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                    if (nums[i] <= nums[i - 1]) { throw new ApplicationException("Next number should be > than  previous"); }
                    if (nums[i] > end) { throw new Exception("Next number should be < than end number"); }
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto ErorFind;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto ErorFind;
                }
            }
        }

        public static void PrintArray(int[] nums)
        {
            const int ARRAY_AMOUNT = 12;
            Console.Write("\nArray is: [ ");
            for (int i = 0; i < ARRAY_AMOUNT; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.Write("]");
        }
    }
}