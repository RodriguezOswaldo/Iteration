using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration
{
    class RandomNumbers
    {
        public static void newRandom()
        {
            var random = new Random();
            int number = random.Next(1, 20);
            for (var i = 0; i != number; i++)
                Console.WriteLine(i);
                Console.WriteLine("no the number");
                
        }
    }
}
