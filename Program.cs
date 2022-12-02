using System;
using System.Collections.Generic;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var flyable = new List<IFlyable>();
            flyable.Add(new Bird("King Penguin", false));
            flyable.Add(new Bird("Amazon Parrot", true));
            flyable.Add(new Bird("American Crow", true));
            flyable.Add(new Plane("Beechcraft Baron", 123));
            flyable.Add(new Plane("Gulfstream G450", 654));
            flyable.Add(new Plane("Boing", 999));

            foreach (var flyableObjects in flyable)
            {
                Console.WriteLine(flyableObjects.Fly());
            }
        }
    }
}
