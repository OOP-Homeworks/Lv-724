using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AndriyOstapchuk_HW_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HomeWork 1 /////////////////////////////////////////////////////
            Console.WriteLine("Enter float number A: ");
            float floatOne = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter float number B: ");
            float floatTwo = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter float number C: ");
            float floatThree = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Let`s check if floats A, B and C are in range of [-5; 5]");

            string resultCheckFloatOne = floatOne >= -5 && floatOne <= 5 ? "Float A is  in range!" : "Float A is OUT of range";
            string resultCheckFloatTwo = floatTwo >= -5 && floatTwo <= 5 ? "Float B is  in range!" : "Float B is OUT of range";
            string resultCheckFloatThree = floatThree >= -5 && floatThree <= 5 ? "Float C is  in range!" : "Float C is OUT of range";

            Console.WriteLine(resultCheckFloatOne);
            Console.WriteLine(resultCheckFloatTwo);
            Console.WriteLine(resultCheckFloatThree);

            Console.ReadKey();

            //HomeWork 2 /////////////////////////////////////////////////////

            Console.WriteLine("Enter one by one three integers:");
            int intOne = Convert.ToInt32(Console.ReadLine());
            int intTwo = Convert.ToInt32(Console.ReadLine());
            int intThree = Convert.ToInt32(Console.ReadLine());

            string resultMax = intOne > intTwo && intOne > intThree ? $"{intOne} is a a Biggest number" :
                            intTwo > intOne && intTwo > intThree ? $"{intTwo} is a a Biggest number" :
                            intThree > intOne && intThree > intTwo ? $"{intThree} is a a Biggest number" : "They are equal";

            string resultMin = intOne < intTwo && intOne < intThree ? $"{intOne} is a a Smallest number" :
                            intTwo < intOne && intTwo < intThree ? $"{intTwo} is a a Smallest number" :
                            intThree < intOne && intThree < intTwo ? $"{intThree} is a a Smallest number" : "They are equal";

            Console.WriteLine(resultMax);
            Console.WriteLine(resultMin);

            Console.ReadKey();


            //HomeWork 2.2 ///////////
            Console.ReadKey();

            int[] numbersArray = new int[3] { 1, 2, 3 };
            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine(numbersArray[i]);
            }
            Console.WriteLine("Max is: " + numbersArray.Min().ToString());
            Console.WriteLine("Min is: " + numbersArray.Max().ToString());

            Console.ReadKey();


            //HomeWork 2.3 ///////////
            Console.Write("How many numbers will you compare? ");
            int arraySize = Convert.ToInt32(Console.ReadLine());        //Set an  Array Size
            int[] arrayToCheck = new int[arraySize];                    //Create new Array with setted size
            Console.WriteLine("Ok! Please input {0} numbers to compare", arraySize);
            for (int i = 0; i < arraySize; i++)                         //Fill an Array
            {
                arrayToCheck[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("You entered:");
            for (int i = 0; i < arrayToCheck.Length; i++)               //Output entered to aaray numbers
            {

                Console.Write(arrayToCheck[i] + " ");

            }

            Console.WriteLine();
            Console.WriteLine("Max is: " + arrayToCheck.Min().ToString()); //Chek for Max
            Console.WriteLine("Min is: " + arrayToCheck.Max().ToString()); //Check for Min


            //HomeWork 3 /////////////////////////////////////////////////////
            Console.Write("Enter Error number: ");
            string errorNumber = (Console.ReadLine());
            switch (errorNumber)
            {
                case "1":
                    Console.WriteLine(HTTPError.Error400);
                    break;
                case "2":
                    Console.WriteLine(HTTPError.Error401);
                    break;
                case "3":
                    Console.WriteLine(HTTPError.Error402);
                    break;
                default:
                    break;
            }

            //HomeWork 3.1 /////////////////
            var errorName = (HTTPError)1;
            Console.WriteLine(errorName);

            Console.ReadKey();

            //HomeWork 4 /////////////////////////////////////////////////////
            Dog myDog = new Dog();
            myDog.Name = "Bobik";
            myDog.Mark = "Nobleman";
            myDog.Age = 2;

            Console.WriteLine($"Dog name is {myDog.name}, his mark is {myDog.mark} and his age is {myDog.age} years");
            Console.ReadKey();




        }

        enum HTTPError
        {
            Error400 = 1,
            Error401,
            Error402
        }

        struct Dog
        {
            public string Name { get; set; }
            public string Mark { get; set; }
            public int Age { get; set; }
        }

        

        
    }
}
