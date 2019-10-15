using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration
{
    public class ForLoop
    {
        public static void moreLoops()
        {
            Console.WriteLine("\n");
            var name = "John Smith";
            for (var i = 0; i < name.Length; i++)
            { 
                Console.WriteLine(name[i]);
            }
            //this one those the exact same thing
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            //Iterate over every number
            var numbers = new int[] {1, 2, 3, 4, 5, 6};
            foreach (var number in numbers)
            {
                Console.WriteLine(number + 9);
            }
        }
    }
}
